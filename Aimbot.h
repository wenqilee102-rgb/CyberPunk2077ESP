#pragma once

namespace Aimbot
{
    extern bool g_Enabled;
    extern int g_TargetBone;
    extern float g_FOV;
    extern float g_Smoothness;
    extern float g_MaxDistance;
    extern int g_CycleBoneKey;
    extern void* g_CurrentTarget;
    extern int g_CurrentTargetIndex;
    extern bool g_CycleKeyPressed;
    extern bool g_UseTargetingSystem;

    void Initialize();
    void CycleBone();
    void HandleHotkeys();
    void Update(float screenWidth, float screenHeight);
    void DrawFOVCircle(ImDrawList* drawList, float screenWidth, float screenHeight);
    void DrawTargetIndicator(ImDrawList* drawList, float screenWidth, float screenHeight);
    int FindClosestTarget(float screenWidth, float screenHeight);
    void AimAt(const Utils::Vector3& targetPos, float screenWidth, float screenHeight);
    Utils::Vector3 GetBonePosition(const Utils::Vector3& basePos, int boneIndex);
    Utils::Vector3 GetBoneWorldPosition(void* entity, RED4ext::CName boneName);
    Utils::Vector3 GetHeadPosition(void* entity);
    float GetDistanceToCrosshair(const Utils::Vector3& worldPos, float screenWidth, float screenHeight);
}
