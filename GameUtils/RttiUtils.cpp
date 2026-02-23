#include "pch.h"
#include "RttiUtils.h"

namespace GameUtils
{
    namespace RttiUtils
    {
        RED4ext::CClass* g_GameObjectClass = nullptr;
        RED4ext::CClass* g_SkinnedMeshComponentClass = nullptr;
        RED4ext::CClass* g_TargetingSystemClass = nullptr;
        RED4ext::CClass* g_TargetPartInfoClass = nullptr;
        RED4ext::CBaseFunction* g_IsDeadFunc = nullptr;
        RED4ext::CBaseFunction* g_GetTargetingSystemFunc = nullptr;
        RED4ext::CBaseFunction* g_GetTargetPartsFunc = nullptr;
        RED4ext::CBaseFunction* g_TargetPartGetComponentFunc = nullptr;
        RED4ext::CBaseFunction* g_GetLocalToWorldFunc = nullptr;
        RED4ext::CBaseFunction* g_GetSlotTransformFunc = nullptr;
        RED4ext::CBaseFunction* g_GetWorldPositionFunc = nullptr;
        RED4ext::CBaseFunction* g_TSQ_EnemyNPCFunc = nullptr;
        RED4ext::CBaseFunction* g_TSQ_ALLFunc = nullptr;
        RED4ext::CBaseFunction* g_GetEntityIDFunc = nullptr;
        RED4ext::CProperty* g_CMesh_BoundingBox_Property = nullptr;
        void* g_CameraSystem = nullptr;
        bool g_SystemsInitialized = false;

        namespace Properties
        {
            RED4ext::CProperty* g_Entity_TransformComponent = nullptr;
            RED4ext::CProperty* g_IPlacedComponent_WorldTransform = nullptr;
            RED4ext::CProperty* g_WorldTransform_Position = nullptr;
            RED4ext::CProperty* g_GameObject_DisplayName = nullptr;
            RED4ext::CProperty* g_GameObject_IsDead = nullptr;
            RED4ext::CProperty* g_GameObject_WillDieSoon = nullptr;
            RED4ext::CProperty* g_GameObject_PersistentState = nullptr;
            RED4ext::CProperty* g_ScriptedPuppet_IsCyberpsycho = nullptr;
            RED4ext::CProperty* g_ScriptedPuppet_IsCivilian = nullptr;
            RED4ext::CProperty* g_ScriptedPuppet_IsPolice = nullptr;
            RED4ext::CProperty* g_ScriptedPuppet_IsGanger = nullptr;
            RED4ext::CProperty* g_ScriptedPuppet_HitReactionComponent = nullptr;
            RED4ext::CProperty* g_ScriptedPuppet_SlotComponent = nullptr;
            RED4ext::CProperty* g_ScriptedPuppet_TargetingComponentsArray = nullptr;
            RED4ext::CProperty* g_HitReactionComponent_IsAlive = nullptr;
            RED4ext::CProperty* g_PuppetReplicatedState_Health = nullptr;
            RED4ext::CProperty* g_SlotComponent_Slots = nullptr;
            RED4ext::CProperty* g_Entity_ComponentsStorage = nullptr;
            RED4ext::CProperty* g_TargetingComponent_IsPrimary = nullptr;
        }

