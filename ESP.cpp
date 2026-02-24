#include "pch.h"
#include "ESP.h"
#include "Aimbot.h"
#include "GameUtils/GameUtils.h"
#include "GameUtils/MemoryUtils.h"
#include "GameUtils/RttiUtils.h"
#include "TargetingParts.h"

namespace ESP
{
    namespace ESPSettings
    {
        bool g_Enabled = true;
        bool g_ShowBox = true;
        bool g_ShowDot = true;
        bool g_ShowCivilian = true;
        bool g_ShowPolice = true;
        bool g_ShowGanger = true;
        bool g_ShowCyberpsycho = true;
        bool g_ShowOther = true;
        bool g_ShowDead = false;
        float g_MaxDistance = 100.0f;
        bool g_DebugMode = false;
    }

    int g_CachedEntityCount = 0;
    int g_VisibleEntityCount = 0;
    int g_FrameCount = 0;
    const int g_CacheUpdateInterval = 5;
    TargetingDebugInfo g_TargetingDebugInfo = {};

    EntityCache g_EntityCache = {};

    EntityCacheBuffer g_EntityCacheBuffers[2] = {};
    std::atomic<int> g_CurrentReadBufferIndex(0);

    void DrawESPBox(ImDrawList* drawList, const Utils::Vector3& pos, float height, float distance,
                   float screenWidth, float screenHeight, ImU32 color)
    {
        ImVec2 headPos, feetPos;

        Utils::Vector3 headWorld(pos.X, pos.Y, pos.Z + height);
        Utils::Vector3 feetWorld(pos.X, pos.Y, pos.Z);

        if (!GameUtils::WorldToScreen(headWorld, headPos, screenWidth, screenHeight) ||
            !GameUtils::WorldToScreen(feetWorld, feetPos, screenWidth, screenHeight))
            return;

        float boxHeight = abs(feetPos.y - headPos.y);
        float boxWidth = boxHeight * 0.4f;

        float left = headPos.x - boxWidth * 0.5f;
        float right = headPos.x + boxWidth * 0.5f;
        float top = headPos.y;
        float bottom = feetPos.y;

        drawList->AddRect(ImVec2(left, top), ImVec2(right, bottom), color, 0.0f, 0, 2.0f);

        char label[32];
        sprintf_s(label, "%.0fm", distance);
        drawList->AddText(ImVec2(right + 4, top), color, label);
    }

    void DrawESPDot(ImDrawList* drawList, const Utils::Vector3& pos, float distance,
                   float screenWidth, float screenHeight, ImU32 color)
    {
        ImVec2 screenPos;
        if (!GameUtils::WorldToScreen(pos, screenPos, screenWidth, screenHeight))
            return;

        float size = 4.0f;
        drawList->AddCircleFilled(screenPos, size, color);

        char label[32];
        sprintf_s(label, "%.0fm", distance);
        drawList->AddText(ImVec2(screenPos.x + size + 2, screenPos.y - size), color, label);
    }

