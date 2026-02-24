#include "pch.h"
#include "Aimbot.h"
#include "ESP.h"
#include "GameUtils/GameUtils.h"
#include "GameUtils/MemoryUtils.h"
#include "TargetingParts.h"

namespace Aimbot
{
    bool g_Enabled = false;
    int g_TargetBone = 0;
    float g_FOV = 90.0f;
    float g_Smoothness = 0.5f;
    float g_MaxDistance = 50.0f;
    int g_CycleBoneKey = 0x51;
    void* g_CurrentTarget = nullptr;
    int g_CurrentTargetIndex = -1;
    bool g_CycleKeyPressed = false;
    bool g_UseTargetingSystem = false;
    int g_TargetingSystemPart = 0;

    void Initialize()
    {
        DBG_INFO("Aimbot initialized");
    }

    void CycleBone()
    {
        g_TargetBone = (g_TargetBone + 1) % 3;
    }

    void HandleHotkeys()
    {
        if (GetAsyncKeyState(g_CycleBoneKey) & 0x8000)
        {
            if (!g_CycleKeyPressed)
            {
                g_CycleKeyPressed = true;
                CycleBone();
            }
        }
        else
        {
            g_CycleKeyPressed = false;
        }
    }

    Utils::Vector3 GetHeadPosition(void* entity)
    {
        if (g_UseTargetingSystem)
        {
            return GetHeadPositionFromTargeting(entity, g_TargetingSystemPart);
        }

        auto basePos = GameUtils::GetEntityPosition(entity);
        float height = GameUtils::GetEntityHeight(entity);
        
        if (height <= 0.0f)
            height = 1.8f;

        float targetZ = basePos.Z;

        switch (g_TargetBone)
        {
        case 0:
            targetZ = basePos.Z + height * 0.85f;
            break;
        case 1:
            targetZ = basePos.Z + height * 0.5f;
            break;
        case 2:
            targetZ = basePos.Z + height * 0.33f;
            break;
        default:
            targetZ = basePos.Z + height * 0.85f;
            break;
        }

        return Utils::Vector3(basePos.X, basePos.Y, targetZ);
    }

    Utils::Vector3 GetHeadPositionFromTargeting(void* entity, int boneIndex)
    {
        if (!Utils::IsValidPtr(entity))
            return Utils::Vector3(0, 0, 0);

        auto rtti = RED4ext::CRTTISystem::Get();
        if (!rtti)
            return Utils::Vector3(0, 0, 0);

        if (!GameUtils::RttiUtils::g_GetTargetingSystemFunc || !GameUtils::RttiUtils::g_GetTargetPartsFunc || 
            !GameUtils::RttiUtils::g_TargetPartGetComponentFunc || !GameUtils::RttiUtils::g_GetLocalToWorldFunc ||
            !GameUtils::RttiUtils::g_TSQ_ALLFunc)
        {
            return Utils::Vector3(0, 0, 0);
        }

        auto engine = RED4ext::CGameEngine::Get();
        if (!Utils::IsValidPtr(engine) || !Utils::IsValidPtr(engine->framework) || 
            !Utils::IsValidPtr(engine->framework->gameInstance))
            return Utils::Vector3(0, 0, 0);

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
            return Utils::Vector3(0, 0, 0);

        auto targetingSystem = targetingSystemHandle.instance;

        RED4ext::CName queryTypeName = RED4ext::CName("gameTargetSearchQuery");
        auto queryType = rtti->GetType(queryTypeName);
        if (!queryType)
            return Utils::Vector3(0, 0, 0);

        auto scriptAllocator = RED4ext::Memory::ScriptAllocator::Get();
        if (!scriptAllocator)
            return Utils::Vector3(0, 0, 0);

        auto allocResult = scriptAllocator->Alloc(0x100);
        if (!allocResult.memory)
            return Utils::Vector3(0, 0, 0);

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
            return Utils::Vector3(0, 0, 0);
        }

        RED4ext::WeakHandle<RED4ext::IScriptable> playerWhandle;
        playerWhandle = playerHandle;

