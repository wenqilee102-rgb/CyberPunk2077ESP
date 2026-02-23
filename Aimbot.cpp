#include "pch.h"
#include "Aimbot.h"
#include "ESP.h"
#include "GameUtils/GameUtils.h"

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
            auto pos = GameUtils::GetHeadPositionFromTargeting(entity);
            if (pos.X == 0.0f && pos.Y == 0.0f && pos.Z == 0.0f)
            {
                static bool loggedOnce = false;
                if (!loggedOnce)
                {
                    DBG_INFO("[Aimbot] TargetingSystem returned zero position");
                    loggedOnce = true;
                }
            }
            return pos;
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
    }
}
