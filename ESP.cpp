#include "pch.h"
#include "ESP.h"
#include "GameUtils/GameUtils.h"

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

    CachedEntity g_CachedEntities[128];
    int g_CachedEntityCount = 0;
    int g_VisibleEntityCount = 0;
    int g_FrameCount = 0;
    const int g_CacheUpdateInterval = 5;

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
        g_CachedEntityCount = 0;
        g_VisibleEntityCount = 0;

        auto rtti = RED4ext::CRTTISystem::Get();
        if (!rtti) return;

        auto engine = RED4ext::CGameEngine::Get();
        if (!engine || !engine->framework || !engine->framework->gameInstance) return;

        auto scriptGameInstanceClass = rtti->GetClass("ScriptGameInstance");
        if (!scriptGameInstanceClass) return;

        auto getEntityListFunc = scriptGameInstanceClass->GetFunction(RED4ext::CName("GetEntityList"));
        if (!getEntityListFunc) return;

        RED4ext::ScriptGameInstance scriptGameInstance(engine->framework->gameInstance);
        RED4ext::DynArray<RED4ext::Handle<RED4ext::IScriptable>> entities;

        RED4ext::CStackType args[1];
        args[0].type = rtti->GetType("ScriptGameInstance");
        args[0].value = &scriptGameInstance;

        RED4ext::CStackType resultType;
        resultType.type = rtti->GetType("array:handle:entEntity");
        resultType.value = &entities;

        RED4ext::CStack stack(nullptr, args, 1, &resultType);
        getEntityListFunc->Execute(&stack);

        if (entities.size == 0)
            return;

        auto gamePuppetClass = rtti->GetClass("gamePuppet");
        auto scriptedPuppetClass = rtti->GetClass("ScriptedPuppet");
        auto playerPuppetClass = rtti->GetClass("PlayerPuppet");

        void* playerPtr = GameUtils::g_PlayerHandle ? GameUtils::g_PlayerHandle.GetPtr() : nullptr;

        uint32_t entityCount = entities.size;
        for (uint32_t i = 0; i < entityCount && g_CachedEntityCount < 128; i++)
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

            bool isDead = GameUtils::IsEntityDead(entity);
            if (isDead && !ESPSettings::g_ShowDead)
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
                auto entityPtr = reinterpret_cast<uintptr_t>(entity);

                if (GameUtils::RttiUtils::Properties::g_ScriptedPuppet_IsCivilian)
                {
                    auto isCivilianPtr = reinterpret_cast<bool*>(entityPtr + GameUtils::RttiUtils::Properties::g_ScriptedPuppet_IsCivilian->valueOffset);
                    if (Utils::IsValidPtr(isCivilianPtr))
                        isCivilian = *isCivilianPtr;
                }

                if (GameUtils::RttiUtils::Properties::g_ScriptedPuppet_IsPolice)
                {
                    auto isPolicePtr = reinterpret_cast<bool*>(entityPtr + GameUtils::RttiUtils::Properties::g_ScriptedPuppet_IsPolice->valueOffset);
                    if (Utils::IsValidPtr(isPolicePtr))
                        isPolice = *isPolicePtr;
                }

                if (GameUtils::RttiUtils::Properties::g_ScriptedPuppet_IsGanger)
                {
                    auto isGangerPtr = reinterpret_cast<bool*>(entityPtr + GameUtils::RttiUtils::Properties::g_ScriptedPuppet_IsGanger->valueOffset);
                    if (Utils::IsValidPtr(isGangerPtr))
                        isGanger = *isGangerPtr;
                }

                if (GameUtils::RttiUtils::Properties::g_ScriptedPuppet_IsCyberpsycho)
                {
                    auto isCyberpsychoPtr = reinterpret_cast<bool*>(entityPtr + GameUtils::RttiUtils::Properties::g_ScriptedPuppet_IsCyberpsycho->valueOffset);
                    if (Utils::IsValidPtr(isCyberpsychoPtr))
                        isCyberpsycho = *isCyberpsychoPtr;
                }
            }

            auto& cached = g_CachedEntities[g_CachedEntityCount];
            cached.EntityPtr = entity;
            cached.Position = entityPos;
            cached.Distance = distance;
            cached.Height = height;
            cached.Width = height * 0.4f;
            cached.IsValid = true;
            cached.IsDead = isDead;
            cached.IsCivilian = isCivilian;
            cached.IsPolice = isPolice;
            cached.IsGanger = isGanger;
            cached.IsCyberpsycho = isCyberpsycho;

            const char* typeName = nativeType->name.ToString();
            strncpy_s(cached.TypeName, typeName, sizeof(cached.TypeName) - 1);
            cached.TypeName[sizeof(cached.TypeName) - 1] = '\0';

            GameUtils::GetInheritancePath(nativeType, cached.InheritancePath, sizeof(cached.InheritancePath));

            g_CachedEntityCount++;
            g_VisibleEntityCount++;
        }
    }

    void DrawESP(ImDrawList* drawList, float screenWidth, float screenHeight)
    {
        if (!ESPSettings::g_Enabled)
            return;

        GameUtils::UpdatePlayerPosition();

        g_FrameCount++;
        if (g_FrameCount % g_CacheUpdateInterval == 0)
        {
            UpdateEntityCache();
        }

        g_VisibleEntityCount = 0;

        for (int i = 0; i < g_CachedEntityCount; i++)
        {
            auto& cached = g_CachedEntities[i];
            if (!cached.IsValid)
                continue;

            if (cached.IsDead && !ESPSettings::g_ShowDead)
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
            void* EntityPtr;
            Utils::Vector3 Position;
            float Distance;
            bool IsDead;
            bool IsAlive;
            bool WillDieSoon;
            bool IsValid;
        };

        auto rtti = RED4ext::CRTTISystem::Get();
        if (!rtti) return;

        auto engine = RED4ext::CGameEngine::Get();
        if (!engine || !engine->framework || !engine->framework->gameInstance) return;

        auto scriptGameInstanceClass = rtti->GetClass("ScriptGameInstance");
        if (!scriptGameInstanceClass) return;

        auto getEntityListFunc = scriptGameInstanceClass->GetFunction(RED4ext::CName("GetEntityList"));
        if (!getEntityListFunc) return;

        RED4ext::ScriptGameInstance scriptGameInstance(engine->framework->gameInstance);
        RED4ext::DynArray<RED4ext::Handle<RED4ext::IScriptable>> entities;

        RED4ext::CStackType args[1];
        args[0].type = rtti->GetType("ScriptGameInstance");
        args[0].value = &scriptGameInstance;

        RED4ext::CStackType resultType;
        resultType.type = rtti->GetType("array:handle:entEntity");
        resultType.value = &entities;

        RED4ext::CStack stack(nullptr, args, 1, &resultType);
        getEntityListFunc->Execute(&stack);

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

            auto isDeadFunc = nativeType->GetFunction(RED4ext::CName("IsDead"));
            if (isDeadFunc)
            {
                RED4ext::CStackType resultType;
                resultType.type = rtti->GetType("Bool");
                resultType.value = &isDead;

                RED4ext::CStack stack(entity, nullptr, 0, &resultType);
                isDeadFunc->Execute(&stack);
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
            Utils::Vector3 Position;
            float Distance;
            void* EntityPtr;
            bool IsValid;
        };

        auto rtti = RED4ext::CRTTISystem::Get();
        if (!rtti) return;

        auto engine = RED4ext::CGameEngine::Get();
        if (!engine || !engine->framework || !engine->framework->gameInstance) return;

        auto scriptGameInstanceClass = rtti->GetClass("ScriptGameInstance");
        if (!scriptGameInstanceClass) return;

        auto getEntityListFunc = scriptGameInstanceClass->GetFunction(RED4ext::CName("GetEntityList"));
        if (!getEntityListFunc) return;

        RED4ext::ScriptGameInstance scriptGameInstance(engine->framework->gameInstance);
        RED4ext::DynArray<RED4ext::Handle<RED4ext::IScriptable>> entities;

        RED4ext::CStackType args[1];
        args[0].type = rtti->GetType("ScriptGameInstance");
        args[0].value = &scriptGameInstance;

        RED4ext::CStackType resultType;
        resultType.type = rtti->GetType("array:handle:entEntity");
        resultType.value = &entities;

        RED4ext::CStack stack(nullptr, args, 1, &resultType);
        getEntityListFunc->Execute(&stack);

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
}