        bool InitializeSystems()
        {
            if (g_SystemsInitialized)
                return true;

            auto engine = RED4ext::CGameEngine::Get();
            if (!Utils::IsValidPtr(engine) || !Utils::IsValidPtr(engine->framework) || !Utils::IsValidPtr(engine->framework->gameInstance))
                return false;

            auto rtti = RED4ext::CRTTISystem::Get();
            if (!Utils::IsValidPtr(rtti))
                return false;

            auto gameInstance = engine->framework->gameInstance;

            if (!g_CameraSystem)
            {
                auto cameraSystemClass = rtti->GetClass("gameCameraSystem");
                if (Utils::IsValidPtr(cameraSystemClass))
                {
                    auto system = gameInstance->GetSystem(cameraSystemClass);
                    if (Utils::IsValidPtr(system))
                    {
                        g_CameraSystem = system;
                        DBG_INFO("CameraSystem: 0x%p", g_CameraSystem);
                    }
                }
            }

            if (!g_GameObjectClass)
            {
                g_GameObjectClass = rtti->GetClass("gameObject");
                if (Utils::IsValidPtr(g_GameObjectClass))
                {
                    DBG_INFO("GameObject class: 0x%p", g_GameObjectClass);
                }
            }

            if (!g_GetWorldPositionFunc)
            {
                auto entityClass = rtti->GetClass("entEntity");
                if (Utils::IsValidPtr(entityClass))
                {
                    g_GetWorldPositionFunc = entityClass->GetFunction(RED4ext::CName("GetWorldPosition"));
                    if (Utils::IsValidPtr(g_GetWorldPositionFunc))
                    {
                        DBG_INFO("entEntity::GetWorldPosition function: 0x%p", g_GetWorldPositionFunc);
                    }
                }
            }

            if (g_GameObjectClass && !g_IsDeadFunc)
            {
                g_IsDeadFunc = g_GameObjectClass->GetFunction(RED4ext::CName("IsDead"));
                if (Utils::IsValidPtr(g_IsDeadFunc))
                {
                    DBG_INFO("GameObject::IsDead function: 0x%p", g_IsDeadFunc);
                }
            }

            if (!g_SkinnedMeshComponentClass)
            {
                g_SkinnedMeshComponentClass = rtti->GetClass("entSkinnedMeshComponent");
                if (Utils::IsValidPtr(g_SkinnedMeshComponentClass))
                {
                    DBG_INFO("SkinnedMeshComponent class: 0x%p", g_SkinnedMeshComponentClass);
                    DBG_INFO("SkinnedMeshComponent name: %s", g_SkinnedMeshComponentClass->name.ToString());
                }
                else
                {
                    DBG_INFO("SkinnedMeshComponent class not found!");
                }
            }

            if (!g_CMesh_BoundingBox_Property)
            {
                auto cMeshClass = rtti->GetClass("CMesh");
                if (Utils::IsValidPtr(cMeshClass))
                {
                    DBG_INFO("CMesh class: 0x%p", cMeshClass);
                    
                    auto boundingBoxProp = cMeshClass->GetProperty(RED4ext::CName("boundingBox"));
                    if (Utils::IsValidPtr(boundingBoxProp))
                    {
                        g_CMesh_BoundingBox_Property = boundingBoxProp;
                        DBG_INFO("CMesh::boundingBox offset: 0x%X", boundingBoxProp->valueOffset);
                    }
                }
                else
                {
                    DBG_INFO("CMesh class not found!");
                }
            }

            if (!g_TargetingSystemClass)
            {
                g_TargetingSystemClass = rtti->GetClass("gametargetingTargetingSystem");
                if (Utils::IsValidPtr(g_TargetingSystemClass))
                {
                    DBG_INFO("TargetingSystem class: 0x%p", g_TargetingSystemClass);
                }
            }

            if (!g_TargetPartInfoClass)
            {
                g_TargetPartInfoClass = rtti->GetClass("gametargetingTargetPartInfo");
                if (Utils::IsValidPtr(g_TargetPartInfoClass))
                {
                    DBG_INFO("TargetPartInfo class: 0x%p", g_TargetPartInfoClass);
                }
            }

            if (g_TargetingSystemClass && !g_GetTargetingSystemFunc)
            {
                auto scriptGameInstanceClass = rtti->GetClass("ScriptGameInstance");
                if (Utils::IsValidPtr(scriptGameInstanceClass))
                {
                    g_GetTargetingSystemFunc = scriptGameInstanceClass->GetFunction(RED4ext::CName("GetTargetingSystem"));
                    if (Utils::IsValidPtr(g_GetTargetingSystemFunc))
                    {
                        DBG_INFO("ScriptGameInstance::GetTargetingSystem function: 0x%p", g_GetTargetingSystemFunc);
                    }
                }
            }

            if (g_TargetingSystemClass && !g_GetTargetPartsFunc)
            {
                g_GetTargetPartsFunc = g_TargetingSystemClass->GetFunction(RED4ext::CName("GetTargetParts"));
                if (Utils::IsValidPtr(g_GetTargetPartsFunc))
                {
                    DBG_INFO("TargetingSystem::GetTargetParts function: 0x%p", g_GetTargetPartsFunc);
                }
            }

            if (g_TargetPartInfoClass && !g_TargetPartGetComponentFunc)
            {
                g_TargetPartGetComponentFunc = g_TargetPartInfoClass->GetFunction(RED4ext::CName("GetComponent"));
                if (Utils::IsValidPtr(g_TargetPartGetComponentFunc))
                {
                    DBG_INFO("TargetPartInfo::GetComponent function: 0x%p", g_TargetPartGetComponentFunc);
                }
            }

            if (!g_GetLocalToWorldFunc)
            {
                auto iPlacedComponentClass = rtti->GetClass("entIPlacedComponent");
                if (Utils::IsValidPtr(iPlacedComponentClass))
                {
                    g_GetLocalToWorldFunc = iPlacedComponentClass->GetFunction(RED4ext::CName("GetLocalToWorld"));
                    if (Utils::IsValidPtr(g_GetLocalToWorldFunc))
                    {
                        DBG_INFO("entIPlacedComponent::GetLocalToWorld function: 0x%p", g_GetLocalToWorldFunc);
                    }
                }
            }

            if (!g_TSQ_EnemyNPCFunc)
            {
                g_TSQ_EnemyNPCFunc = rtti->GetFunction(RED4ext::CName("TSQ_EnemyNPC"));
                if (Utils::IsValidPtr(g_TSQ_EnemyNPCFunc))
                {
                    DBG_INFO("TSQ_EnemyNPC function: 0x%p", g_TSQ_EnemyNPCFunc);
                }
                else
                {
                    DBG_INFO("TSQ_EnemyNPC function not found, trying with semicolon");
                    g_TSQ_EnemyNPCFunc = rtti->GetFunction(RED4ext::CName("TSQ_EnemyNPC;"));
                    if (Utils::IsValidPtr(g_TSQ_EnemyNPCFunc))
                    {
                        DBG_INFO("TSQ_EnemyNPC; function: 0x%p", g_TSQ_EnemyNPCFunc);
                    }
                }
            }

            if (!g_TSQ_ALLFunc)
            {
                g_TSQ_ALLFunc = rtti->GetFunction(RED4ext::CName("TSQ_ALL"));
                if (Utils::IsValidPtr(g_TSQ_ALLFunc))
                {
                    DBG_INFO("TSQ_ALL function: 0x%p", g_TSQ_ALLFunc);
                }
                else
                {
                    DBG_INFO("TSQ_ALL function not found, trying with semicolon");
                    g_TSQ_ALLFunc = rtti->GetFunction(RED4ext::CName("TSQ_ALL;"));
                    if (Utils::IsValidPtr(g_TSQ_ALLFunc))
                    {
                        DBG_INFO("TSQ_ALL; function: 0x%p", g_TSQ_ALLFunc);
                    }
                }
            }

            if (!g_GetEntityIDFunc)
            {
                auto entityClass = rtti->GetClass("entEntity");
                if (Utils::IsValidPtr(entityClass))
                {
                    g_GetEntityIDFunc = entityClass->GetFunction(RED4ext::CName("GetEntityID"));
                    if (Utils::IsValidPtr(g_GetEntityIDFunc))
                    {
                        DBG_INFO("entEntity::GetEntityID function: 0x%p", g_GetEntityIDFunc);
                    }
                }
            }

            if (!Properties::g_Entity_TransformComponent)
            {
                auto entityClass = rtti->GetClass("entEntity");
                if (Utils::IsValidPtr(entityClass))
                {
                    Properties::g_Entity_TransformComponent = entityClass->GetProperty(RED4ext::CName("transformComponent"));
                    if (Utils::IsValidPtr(Properties::g_Entity_TransformComponent))
                    {
                        DBG_INFO("entEntity::transformComponent offset: 0x%X", Properties::g_Entity_TransformComponent->valueOffset);
                    }
                }
            }

            if (!Properties::g_IPlacedComponent_WorldTransform)
            {
                auto iPlacedComponentClass = rtti->GetClass("entIPlacedComponent");
                if (Utils::IsValidPtr(iPlacedComponentClass))
                {
                    Properties::g_IPlacedComponent_WorldTransform = iPlacedComponentClass->GetProperty(RED4ext::CName("worldTransform"));
                    if (Utils::IsValidPtr(Properties::g_IPlacedComponent_WorldTransform))
                    {
                        DBG_INFO("entIPlacedComponent::worldTransform offset: 0x%X", Properties::g_IPlacedComponent_WorldTransform->valueOffset);
                    }
                }
            }

            if (!Properties::g_WorldTransform_Position)
            {
                auto worldTransformClass = rtti->GetClass("WorldTransform");
                if (Utils::IsValidPtr(worldTransformClass))
                {
                    Properties::g_WorldTransform_Position = worldTransformClass->GetProperty(RED4ext::CName("Position"));
                    if (Utils::IsValidPtr(Properties::g_WorldTransform_Position))
                    {
                        DBG_INFO("WorldTransform::Position offset: 0x%X", Properties::g_WorldTransform_Position->valueOffset);
                    }
                }
            }

            if (!Properties::g_GameObject_DisplayName)
            {
                if (g_GameObjectClass)
                {
                    Properties::g_GameObject_DisplayName = g_GameObjectClass->GetProperty(RED4ext::CName("displayName"));
                    if (Utils::IsValidPtr(Properties::g_GameObject_DisplayName))
                    {
                        DBG_INFO("gameObject::displayName offset: 0x%X", Properties::g_GameObject_DisplayName->valueOffset);
                    }
                }
            }

            if (!Properties::g_GameObject_IsDead)
            {
                if (g_GameObjectClass)
                {
                    Properties::g_GameObject_IsDead = g_GameObjectClass->GetProperty(RED4ext::CName("isDead"));
                    if (Utils::IsValidPtr(Properties::g_GameObject_IsDead))
                    {
                        DBG_INFO("gameObject::isDead offset: 0x%X", Properties::g_GameObject_IsDead->valueOffset);
                    }
                }
            }

            if (!Properties::g_GameObject_WillDieSoon)
            {
                if (g_GameObjectClass)
                {
                    Properties::g_GameObject_WillDieSoon = g_GameObjectClass->GetProperty(RED4ext::CName("willDieSoon"));
                    if (Utils::IsValidPtr(Properties::g_GameObject_WillDieSoon))
                    {
                        DBG_INFO("gameObject::willDieSoon offset: 0x%X", Properties::g_GameObject_WillDieSoon->valueOffset);
                    }
                }
            }

            if (!Properties::g_GameObject_PersistentState)
            {
                if (g_GameObjectClass)
                {
                    Properties::g_GameObject_PersistentState = g_GameObjectClass->GetProperty(RED4ext::CName("persistentState"));
                    if (Utils::IsValidPtr(Properties::g_GameObject_PersistentState))
                    {
                        DBG_INFO("gameObject::persistentState offset: 0x%X", Properties::g_GameObject_PersistentState->valueOffset);
                    }
                }
            }

            if (!Properties::g_ScriptedPuppet_IsCyberpsycho)
            {
                auto scriptedPuppetClass = rtti->GetClass("ScriptedPuppet");
                if (Utils::IsValidPtr(scriptedPuppetClass))
                {
                    Properties::g_ScriptedPuppet_IsCyberpsycho = scriptedPuppetClass->GetProperty(RED4ext::CName("isCyberpsycho"));
                    if (Utils::IsValidPtr(Properties::g_ScriptedPuppet_IsCyberpsycho))
                    {
                        DBG_INFO("ScriptedPuppet::isCyberpsycho offset: 0x%X", Properties::g_ScriptedPuppet_IsCyberpsycho->valueOffset);
                    }
                }
            }

            if (!Properties::g_ScriptedPuppet_IsCivilian)
            {
                auto scriptedPuppetClass = rtti->GetClass("ScriptedPuppet");
                if (Utils::IsValidPtr(scriptedPuppetClass))
                {
                    Properties::g_ScriptedPuppet_IsCivilian = scriptedPuppetClass->GetProperty(RED4ext::CName("isCivilian"));
                    if (Utils::IsValidPtr(Properties::g_ScriptedPuppet_IsCivilian))
                    {
                        DBG_INFO("ScriptedPuppet::isCivilian offset: 0x%X", Properties::g_ScriptedPuppet_IsCivilian->valueOffset);
                    }
                }
            }

            if (!Properties::g_ScriptedPuppet_IsPolice)
            {
                auto scriptedPuppetClass = rtti->GetClass("ScriptedPuppet");
                if (Utils::IsValidPtr(scriptedPuppetClass))
                {
                    Properties::g_ScriptedPuppet_IsPolice = scriptedPuppetClass->GetProperty(RED4ext::CName("isPolice"));
                    if (Utils::IsValidPtr(Properties::g_ScriptedPuppet_IsPolice))
                    {
                        DBG_INFO("ScriptedPuppet::isPolice offset: 0x%X", Properties::g_ScriptedPuppet_IsPolice->valueOffset);
                    }
                }
            }

            if (!Properties::g_ScriptedPuppet_IsGanger)
            {
                auto scriptedPuppetClass = rtti->GetClass("ScriptedPuppet");
                if (Utils::IsValidPtr(scriptedPuppetClass))
                {
                    Properties::g_ScriptedPuppet_IsGanger = scriptedPuppetClass->GetProperty(RED4ext::CName("isGanger"));
                    if (Utils::IsValidPtr(Properties::g_ScriptedPuppet_IsGanger))
                    {
                        DBG_INFO("ScriptedPuppet::isGanger offset: 0x%X", Properties::g_ScriptedPuppet_IsGanger->valueOffset);
                    }
                }
            }

            if (!Properties::g_ScriptedPuppet_HitReactionComponent)
            {
                auto scriptedPuppetClass = rtti->GetClass("ScriptedPuppet");
                if (Utils::IsValidPtr(scriptedPuppetClass))
                {
                    Properties::g_ScriptedPuppet_HitReactionComponent = scriptedPuppetClass->GetProperty(RED4ext::CName("hitReactionComponent"));
                    if (Utils::IsValidPtr(Properties::g_ScriptedPuppet_HitReactionComponent))
                    {
                        DBG_INFO("ScriptedPuppet::hitReactionComponent offset: 0x%X", Properties::g_ScriptedPuppet_HitReactionComponent->valueOffset);
                    }
                }
            }

            if (!Properties::g_ScriptedPuppet_SlotComponent)
            {
                auto scriptedPuppetClass = rtti->GetClass("ScriptedPuppet");
                if (Utils::IsValidPtr(scriptedPuppetClass))
                {
                    Properties::g_ScriptedPuppet_SlotComponent = scriptedPuppetClass->GetProperty(RED4ext::CName("slotComponent"));
                    if (Utils::IsValidPtr(Properties::g_ScriptedPuppet_SlotComponent))
                    {
                        DBG_INFO("ScriptedPuppet::slotComponent offset: 0x%X", Properties::g_ScriptedPuppet_SlotComponent->valueOffset);
                    }
                }
            }

            if (!Properties::g_ScriptedPuppet_TargetingComponentsArray)
            {
                auto scriptedPuppetClass = rtti->GetClass("ScriptedPuppet");
                if (Utils::IsValidPtr(scriptedPuppetClass))
                {
                    Properties::g_ScriptedPuppet_TargetingComponentsArray = scriptedPuppetClass->GetProperty(RED4ext::CName("targetingComponentsArray"));
                    if (Utils::IsValidPtr(Properties::g_ScriptedPuppet_TargetingComponentsArray))
                    {
                        DBG_INFO("ScriptedPuppet::targetingComponentsArray offset: 0x%X", Properties::g_ScriptedPuppet_TargetingComponentsArray->valueOffset);
                    }
                }
            }

            if (!Properties::g_HitReactionComponent_IsAlive)
            {
                auto hitReactionComponentClass = rtti->GetClass("HitReactionComponent");
                if (Utils::IsValidPtr(hitReactionComponentClass))
                {
                    Properties::g_HitReactionComponent_IsAlive = hitReactionComponentClass->GetProperty(RED4ext::CName("isAlive"));
                    if (Utils::IsValidPtr(Properties::g_HitReactionComponent_IsAlive))
                    {
                        DBG_INFO("HitReactionComponent::isAlive offset: 0x%X", Properties::g_HitReactionComponent_IsAlive->valueOffset);
                    }
                }
            }

            if (!Properties::g_PuppetReplicatedState_Health)
            {
                auto puppetReplicatedStateClass = rtti->GetClass("PuppetReplicatedState");
                if (Utils::IsValidPtr(puppetReplicatedStateClass))
                {
                    Properties::g_PuppetReplicatedState_Health = puppetReplicatedStateClass->GetProperty(RED4ext::CName("health"));
                    if (Utils::IsValidPtr(Properties::g_PuppetReplicatedState_Health))
                    {
                        DBG_INFO("PuppetReplicatedState::health offset: 0x%X", Properties::g_PuppetReplicatedState_Health->valueOffset);
                    }
                }
            }

            if (!Properties::g_SlotComponent_Slots)
            {
                auto slotComponentClass = rtti->GetClass("entSlotComponent");
                if (Utils::IsValidPtr(slotComponentClass))
                {
                    Properties::g_SlotComponent_Slots = slotComponentClass->GetProperty(RED4ext::CName("slots"));
                    if (Utils::IsValidPtr(Properties::g_SlotComponent_Slots))
                    {
                        DBG_INFO("entSlotComponent::slots offset: 0x%X", Properties::g_SlotComponent_Slots->valueOffset);
                    }
                }
            }

            if (!g_GetSlotTransformFunc)
            {
                auto slotComponentClass = rtti->GetClass("entSlotComponent");
                if (Utils::IsValidPtr(slotComponentClass))
                {
                    g_GetSlotTransformFunc = slotComponentClass->GetFunction(RED4ext::CName("GetSlotTransform"));
                    if (Utils::IsValidPtr(g_GetSlotTransformFunc))
                    {
                        DBG_INFO("entSlotComponent::GetSlotTransform function: 0x%p", g_GetSlotTransformFunc);
                    }
                }
            }

            if (!Properties::g_Entity_ComponentsStorage)
            {
                auto entityClass = rtti->GetClass("entEntity");
                if (Utils::IsValidPtr(entityClass))
                {
                    Properties::g_Entity_ComponentsStorage = entityClass->GetProperty(RED4ext::CName("componentsStorage"));
                    if (Utils::IsValidPtr(Properties::g_Entity_ComponentsStorage))
                    {
                        DBG_INFO("entEntity::componentsStorage offset: 0x%X", Properties::g_Entity_ComponentsStorage->valueOffset);
                    }
                }
            }

            if (!Properties::g_TargetingComponent_IsPrimary)
            {
                auto targetingComponentClass = rtti->GetClass("gameTargetingComponent");
                if (Utils::IsValidPtr(targetingComponentClass))
                {
                    Properties::g_TargetingComponent_IsPrimary = targetingComponentClass->GetProperty(RED4ext::CName("isPrimary"));
                    if (Utils::IsValidPtr(Properties::g_TargetingComponent_IsPrimary))
                    {
                        DBG_INFO("gameTargetingComponent::isPrimary offset: 0x%X", Properties::g_TargetingComponent_IsPrimary->valueOffset);
                    }
                }
            }

            g_SystemsInitialized = true;
            DBG_INFO("All RTTI pointers initialized!");
            return true;
        }

