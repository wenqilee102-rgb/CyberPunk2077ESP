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
        extern RED4ext::CBaseFunction* g_TSQ_EnemyNPCFunc;
        extern RED4ext::CBaseFunction* g_TSQ_ALLFunc;
        extern RED4ext::CBaseFunction* g_GetEntityIDFunc;
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
            extern RED4ext::CProperty* g_ScriptedPuppet_SlotComponent;
            extern RED4ext::CProperty* g_ScriptedPuppet_TargetingComponentsArray;
            extern RED4ext::CProperty* g_HitReactionComponent_IsAlive;
            extern RED4ext::CProperty* g_PuppetReplicatedState_Health;
            extern RED4ext::CProperty* g_SlotComponent_Slots;
            extern RED4ext::CProperty* g_Entity_ComponentsStorage;
            extern RED4ext::CProperty* g_TargetingComponent_IsPrimary;
        }

        bool InitializeSystems();
        void ForceInitialize();
    }
}