    void UpdateEntityCache()
    {
        g_FrameCount++;
        
        auto rtti = RED4ext::CRTTISystem::Get();
        if (!rtti) return;

        auto engine = RED4ext::CGameEngine::Get();
        if (!engine || !engine->framework || !engine->framework->gameInstance) return;

        if (!GameUtils::RttiUtils::g_GetEntityListFunc) return;

        RED4ext::ScriptGameInstance scriptGameInstance(engine->framework->gameInstance);
        RED4ext::DynArray<RED4ext::Handle<RED4ext::IScriptable>> entities;

        RED4ext::CStackType args[1];
        args[0].type = rtti->GetType("ScriptGameInstance");
        args[0].value = &scriptGameInstance;

        RED4ext::CStackType resultType;
        resultType.type = rtti->GetType("array:handle:entEntity");
        resultType.value = &entities;

        RED4ext::CStack stack(nullptr, args, 1, &resultType);
        GameUtils::RttiUtils::g_GetEntityListFunc->Execute(&stack);

        if (entities.size == 0)
        {
            g_EntityCache.Reset();
            return;
        }

        auto gamePuppetClass = rtti->GetClass("gamePuppet");
        auto scriptedPuppetClass = rtti->GetClass("ScriptedPuppet");
        auto playerPuppetClass = rtti->GetClass("PlayerPuppet");

        void* playerPtr = GameUtils::g_PlayerHandle ? GameUtils::g_PlayerHandle.GetPtr() : nullptr;

        g_EntityCache.EntityCount = 0;
        g_EntityCache.UpdateFrame = g_FrameCount;

        for (uint32_t i = 0; i < entities.size && g_EntityCache.EntityCount < 500; i++)
        {
            auto& entityHandle = entities[i];
            auto entity = entityHandle.GetPtr();
            if (!entityHandle || !entity) continue;
            if (entity == playerPtr) continue;

            auto nativeType = entity->GetNativeType();
            if (!nativeType) continue;

            bool isPuppet = (gamePuppetClass && nativeType->IsA(gamePuppetClass)) ||
                           (scriptedPuppetClass && nativeType->IsA(scriptedPuppetClass));

            if (!isPuppet) continue;

            if (playerPuppetClass && nativeType->IsA(playerPuppetClass)) continue;

            Utils::Vector3 entityPos = GameUtils::GetEntityPosition(entity);
            if (!entityPos.IsValid())
                continue;

            float dx = entityPos.X - GameUtils::g_PlayerPosition.X;
            float dy = entityPos.Y - GameUtils::g_PlayerPosition.Y;
            float dz = entityPos.Z - GameUtils::g_PlayerPosition.Z;
            float distance = sqrtf(dx * dx + dy * dy + dz * dz);

            if (distance > ESPSettings::g_MaxDistance)
                continue;

            auto& entityData = g_EntityCache.Entities[g_EntityCache.EntityCount];
            entityData.EntityPtr = entity;
            entityData.Position = entityPos;
            entityData.Distance = distance;
            entityData.IsValid = true;
            entityData.DeathFlag = 0;
            entityData.DeathCheckFrame = 0;
            g_EntityCache.EntityCount++;
        }

        int writeIndex = 1 - g_CurrentReadBufferIndex.load(std::memory_order_acquire);
        if (writeIndex < 0 || writeIndex >= 2)
            return;

        auto& writeBuffer = g_EntityCacheBuffers[writeIndex];
        writeBuffer.EntityCount = 0;
        writeBuffer.UpdateFrame = g_FrameCount;

        g_VisibleEntityCount = 0;

        for (int i = 0; i < g_EntityCache.EntityCount && writeBuffer.EntityCount < 150; i++)
        {
            auto& entityData = g_EntityCache.Entities[i];
            if (!entityData.IsValid) continue;
            
            if (!entityData.IsStructureValid())
                continue;

            auto entity = entityData.EntityPtr;
            auto scriptable = static_cast<RED4ext::IScriptable*>(entity);
            if (!scriptable) continue;

            auto nativeType = scriptable->GetNativeType();
            if (!nativeType) continue;

            bool isDead = false;
            if (entityData.DeathFlag == 0)
            {
                isDead = GameUtils::IsEntityDead(entity);
                entityData.DeathFlag = isDead ? 2 : 1;
                entityData.DeathCheckFrame = g_FrameCount;
            }
            else if (entityData.DeathFlag == 2)
            {
                isDead = true;
            }

            if (isDead)
                continue;

            float height = GameUtils::GetEntityHeight(entity);
            if (height <= 0.0f)
                height = 1.8f;

            bool isCivilian = false;
            bool isPolice = false;
            bool isGanger = false;
            bool isCyberpsycho = false;

            bool isScriptedPuppet = scriptedPuppetClass && nativeType->IsA(scriptedPuppetClass);
            
            if (isScriptedPuppet && Utils::IsValidPtr(nativeType))
            {
                auto entityPtr2 = reinterpret_cast<uintptr_t>(entity);

                if (GameUtils::RttiUtils::Properties::g_ScriptedPuppet_IsCivilian)
                {
                    auto isCivilianPtr = reinterpret_cast<bool*>(entityPtr2 + GameUtils::RttiUtils::Properties::g_ScriptedPuppet_IsCivilian->valueOffset);
                    if (Utils::IsValidPtr(isCivilianPtr))
                        isCivilian = *isCivilianPtr;
                }

                if (GameUtils::RttiUtils::Properties::g_ScriptedPuppet_IsPolice)
                {
                    auto isPolicePtr = reinterpret_cast<bool*>(entityPtr2 + GameUtils::RttiUtils::Properties::g_ScriptedPuppet_IsPolice->valueOffset);
                    if (Utils::IsValidPtr(isPolicePtr))
                        isPolice = *isPolicePtr;
                }

                if (GameUtils::RttiUtils::Properties::g_ScriptedPuppet_IsGanger)
                {
                    auto isGangerPtr = reinterpret_cast<bool*>(entityPtr2 + GameUtils::RttiUtils::Properties::g_ScriptedPuppet_IsGanger->valueOffset);
                    if (Utils::IsValidPtr(isGangerPtr))
                        isGanger = *isGangerPtr;
                }

                if (GameUtils::RttiUtils::Properties::g_ScriptedPuppet_IsCyberpsycho)
                {
                    auto isCyberpsychoPtr = reinterpret_cast<bool*>(entityPtr2 + GameUtils::RttiUtils::Properties::g_ScriptedPuppet_IsCyberpsycho->valueOffset);
                    if (Utils::IsValidPtr(isCyberpsychoPtr))
                        isCyberpsycho = *isCyberpsychoPtr;
                }
            }

            auto& cached = writeBuffer.Entities[writeBuffer.EntityCount];
            cached.EntityPtr = entity;
            cached.Position = entityData.Position;
            cached.Distance = entityData.Distance;
            cached.Height = height;
            cached.Width = height * 0.4f;
            cached.IsValid = true;
            cached.IsDead = false;
            cached.IsCivilian = isCivilian;
            cached.IsPolice = isPolice;
            cached.IsGanger = isGanger;
            cached.IsCyberpsycho = isCyberpsycho;
            cached.DeathFlag = entityData.DeathFlag;
            cached.DeathCheckFrame = entityData.DeathCheckFrame;
            cached.TargetingPartIndex = 0;
            cached.TargetingCheckFrame = 0;

            const char* typeName = nativeType->name.ToString();
            strncpy_s(cached.TypeName, typeName, sizeof(cached.TypeName) - 1);
            cached.TypeName[sizeof(cached.TypeName) - 1] = '\0';

            GameUtils::GetInheritancePath(nativeType, cached.InheritancePath, sizeof(cached.InheritancePath));

            writeBuffer.EntityCount++;
            g_VisibleEntityCount++;
        }

        g_CachedEntityCount = writeBuffer.EntityCount;

        g_CurrentReadBufferIndex.store(writeIndex, std::memory_order_release);
    }