        RED4ext::DynArray<RED4ext::game::targeting::TargetPartInfo> partsArray;
        auto arrayType = rtti->GetType("array:gametargetingTargetPartInfo");
        if (!arrayType)
        {
            scriptAllocator->Free(allocResult);
            return Utils::Vector3(0, 0, 0);
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
            return Utils::Vector3(0, 0, 0);

        Utils::Vector3 bestPos(0, 0, 0);
        bool foundPrimary = false;
        int partCount = 0;

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
            
            bool isPrimary = false;
            auto componentClass = rtti->GetClass("gameTargetingComponent");
            if (componentClass)
            {
                auto isPrimaryProp = componentClass->GetProperty(RED4ext::CName("isPrimary"));
                if (isPrimaryProp)
                {
                    uintptr_t componentPtr = reinterpret_cast<uintptr_t>(component);
                    if (isPrimaryProp->flags.inValueHolder)
                    {
                        void** vhPtr = reinterpret_cast<void**>(componentPtr + 0x38);
                        if (Utils::IsValidPtr(vhPtr) && Utils::IsValidPtr(*vhPtr))
                        {
                            componentPtr = reinterpret_cast<uintptr_t>(*vhPtr);
                        }
                    }
                    if (componentPtr)
                    {
                        bool* isPrimaryPtr = reinterpret_cast<bool*>(componentPtr + isPrimaryProp->valueOffset);
                        if (Utils::IsValidPtr(isPrimaryPtr))
                            isPrimary = *isPrimaryPtr;
                    }
                }
            }
            
            RED4ext::Matrix worldMatrix;
            RED4ext::CStackType matrixResult;
            matrixResult.type = rtti->GetType("Matrix");
            matrixResult.value = &worldMatrix;

            RED4ext::CStack matrixStack(component, nullptr, 0, &matrixResult);
            GameUtils::RttiUtils::g_GetLocalToWorldFunc->Execute(&matrixStack);

            Utils::Vector3 pos(worldMatrix.W.X, worldMatrix.W.Y, worldMatrix.W.Z);

            if (!pos.IsValid())
                continue;

            if (pos.X == 0.0f && pos.Y == 0.0f && pos.Z == 0.0f)
                continue;

            partCount++;

            bool shouldUse = TargetingParts::ShouldSelectPart(i, boneIndex);

            if (shouldUse)
            {
                ESP::g_TargetingDebugInfo.SelectedPartIndex = i;
                return pos;
            }

            if (isPrimary && !foundPrimary)
            {
                foundPrimary = true;
                bestPos = pos;
            }
        }

        if (foundPrimary)
            return bestPos;

