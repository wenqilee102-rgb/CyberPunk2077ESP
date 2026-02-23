#pragma once

#include "../pch.h"

namespace GameUtils
{
    namespace RttiUtils
    {
        extern RED4ext::CClass* g_GameObjectClass;
        extern RED4ext::CClass* g_SkinnedMeshComponentClass;
        extern RED4ext::CClass* g_TargetingSystemClass;
        extern RED4ext::CClass* g_TargetPartInfoClass;
        extern RED4ext::CBaseFunction* g_IsDeadFunc;
        extern RED4ext::CBaseFunction* g_GetTargetingSystemFunc;
        extern RED4ext::CBaseFunction* g_GetTargetPartsFunc;
        extern RED4ext::CBaseFunction* g_TargetPartGetComponentFunc;
        extern RED4ext::CBaseFunction* g_GetLocalToWorldFunc;
        extern RED4ext::CBaseFunction* g_GetSlotTransformFunc;
        extern RED4ext::CBaseFunction* g_GetWorldPositionFunc;
        extern RED4ext::CProperty* g_CMesh_BoundingBox_Property;
        extern void* g_CameraSystem;
        extern bool g_SystemsInitialized;

        namespace Properties
        {
            extern RED4ext::CProperty* g_Entity_TransformComponent;
            extern RED4ext::CProperty* g_IPlacedComponent_WorldTransform;
            extern RED4ext::CProperty* g_WorldTransform_Position;
            extern RED4ext::CProperty* g_GameObject_DisplayName;
            extern RED4ext::CProperty* g_GameObject_IsDead;
            extern RED4ext::CProperty* g_GameObject_WillDieSoon;
            extern RED4ext::CProperty* g_GameObject_PersistentState;
            extern RED4ext::CProperty* g_ScriptedPuppet_IsCyberpsycho;
            extern RED4ext::CProperty* g_ScriptedPuppet_IsCivilian;
            extern RED4ext::CProperty* g_ScriptedPuppet_IsPolice;
            extern RED4ext::CProperty* g_ScriptedPuppet_IsGanger;
            extern RED4ext::CProperty* g_ScriptedPuppet_HitReactionComponent;
            extern RED4ext::CProperty* g_HitReactionComponent_IsAlive;
            extern RED4ext::CProperty* g_PuppetReplicatedState_Health;
            extern RED4ext::CProperty* g_SlotComponent_Slots;
            extern RED4ext::CProperty* g_Entity_ComponentsStorage;
        }

        bool InitializeSystems();
        void ForceInitialize();
    }

    namespace EntityUtils
    {
        void GetInheritancePath(RED4ext::CClass* cls, char* buffer, size_t bufferSize);
        Utils::Vector3 GetEntityPosition(void* entity);
        bool IsEntityDead(void* entity);
        bool IsEntityValid(void* entity);
        void* GetSkinnedMeshComponent(void* entity);
        void* GetSlotComponent(void* entity);
        Utils::Vector3 GetHeadPosition(void* entity);
        Utils::Vector3 GetHeadPositionFromTargeting(void* entity);
        Utils::Vector3 GetHeadPositionFromSlot(void* entity);
        float GetEntityHeight(void* entity);
    }

    namespace PlayerUtils
    {
        extern Utils::Vector3 g_PlayerPosition;
        extern bool g_PlayerPosValid;
        extern RED4ext::Handle<RED4ext::IScriptable> g_PlayerHandle;

        void UpdatePlayerPosition();
    }

    namespace CameraUtils
    {
        bool WorldToScreen(const Utils::Vector3& worldPos, ImVec2& screenPos, float screenWidth, float screenHeight);
        float GetDistanceToCrosshair(const Utils::Vector3& worldPos, float screenWidth, float screenHeight);
        bool IsInFieldOfView(const Utils::Vector3& worldPos, float screenWidth, float screenHeight);
    }

    inline bool InitializeSystems() { return RttiUtils::InitializeSystems(); }
    inline void ForceInitialize() { RttiUtils::ForceInitialize(); }
    inline void GetInheritancePath(RED4ext::CClass* cls, char* buffer, size_t bufferSize) { EntityUtils::GetInheritancePath(cls, buffer, bufferSize); }
    inline Utils::Vector3 GetEntityPosition(void* entity) { return EntityUtils::GetEntityPosition(entity); }
    inline bool IsEntityDead(void* entity) { return EntityUtils::IsEntityDead(entity); }
    inline bool IsEntityValid(void* entity) { return EntityUtils::IsEntityValid(entity); }
    inline void* GetSkinnedMeshComponent(void* entity) { return EntityUtils::GetSkinnedMeshComponent(entity); }
    inline void* GetSlotComponent(void* entity) { return EntityUtils::GetSlotComponent(entity); }
    inline Utils::Vector3 GetHeadPosition(void* entity) { return EntityUtils::GetHeadPosition(entity); }
    inline Utils::Vector3 GetHeadPositionFromTargeting(void* entity) { return EntityUtils::GetHeadPositionFromTargeting(entity); }
    inline Utils::Vector3 GetHeadPositionFromSlot(void* entity) { return EntityUtils::GetHeadPositionFromSlot(entity); }
    inline float GetEntityHeight(void* entity) { return EntityUtils::GetEntityHeight(entity); }
    inline void UpdatePlayerPosition() { PlayerUtils::UpdatePlayerPosition(); }
    inline bool WorldToScreen(const Utils::Vector3& worldPos, ImVec2& screenPos, float screenWidth, float screenHeight) { return CameraUtils::WorldToScreen(worldPos, screenPos, screenWidth, screenHeight); }
    inline float GetDistanceToCrosshair(const Utils::Vector3& worldPos, float screenWidth, float screenHeight) { return CameraUtils::GetDistanceToCrosshair(worldPos, screenWidth, screenHeight); }
    inline bool IsInFieldOfView(const Utils::Vector3& worldPos, float screenWidth, float screenHeight) { return CameraUtils::IsInFieldOfView(worldPos, screenWidth, screenHeight); }

    extern Utils::Vector3 g_PlayerPosition;
    extern bool g_PlayerPosValid;
    extern RED4ext::Handle<RED4ext::IScriptable> g_PlayerHandle;
}