    void DrawESP(ImDrawList* drawList, float screenWidth, float screenHeight)
    {
        if (!ESPSettings::g_Enabled)
            return;

        GameUtils::UpdatePlayerPosition();
        GameUtils::EntityUtils::UpdateCacheFrame();

        g_FrameCount++;
        if (g_FrameCount % g_CacheUpdateInterval == 0)
        {
            UpdateEntityCache();
        }

        int readIndex = g_CurrentReadBufferIndex.load(std::memory_order_acquire);
        if (readIndex < 0 || readIndex >= 2)
            return;

        auto& buffer = g_EntityCacheBuffers[readIndex];

        g_VisibleEntityCount = 0;

        for (int i = 0; i < buffer.EntityCount; i++)
        {
            auto& cached = buffer.Entities[i];
            if (!cached.IsValid)
                continue;

            bool shouldShow = false;

            if (cached.IsCivilian || cached.IsPolice || cached.IsGanger || cached.IsCyberpsycho)
            {
                if (cached.IsCivilian && ESPSettings::g_ShowCivilian) shouldShow = true;
                if (cached.IsPolice && ESPSettings::g_ShowPolice) shouldShow = true;
                if (cached.IsGanger && ESPSettings::g_ShowGanger) shouldShow = true;
                if (cached.IsCyberpsycho && ESPSettings::g_ShowCyberpsycho) shouldShow = true;
            }
            else
            {
                if (ESPSettings::g_ShowOther) shouldShow = true;
            }

            if (!shouldShow)
                continue;

            if (cached.Distance > ESPSettings::g_MaxDistance)
                continue;

            if (!GameUtils::CameraUtils::IsInFieldOfView(cached.Position, screenWidth, screenHeight))
                continue;

            ImU32 color = cached.Distance < 20.0f ? IM_COL32(255, 0, 0, 255) :
                          cached.Distance < 50.0f ? IM_COL32(255, 165, 0, 255) :
                          IM_COL32(255, 255, 0, 255);

            if (cached.Distance < 30.0f)
            {
                if (ESPSettings::g_ShowBox)
                    DrawESPBox(drawList, cached.Position, cached.Height, cached.Distance, screenWidth, screenHeight, color);
            }
            else
            {
                if (ESPSettings::g_ShowDot)
                    DrawESPDot(drawList, cached.Position, cached.Distance, screenWidth, screenHeight, color);
            }

            g_VisibleEntityCount++;
        }
    }