        return Utils::Vector3(0, 0, 0);
    }

    float GetDistanceToCrosshair(const Utils::Vector3& worldPos, float screenWidth, float screenHeight)
    {
        return GameUtils::GetDistanceToCrosshair(worldPos, screenWidth, screenHeight);
    }

    int FindClosestTarget(float screenWidth, float screenHeight)
    {
        if (!ESP::ESPSettings::g_Enabled)
            return -1;

        float closestDist = FLT_MAX;
        int closestIdx = -1;

        for (int i = 0; i < ESP::g_CachedEntityCount; i++)
        {
            auto& cached = ESP::g_CachedEntities[i];
            if (!cached.IsValid) continue;
            
            if (cached.Distance > g_MaxDistance)
                continue;

            bool isDead = GameUtils::IsEntityDead(cached.EntityPtr);
            if (isDead)
            {
                cached.IsDead = true;
                continue;
            }

            bool shouldTarget = false;

            if (cached.IsCivilian || cached.IsPolice || cached.IsGanger || cached.IsCyberpsycho)
            {
                if (cached.IsCivilian && ESP::ESPSettings::g_ShowCivilian) shouldTarget = true;
                if (cached.IsPolice && ESP::ESPSettings::g_ShowPolice) shouldTarget = true;
                if (cached.IsGanger && ESP::ESPSettings::g_ShowGanger) shouldTarget = true;
                if (cached.IsCyberpsycho && ESP::ESPSettings::g_ShowCyberpsycho) shouldTarget = true;
            }
            else
            {
                if (ESP::ESPSettings::g_ShowOther) shouldTarget = true;
            }

            if (!shouldTarget) continue;

            Utils::Vector3 bonePos;
            bonePos = GetHeadPosition(cached.EntityPtr);
            float dist = GetDistanceToCrosshair(bonePos, screenWidth, screenHeight);

            if (dist < closestDist && dist < g_FOV)
            {
                closestDist = dist;
                closestIdx = i;
            }
        }

        return closestIdx;
    }

    void AimAt(const Utils::Vector3& targetPos, float screenWidth, float screenHeight)
    {
        ImVec2 screenPos;
        if (!GameUtils::WorldToScreen(targetPos, screenPos, screenWidth, screenHeight))
            return;

        float centerX = screenWidth / 2.0f;
        float centerY = screenHeight / 2.0f;

        float deltaX = screenPos.x - centerX;
        float deltaY = screenPos.y - centerY;

        float distance = sqrtf(deltaX * deltaX + deltaY * deltaY);
        if (distance < 2.0f)
            return;

        int moveX = static_cast<int>(deltaX * g_Smoothness);
        int moveY = static_cast<int>(deltaY * g_Smoothness);

        mouse_event(MOUSEEVENTF_MOVE, moveX, moveY, 0, 0);
    }

    void Update(float screenWidth, float screenHeight)
    {
        HandleHotkeys();

        if (!g_Enabled)
        {
            g_CurrentTarget = nullptr;
            g_CurrentTargetIndex = -1;
            return;
        }

        if (!(GetAsyncKeyState(VK_RBUTTON) & 0x8000))
        {
            g_CurrentTarget = nullptr;
            g_CurrentTargetIndex = -1;
            return;
        }

        int targetIdx = FindClosestTarget(screenWidth, screenHeight);
        if (targetIdx >= 0)
        {
            auto& cached = ESP::g_CachedEntities[targetIdx];
            g_CurrentTarget = cached.EntityPtr;
            g_CurrentTargetIndex = targetIdx;

            Utils::Vector3 bonePos = GetHeadPosition(cached.EntityPtr);
            AimAt(bonePos, screenWidth, screenHeight);
        }
        else
        {
            g_CurrentTarget = nullptr;
            g_CurrentTargetIndex = -1;
        }
    }

    void DrawFOVCircle(ImDrawList* drawList, float screenWidth, float screenHeight)
    {
        if (!g_Enabled)
            return;

        float centerX = screenWidth * 0.5f;
        float centerY = screenHeight * 0.5f;

        drawList->AddCircle(ImVec2(centerX, centerY), g_FOV, IM_COL32(255, 255, 255, 100), 64, 1.0f);
    }

    void DrawTargetIndicator(ImDrawList* drawList, float screenWidth, float screenHeight)
    {
        if (!ESP::ESPSettings::g_Enabled || g_CurrentTargetIndex < 0 || g_CurrentTargetIndex >= ESP::g_CachedEntityCount)
            return;

        auto& cached = ESP::g_CachedEntities[g_CurrentTargetIndex];
        if (!cached.IsValid) return;

        Utils::Vector3 bonePos;
        bonePos = GetHeadPosition(cached.EntityPtr);

        ImVec2 screenPos;
        if (GameUtils::WorldToScreen(bonePos, screenPos, screenWidth, screenHeight))
        {
            drawList->AddCircle(screenPos, 8.0f, IM_COL32(255, 0, 0, 255), 16, 2.0f);
            drawList->AddLine(ImVec2(screenPos.x - 12, screenPos.y),
                              ImVec2(screenPos.x + 12, screenPos.y),
                              IM_COL32(255, 0, 0, 255), 2.0f);
            drawList->AddLine(ImVec2(screenPos.x, screenPos.y - 12),
                              ImVec2(screenPos.x, screenPos.y + 12),
                              IM_COL32(255, 0, 0, 255), 2.0f);
        }

        if (g_UseTargetingSystem && (GetAsyncKeyState(VK_RBUTTON) & 0x8000))
        {
            ESP::DrawTargetingParts(drawList, cached.EntityPtr, screenWidth, screenHeight);
        }
    }
}