        void ForceInitialize()
        {
            g_SystemsInitialized = false;
            g_GameObjectClass = nullptr;
            g_IsDeadFunc = nullptr;
            g_SkinnedMeshComponentClass = nullptr;
            g_CMesh_BoundingBox_Property = nullptr;
            g_TargetingSystemClass = nullptr;
            g_TargetPartInfoClass = nullptr;
            g_GetTargetingSystemFunc = nullptr;
            g_GetTargetPartsFunc = nullptr;
            g_TargetPartGetComponentFunc = nullptr;
            g_GetLocalToWorldFunc = nullptr;
            Properties::g_Entity_TransformComponent = nullptr;
            Properties::g_IPlacedComponent_WorldTransform = nullptr;
            Properties::g_WorldTransform_Position = nullptr;
            Properties::g_GameObject_DisplayName = nullptr;
            Properties::g_GameObject_IsDead = nullptr;
            Properties::g_GameObject_WillDieSoon = nullptr;
            Properties::g_GameObject_PersistentState = nullptr;
            Properties::g_ScriptedPuppet_IsCyberpsycho = nullptr;
            Properties::g_ScriptedPuppet_IsCivilian = nullptr;
            Properties::g_ScriptedPuppet_IsPolice = nullptr;
            Properties::g_ScriptedPuppet_IsGanger = nullptr;
            Properties::g_ScriptedPuppet_HitReactionComponent = nullptr;
            Properties::g_ScriptedPuppet_SlotComponent = nullptr;
            Properties::g_HitReactionComponent_IsAlive = nullptr;
            Properties::g_PuppetReplicatedState_Health = nullptr;
            Properties::g_SlotComponent_Slots = nullptr;
            g_GetSlotTransformFunc = nullptr;
            g_GetWorldPositionFunc = nullptr;
            Properties::g_Entity_ComponentsStorage = nullptr;
            
            DBG_INFO("========================================");
            DBG_INFO("Force re-initializing RTTI pointers...");
            DBG_INFO("========================================");
            InitializeSystems();
        }
    }
}