    void DebugEntityList()
    {
        struct NPCInfo
        {
            void* EntityPtr = nullptr;
            Utils::Vector3 Position{};
            float Distance = 0.0f;
            bool IsDead = false;
            bool IsAlive = false;
            bool WillDieSoon = false;
            bool IsValid = false;
            int DeathFlag = 0;
            uint32_t DeathCheckFrame = 0;
            int TargetingPartIndex = 0;
            uint32_t TargetingCheckFrame = 0;
        };

        auto rtti = RED4ext::CRTTISystem::Get();
        if (!rtti) return;

        auto engine = RED4ext::CGameEngine::Get();
        if (!engine || !engine->framework || !engine->framework->gameInstance) return;

        if (!GameUtils::RttiUtils::g_GetEntityListFunc) return;

        RED4ext::ScriptGameInstance scriptGameInstance(engine->framework->gameInstance);
        RED4ext::DynArray<RED4ext::Handle<RED4ext::IScriptable>> entities;

        RED4ext::CStackType args[1];
        args[0].type = rtti->GetType("ScriptGameInstance");
        args[0].value = &scriptGameInstance;

        RED4ext::CStackType resultType;
        resultType.type = rtti->GetType("array:handle:entEntity");
        resultType.value = &entities;

        RED4ext::CStack stack(nullptr, args, 1, &resultType);
        GameUtils::RttiUtils::g_GetEntityListFunc->Execute(&stack);

        if (entities.size == 0)
            return;

        auto gamePuppetBaseClass = rtti->GetClass("gamePuppetBase");
        auto gamePuppetClass = rtti->GetClass("gamePuppet");
        auto scriptedPuppetClass = rtti->GetClass("ScriptedPuppet");
        auto playerPuppetClass = rtti->GetClass("PlayerPuppet");

        void* playerPtr = GameUtils::g_PlayerHandle ? GameUtils::g_PlayerHandle.GetPtr() : nullptr;

        NPCInfo nearestNPCs[128];
        int npcCount = 0;

        uint32_t entityCount = entities.size;
        for (uint32_t i = 0; i < entityCount && npcCount < 128; i++)
        {
            auto& entityHandle = entities[i];
            auto entity = entityHandle.GetPtr();
            if (!entityHandle || !entity) continue;
            if (entity == playerPtr) continue;

            auto nativeType = entity->GetNativeType();
            if (!nativeType) continue;

            bool isPuppetBase = gamePuppetBaseClass && nativeType->IsA(gamePuppetBaseClass);
            if (!isPuppetBase) continue;

            if (playerPuppetClass && nativeType->IsA(playerPuppetClass)) continue;

            Utils::Vector3 entityPos = GameUtils::GetEntityPosition(entity);
            if (!entityPos.IsValid())
                continue;

            float dx = entityPos.X - GameUtils::g_PlayerPosition.X;
            float dy = entityPos.Y - GameUtils::g_PlayerPosition.Y;
            float dz = entityPos.Z - GameUtils::g_PlayerPosition.Z;
            float distance = sqrtf(dx * dx + dy * dy + dz * dz);

            bool isDead = false;
            bool isAlive = false;
            bool willDieSoon = false;

            uintptr_t entityPtr = reinterpret_cast<uintptr_t>(entity);

            if (GameUtils::RttiUtils::g_IsDeadFunc)
            {
                RED4ext::CStackType resultType;
                resultType.type = rtti->GetType("Bool");
                resultType.value = &isDead;

                RED4ext::CStack stack(entity, nullptr, 0, &resultType);
                GameUtils::RttiUtils::g_IsDeadFunc->Execute(&stack);
            }

            auto willDieSoonProp = nativeType->GetProperty(RED4ext::CName("willDieSoon"));
            if (willDieSoonProp)
            {
                uintptr_t basePtr = entityPtr;
                if (willDieSoonProp->flags.inValueHolder)
                {
                    void** valueHolderPtr = reinterpret_cast<void**>(entityPtr + 0x38);
                    if (Utils::IsValidPtr(valueHolderPtr) && Utils::IsValidPtr(*valueHolderPtr))
                    {
                        basePtr = reinterpret_cast<uintptr_t>(*valueHolderPtr);
                    }
                    else
                    {
                        basePtr = 0;
                    }
                }
                if (basePtr)
                {
                    uint32_t offset = willDieSoonProp->valueOffset;
                    bool* willDieSoonPtr = reinterpret_cast<bool*>(basePtr + offset);
                    if (Utils::IsValidPtr(willDieSoonPtr))
                    {
                        willDieSoon = *willDieSoonPtr;
                    }
                }
            }

            auto hitReactionProp = nativeType->GetProperty(RED4ext::CName("hitReactionComponent"));
            if (hitReactionProp)
            {
                uintptr_t basePtr = entityPtr;
                if (hitReactionProp->flags.inValueHolder)
                {
                    void** valueHolderPtr = reinterpret_cast<void**>(entityPtr + 0x38);
                    if (Utils::IsValidPtr(valueHolderPtr) && Utils::IsValidPtr(*valueHolderPtr))
                    {
                        basePtr = reinterpret_cast<uintptr_t>(*valueHolderPtr);
                    }
                    else
                    {
                        basePtr = 0;
                    }
                }
                if (basePtr)
                {
                    uint32_t hitReactionOffset = hitReactionProp->valueOffset;
                    void** hitReactionPtr = reinterpret_cast<void**>(basePtr + hitReactionOffset);
                    if (Utils::IsValidPtr(hitReactionPtr) && Utils::IsValidPtr(*hitReactionPtr))
                    {
                        uintptr_t hitReactionComponentPtr = reinterpret_cast<uintptr_t>(*hitReactionPtr);
                        auto hitReactionClass = rtti->GetClass("HitReactionComponent");
                        if (hitReactionClass)
                        {
                            auto isAliveProp = hitReactionClass->GetProperty(RED4ext::CName("isAlive"));
                            if (isAliveProp)
                            {
                                uintptr_t hitBasePtr = hitReactionComponentPtr;
                                if (isAliveProp->flags.inValueHolder)
                                {
                                    void** vhPtr = reinterpret_cast<void**>(hitReactionComponentPtr + 0x38);
                                    if (Utils::IsValidPtr(vhPtr) && Utils::IsValidPtr(*vhPtr))
                                    {
                                        hitBasePtr = reinterpret_cast<uintptr_t>(*vhPtr);
                                    }
                                    else
                                    {
                                        hitBasePtr = 0;
                                    }
                                }
                                if (hitBasePtr)
                                {
                                    uint32_t isAliveOffset = isAliveProp->valueOffset;
                                    bool* isAlivePtr = reinterpret_cast<bool*>(hitBasePtr + isAliveOffset);
                                    if (Utils::IsValidPtr(isAlivePtr))
                                    {
                                        isAlive = *isAlivePtr;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            nearestNPCs[npcCount].EntityPtr = entity;
            nearestNPCs[npcCount].Position = entityPos;
            nearestNPCs[npcCount].Distance = distance;
            nearestNPCs[npcCount].IsDead = isDead;
            nearestNPCs[npcCount].IsAlive = isAlive;
            nearestNPCs[npcCount].WillDieSoon = willDieSoon;
            nearestNPCs[npcCount].IsValid = true;
            npcCount++;
        }

        for (int i = 0; i < npcCount - 1; i++)
        {
            for (int j = i + 1; j < npcCount; j++)
            {
                if (nearestNPCs[j].Distance < nearestNPCs[i].Distance)
                {
                    NPCInfo temp = nearestNPCs[i];
                    nearestNPCs[i] = nearestNPCs[j];
                    nearestNPCs[j] = temp;
                }
            }
        }

        int printCount = (npcCount < 20) ? npcCount : 20;

        DBG_INFO("========================================");
        DBG_INFO("F5 Debug: Nearest %d gamePuppetBase Entities", printCount);
        DBG_INFO("(Offset from each entity's nativeType, not static)");
        DBG_INFO("========================================");

        for (int i = 0; i < printCount; i++)
        {
            uintptr_t ePtr = reinterpret_cast<uintptr_t>(nearestNPCs[i].EntityPtr);
            uint8_t willDieSoonRaw = 0;
            bool hasValueHolder = false;
            
            auto entity = nearestNPCs[i].EntityPtr;
            if (Utils::IsValidPtr(entity))
            {
                auto nativeType = reinterpret_cast<RED4ext::IScriptable*>(entity)->GetNativeType();
                if (nativeType)
                {
                    void** vhPtr = reinterpret_cast<void**>(ePtr + 0x38);
                    uintptr_t basePtr = ePtr;
                    if (Utils::IsValidPtr(vhPtr) && Utils::IsValidPtr(*vhPtr))
                    {
                        hasValueHolder = true;
                        basePtr = reinterpret_cast<uintptr_t>(*vhPtr);
                    }
                    
                    auto willDieSoonProp = nativeType->GetProperty(RED4ext::CName("willDieSoon"));
                    if (willDieSoonProp)
                    {
                        uintptr_t ptr = willDieSoonProp->flags.inValueHolder ? basePtr : ePtr;
                        if (ptr)
                        {
                            uint32_t offset = willDieSoonProp->valueOffset;
                            uint8_t* rawPtr = reinterpret_cast<uint8_t*>(ptr + offset);
                            if (Utils::IsValidPtr(rawPtr))
                                willDieSoonRaw = *rawPtr;
                        }
                    }
                }
            }

            DBG_INFO("[%2d] Dist: %6.1fm | IsDead: %s | IsAlive: %s | WillDieSoon: %s(0x%02X) | VH: %s",
                    i + 1,
                    nearestNPCs[i].Distance,
                    nearestNPCs[i].IsDead ? "Y" : "N",
                    nearestNPCs[i].IsAlive ? "Y" : "N",
                    nearestNPCs[i].WillDieSoon ? "Y" : "N",
                    willDieSoonRaw,
                    hasValueHolder ? "Y" : "N");
        }

        DBG_INFO("========================================");
    }

    void GetAndPrintNearestNPCs(int maxCount)
    {
        struct NPCInfo
        {
            Utils::Vector3 Position{};
            float Distance = 0.0f;
            void* EntityPtr = nullptr;
            bool IsValid = false;
            int DeathFlag = 0;
            uint32_t DeathCheckFrame = 0;
            int TargetingPartIndex = 0;
            uint32_t TargetingCheckFrame = 0;
        };

        auto rtti = RED4ext::CRTTISystem::Get();
        if (!rtti) return;

        auto engine = RED4ext::CGameEngine::Get();
        if (!engine || !engine->framework || !engine->framework->gameInstance) return;

        if (!GameUtils::RttiUtils::g_GetEntityListFunc) return;

        RED4ext::ScriptGameInstance scriptGameInstance(engine->framework->gameInstance);
        RED4ext::DynArray<RED4ext::Handle<RED4ext::IScriptable>> entities;

        RED4ext::CStackType args[1];
        args[0].type = rtti->GetType("ScriptGameInstance");
        args[0].value = &scriptGameInstance;

        RED4ext::CStackType resultType;
        resultType.type = rtti->GetType("array:handle:entEntity");
        resultType.value = &entities;

        RED4ext::CStack stack(nullptr, args, 1, &resultType);
        GameUtils::RttiUtils::g_GetEntityListFunc->Execute(&stack);

        if (entities.size == 0)
            return;

        auto npcPuppetClass = rtti->GetClass("NPCPuppet");
        auto playerPuppetClass = rtti->GetClass("PlayerPuppet");
        auto gamePuppetClass = rtti->GetClass("gamePuppet");
        auto scriptedPuppetClass = rtti->GetClass("ScriptedPuppet");

        void* playerPtr = GameUtils::g_PlayerHandle ? GameUtils::g_PlayerHandle.GetPtr() : nullptr;

        NPCInfo nearestNPCs[128];
        int npcCount = 0;

        uint32_t entityCount = entities.size;
        for (uint32_t i = 0; i < entityCount && npcCount < 128; i++)
        {
            auto& entityHandle = entities[i];
            auto entity = entityHandle.GetPtr();
            if (!entityHandle || !entity) continue;
            if (entity == playerPtr) continue;

            auto nativeType = entity->GetNativeType();
            if (!nativeType) continue;

            bool isPuppet = (gamePuppetClass && nativeType->IsA(gamePuppetClass)) ||
                           (scriptedPuppetClass && nativeType->IsA(scriptedPuppetClass));

            if (!isPuppet) continue;

            if (playerPuppetClass && nativeType->IsA(playerPuppetClass)) continue;

            Utils::Vector3 npcPos = GameUtils::GetEntityPosition(entity);
            if (!npcPos.IsValid())
                continue;

            float dx = npcPos.X - GameUtils::g_PlayerPosition.X;
            float dy = npcPos.Y - GameUtils::g_PlayerPosition.Y;
            float dz = npcPos.Z - GameUtils::g_PlayerPosition.Z;
            float distance = sqrtf(dx * dx + dy * dy + dz * dz);

            nearestNPCs[npcCount].Position = npcPos;
            nearestNPCs[npcCount].Distance = distance;
            nearestNPCs[npcCount].EntityPtr = entity;
            nearestNPCs[npcCount].IsValid = true;
            npcCount++;
        }

        for (int i = 0; i < npcCount - 1; i++)
        {
            for (int j = i + 1; j < npcCount; j++)
            {
                if (nearestNPCs[j].Distance < nearestNPCs[i].Distance)
                {
                    NPCInfo temp = nearestNPCs[i];
                    nearestNPCs[i] = nearestNPCs[j];
                    nearestNPCs[j] = temp;
                }
            }
        }

        int printCount = (npcCount < maxCount) ? npcCount : maxCount;

        for (int i = 0; i < printCount; i++)
        {
            DBG_INFO("[%d] Dist: %.1f | Pos: %.2f, %.2f, %.2f | Ptr: 0x%p",
                    i + 1,
                    nearestNPCs[i].Distance,
                    nearestNPCs[i].Position.X,
                    nearestNPCs[i].Position.Y,
                    nearestNPCs[i].Position.Z,
                    nearestNPCs[i].EntityPtr);
        }
    }

    void DrawTargetingParts(ImDrawList* drawList, void* entity, float screenWidth, float screenHeight)
    {
        static void* lastDrawnEntity = nullptr;
        static int lastDrawnFrame = 0;
        
        if (!Utils::IsValidPtr(entity))
            return;

        bool isNewEntity = (lastDrawnEntity != entity);
        
        if (lastDrawnEntity == entity && lastDrawnFrame == g_FrameCount)
            return;

        lastDrawnEntity = entity;
        lastDrawnFrame = g_FrameCount;

        g_TargetingDebugInfo.EntityPtr = entity;
        g_TargetingDebugInfo.BoneIndex = Aimbot::g_TargetingSystemPart;
        g_TargetingDebugInfo.IsValid = false;
        g_TargetingDebugInfo.PartsInfo[0] = '\0';

        auto rtti = RED4ext::CRTTISystem::Get();
        if (!rtti)
        {
            snprintf(g_TargetingDebugInfo.PartsInfo, sizeof(g_TargetingDebugInfo.PartsInfo), "Error: RTTI not available");
            return;
        }

        if (!GameUtils::RttiUtils::g_GetTargetingSystemFunc || !GameUtils::RttiUtils::g_GetTargetPartsFunc || 
            !GameUtils::RttiUtils::g_TargetPartGetComponentFunc || !GameUtils::RttiUtils::g_GetLocalToWorldFunc ||
            !GameUtils::RttiUtils::g_TSQ_ALLFunc)
        {
            snprintf(g_TargetingDebugInfo.PartsInfo, sizeof(g_TargetingDebugInfo.PartsInfo), "Error: RTTI functions not initialized");
            return;
        }

        auto engine = RED4ext::CGameEngine::Get();
        if (!Utils::IsValidPtr(engine) || !Utils::IsValidPtr(engine->framework) || 
            !Utils::IsValidPtr(engine->framework->gameInstance))
        {
            snprintf(g_TargetingDebugInfo.PartsInfo, sizeof(g_TargetingDebugInfo.PartsInfo), "Error: Game engine not available");
            return;
        }

        auto gameInstance = engine->framework->gameInstance;

        RED4ext::ScriptGameInstance scriptGameInstance(gameInstance);

        RED4ext::Handle<RED4ext::IScriptable> targetingSystemHandle;
        RED4ext::CStackType tsResult;
        tsResult.type = rtti->GetType("handle:gametargetingTargetingSystem");
        tsResult.value = &targetingSystemHandle;

        RED4ext::CStackType args[1];
        args[0].type = rtti->GetType("ScriptGameInstance");
        args[0].value = &scriptGameInstance;

        RED4ext::CStack tsStack(nullptr, args, 1, &tsResult);
        GameUtils::RttiUtils::g_GetTargetingSystemFunc->Execute(&tsStack);

        if (!targetingSystemHandle.instance)
        {
            snprintf(g_TargetingDebugInfo.PartsInfo, sizeof(g_TargetingDebugInfo.PartsInfo), "Error: TargetingSystem not available");
            return;
        }

        auto targetingSystem = targetingSystemHandle.instance;

        RED4ext::CName queryTypeName = RED4ext::CName("gameTargetSearchQuery");
        auto queryType = rtti->GetType(queryTypeName);
        if (!queryType)
        {
            snprintf(g_TargetingDebugInfo.PartsInfo, sizeof(g_TargetingDebugInfo.PartsInfo), "Error: QueryType not available");
            return;
        }

        auto scriptAllocator = RED4ext::Memory::ScriptAllocator::Get();
        if (!scriptAllocator)
        {
            snprintf(g_TargetingDebugInfo.PartsInfo, sizeof(g_TargetingDebugInfo.PartsInfo), "Error: ScriptAllocator not available");
            return;
        }

        auto allocResult = scriptAllocator->Alloc(0x100);
        if (!allocResult.memory)
        {
            snprintf(g_TargetingDebugInfo.PartsInfo, sizeof(g_TargetingDebugInfo.PartsInfo), "Error: Memory allocation failed");
            return;
        }

        uint8_t* queryMemory = static_cast<uint8_t*>(allocResult.memory);
        memset(queryMemory, 0, 0x100);
        queryType->Construct(queryMemory);

        RED4ext::CStackType queryResult;
        queryResult.type = queryType;
        queryResult.value = queryMemory;

        RED4ext::CStack queryStack(nullptr, nullptr, 0, &queryResult);
        GameUtils::RttiUtils::g_TSQ_ALLFunc->Execute(&queryStack);

        auto queryClass = rtti->GetClass("gameTargetSearchQuery");
        if (queryClass)
        {
            auto maxDistanceProp = queryClass->GetProperty(RED4ext::CName("maxDistance"));
            if (maxDistanceProp)
            {
                float maxDistance = 1000.0f;
                maxDistanceProp->SetValue(queryMemory, &maxDistance);
            }

            auto filterByDistanceProp = queryClass->GetProperty(RED4ext::CName("filterObjectByDistance"));
            if (filterByDistanceProp)
            {
                bool filterByDistance = false;
                filterByDistanceProp->SetValue(queryMemory, &filterByDistance);
            }

            auto includeSecondaryProp = queryClass->GetProperty(RED4ext::CName("includeSecondaryTargets"));
            if (includeSecondaryProp)
            {
                bool includeSecondary = true;
                includeSecondaryProp->SetValue(queryMemory, &includeSecondary);
            }

            auto ignoreInstigatorProp = queryClass->GetProperty(RED4ext::CName("ignoreInstigator"));
            if (ignoreInstigatorProp)
            {
                bool ignoreInstigator = false;
                ignoreInstigatorProp->SetValue(queryMemory, &ignoreInstigator);
            }
        }

        if (GameUtils::RttiUtils::g_GetEntityIDFunc)
        {
            RED4ext::ent::EntityID targetEntityID;
            RED4ext::CStackType eidResult;
            eidResult.type = rtti->GetType("entEntityID");
            eidResult.value = &targetEntityID;

            RED4ext::CStack eidStack(entity, nullptr, 0, &eidResult);
            GameUtils::RttiUtils::g_GetEntityIDFunc->Execute(&eidStack);

            auto queryClass = rtti->GetClass("gameTargetSearchQuery");
            if (queryClass)
            {
                auto queryTargetProp = queryClass->GetProperty(RED4ext::CName("queryTarget"));
                if (queryTargetProp)
                {
                    queryTargetProp->SetValue(queryMemory, &targetEntityID);
                }
            }
        }

        auto playerHandle = GameUtils::g_PlayerHandle;
        if (!playerHandle.GetPtr())
        {
            scriptAllocator->Free(allocResult);
            return;
        }

        RED4ext::WeakHandle<RED4ext::IScriptable> playerWhandle;
        playerWhandle = playerHandle;

        RED4ext::DynArray<RED4ext::game::targeting::TargetPartInfo> partsArray;
        auto arrayType = rtti->GetType("array:gametargetingTargetPartInfo");
        if (!arrayType)
        {
            scriptAllocator->Free(allocResult);
            return;
        }
        arrayType->Construct(&partsArray);

        RED4ext::CStackType getPartsArgs[3];
        getPartsArgs[0].type = rtti->GetType("whandle:gameObject");
        getPartsArgs[0].value = &playerWhandle;
        getPartsArgs[1].type = queryType;
        getPartsArgs[1].value = queryMemory;
        getPartsArgs[2].type = arrayType;
        getPartsArgs[2].value = &partsArray;

        bool getPartsResult = false;
        RED4ext::CStackType getPartsRetVal;
        getPartsRetVal.type = rtti->GetType("Bool");
        getPartsRetVal.value = &getPartsResult;

        RED4ext::CStack getPartsStack(targetingSystem, getPartsArgs, 3, &getPartsRetVal);
        GameUtils::RttiUtils::g_GetTargetPartsFunc->Execute(&getPartsStack);

        scriptAllocator->Free(allocResult);

        if (!getPartsResult || partsArray.size == 0)
        {
            snprintf(g_TargetingDebugInfo.PartsInfo, sizeof(g_TargetingDebugInfo.PartsInfo), "No parts found (result=%d, size=%d)", getPartsResult, partsArray.size);
            return;
        }

        g_TargetingDebugInfo.PartsCount = partsArray.size;
        g_TargetingDebugInfo.IsValid = true;

        char* infoPtr = g_TargetingDebugInfo.PartsInfo;
        int remaining = sizeof(g_TargetingDebugInfo.PartsInfo) - 1;

        for (uint32_t i = 0; i < partsArray.size; i++)
        {
            auto& partInfo = partsArray[i];
            
            RED4ext::WeakHandle<RED4ext::IComponent> componentWhandle;
            RED4ext::CStackType compResult;
            compResult.type = rtti->GetType("whandle:gameTargetingComponent");
            compResult.value = &componentWhandle;

            RED4ext::CStackType compArgs[1];
            compArgs[0].type = rtti->GetType("gametargetingTargetPartInfo");
            compArgs[0].value = &partInfo;

            RED4ext::CStack compStack(nullptr, compArgs, 1, &compResult);
            GameUtils::RttiUtils::g_TargetPartGetComponentFunc->Execute(&compStack);

            if (!componentWhandle.instance)
                continue;

            auto component = componentWhandle.instance;
            
            RED4ext::Matrix worldMatrix;
            RED4ext::CStackType matrixResult;
            matrixResult.type = rtti->GetType("Matrix");
            matrixResult.value = &worldMatrix;

            RED4ext::CStack matrixStack(component, nullptr, 0, &matrixResult);
            GameUtils::RttiUtils::g_GetLocalToWorldFunc->Execute(&matrixStack);

            Utils::Vector3 pos(worldMatrix.W.X, worldMatrix.W.Y, worldMatrix.W.Z);

            if (!pos.IsValid() || (pos.X == 0.0f && pos.Y == 0.0f && pos.Z == 0.0f))
                continue;

            int written = snprintf(infoPtr, remaining, "[%d]Z=%.1f ", i, pos.Z);
            if (written > 0 && written < remaining)
            {
                infoPtr += written;
                remaining -= written;
            }

            ImVec2 screenPos;
            if (GameUtils::WorldToScreen(pos, screenPos, screenWidth, screenHeight))
            {
                ImU32 color;
                if (TargetingParts::IsHeadPart(i))
                {
                    color = IM_COL32(0, 255, 0, 255);
                }
                else if (TargetingParts::IsChestPart(i))
                {
                    color = IM_COL32(255, 0, 0, 255);
                }
                else if (TargetingParts::IsLimbsPart(i))
                {
                    color = IM_COL32(0, 0, 255, 255);
                }
                else
                {
                    color = IM_COL32(128, 128, 128, 255);
                }

                float radius = 5.0f;
                drawList->AddCircleFilled(screenPos, radius, color);
                drawList->AddCircle(screenPos, radius, IM_COL32(255, 255, 255, 255), 0, 1.5f);

                char label[64];
                snprintf(label, sizeof(label), "%d:%s", i, TargetingParts::GetPartName(i));
                drawList->AddText(ImVec2(screenPos.x + 8, screenPos.y - 8), IM_COL32(255, 255, 255, 255), label);
            }
        }
    }

    void DrawTargetingDebugInfo(ImDrawList* drawList)
    {
        if (!Aimbot::g_UseTargetingSystem)
            return;

        if (!g_TargetingDebugInfo.IsValid)
            return;

        float posX = 10.0f;
        float posY = 50.0f;

        ImU32 bgColor = IM_COL32(0, 0, 0, 180);
        ImU32 textColor = IM_COL32(255, 255, 255, 255);
        ImU32 highlightColor = IM_COL32(0, 255, 0, 255);
        ImU32 selectedColor = IM_COL32(255, 255, 0, 255);

        char buf[256];
        const char* categoryName = TargetingParts::GetCategoryName(g_TargetingDebugInfo.BoneIndex);
        const char* selectedPartName = TargetingParts::GetPartName(g_TargetingDebugInfo.SelectedPartIndex);

        snprintf(buf, sizeof(buf), "Target: 0x%p | Category: %s (%d) | Count: %d | Selected: [%d] %s", 
                g_TargetingDebugInfo.EntityPtr, categoryName, g_TargetingDebugInfo.BoneIndex, 
                g_TargetingDebugInfo.PartsCount, g_TargetingDebugInfo.SelectedPartIndex, selectedPartName);

        ImVec2 textSize = ImGui::CalcTextSize(buf);
        drawList->AddRectFilled(ImVec2(posX - 5, posY - 2), ImVec2(posX + textSize.x + 5, posY + textSize.y + 2), bgColor);
        drawList->AddText(ImVec2(posX, posY), highlightColor, buf);
        posY += textSize.y + 5;

        if (g_TargetingDebugInfo.PartsInfo[0] != '\0')
        {
            textSize = ImGui::CalcTextSize(g_TargetingDebugInfo.PartsInfo);
            drawList->AddRectFilled(ImVec2(posX - 5, posY - 2), ImVec2(posX + textSize.x + 5, posY + textSize.y + 2), bgColor);
            drawList->AddText(ImVec2(posX, posY), textColor, g_TargetingDebugInfo.PartsInfo);
        }
    }
}
