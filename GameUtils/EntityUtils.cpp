#include "pch.h"
#include "EntityUtils.h"
#include "PlayerUtils.h"
#include "../ESP.h"
#include "../TargetingParts.h"
#include "MemoryUtils.h"
#include <RED4ext/Scripting/Natives/CMesh.hpp>
#include <RED4ext/Scripting/Natives/Generated/Matrix.hpp>
#include <RED4ext/Scripting/Natives/Generated/ent/EntityID.hpp>
#include <RED4ext/Scripting/Natives/Generated/game/targeting/TargetPartInfo.hpp>

namespace GameUtils
{
    namespace EntityUtils
    {
        struct TargetingCacheEntry
        {
            void* EntityPtr;
            Utils::Vector3 Position;
            int SelectedPartIndex;
            uint32_t Timestamp;
            bool IsValid;
        };

        struct DeathStateCacheEntry
        {
            void* EntityPtr;
            bool IsDead;
            uint32_t Timestamp;
            bool IsValid;
        };

        static TargetingCacheEntry g_TargetingCache[64] = {};
        static DeathStateCacheEntry g_DeathStateCache[128] = {};
        static uint32_t g_CacheFrameCount = 0;
        const uint32_t g_CacheLifetime = 30;

        static Utils::Vector3 GetCachedHeadPosition(void* entity)
        {
            if (!Utils::IsValidPtr(entity))
                return Utils::Vector3(0, 0, 0);

            for (int i = 0; i < 64; i++)
            {
                auto& entry = g_TargetingCache[i];
                if (entry.IsValid && entry.EntityPtr == entity)
                {
                    uint32_t age = g_CacheFrameCount - entry.Timestamp;
                    if (age < g_CacheLifetime)
                    {
                        ESP::g_TargetingDebugInfo.SelectedPartIndex = entry.SelectedPartIndex;
                        return entry.Position;
                    }
                    else
                    {
                        entry.IsValid = false;
                    }
                }
            }
            return Utils::Vector3(0, 0, 0);
        }

        static void SetCachedHeadPosition(void* entity, const Utils::Vector3& pos, int selectedPartIndex = -1)
        {
            if (!Utils::IsValidPtr(entity))
                return;

            int oldestIndex = 0;
            uint32_t oldestAge = 0;
            int freeIndex = -1;

            for (int i = 0; i < 64; i++)
            {
                auto& entry = g_TargetingCache[i];
                if (!entry.IsValid)
                {
                    freeIndex = i;
                    break;
                }
                uint32_t age = g_CacheFrameCount - entry.Timestamp;
                if (age > oldestAge)
                {
                    oldestAge = age;
                    oldestIndex = i;
                }
            }

            int targetIndex = (freeIndex >= 0) ? freeIndex : oldestIndex;
            g_TargetingCache[targetIndex].EntityPtr = entity;
            g_TargetingCache[targetIndex].Position = pos;
            g_TargetingCache[targetIndex].SelectedPartIndex = selectedPartIndex;
            g_TargetingCache[targetIndex].Timestamp = g_CacheFrameCount;
            g_TargetingCache[targetIndex].IsValid = true;
        }

        static void ClearCachedHeadPosition(void* entity)
        {
            if (!Utils::IsValidPtr(entity))
                return;

            for (int i = 0; i < 64; i++)
            {
                auto& entry = g_TargetingCache[i];
                if (entry.IsValid && entry.EntityPtr == entity)
                {
                    entry.IsValid = false;
                    return;
                }
            }
        }

        void GetInheritancePath(RED4ext::CClass* cls, char* buffer, size_t bufferSize)
        {
            if (!cls || !buffer || bufferSize == 0) return;
            
            buffer[0] = '\0';
            size_t offset = 0;
            
            RED4ext::CClass* current = cls;
            while (current && offset < bufferSize - 64)
            {
                const char* name = current->GetName().ToString();
                size_t nameLen = strlen(name);
                
                if (offset > 0)
                {
                    buffer[offset++] = ' ';
                    buffer[offset++] = '<';
                    buffer[offset++] = '-';
                    buffer[offset++] = ' ';
                }
                
                memcpy(buffer + offset, name, nameLen);
                offset += nameLen;
                
                current = current->parent;
            }
            buffer[offset] = '\0';
        }

        Utils::Vector3 GetEntityPosition(void* entity)
        {
            Utils::Vector3 result(0, 0, 0);

            if (!Utils::IsValidPtr(entity))
                return result;

            if (RttiUtils::g_GetWorldPositionFunc && Utils::IsValidPtr(RttiUtils::g_GetWorldPositionFunc))
            {
                Utils::Vector4 worldPos;
                RED4ext::CStackType resultType;
                resultType.type = RED4ext::CRTTISystem::Get()->GetType("Vector4");
                resultType.value = &worldPos;

                RED4ext::CStack stack(entity, nullptr, 0, &resultType);
                RttiUtils::g_GetWorldPositionFunc->Execute(&stack);

                result.X = worldPos.X;
                result.Y = worldPos.Y;
                result.Z = worldPos.Z;
            }

            return result;
        }

        bool IsEntityDead(void* entity)
        {
            if (!Utils::IsValidPtr(entity))
                return true;

            for (int i = 0; i < 128; i++)
            {
                auto& entry = g_DeathStateCache[i];
                if (entry.IsValid && entry.EntityPtr == entity)
                {
                    uint32_t age = g_CacheFrameCount - entry.Timestamp;
                    if (age < g_CacheLifetime)
                    {
                        return entry.IsDead;
                    }
                    else
                    {
                        entry.IsValid = false;
                    }
                }
            }

            if (!RttiUtils::g_IsDeadFunc)
                return false;

            auto rtti = RED4ext::CRTTISystem::Get();
            if (!rtti)
                return false;

            auto boolType = rtti->GetType("Bool");
            if (!boolType)
                return false;

            auto gameObjectClass = rtti->GetClass("gameObject");
            if (!gameObjectClass)
                return false;

            auto scriptable = reinterpret_cast<RED4ext::IScriptable*>(entity);
            auto entityType = scriptable->GetType();
            if (!entityType || !entityType->IsA(gameObjectClass))
                return false;

            bool isDead = false;
            RED4ext::CStackType resultType;
            resultType.type = boolType;
            resultType.value = &isDead;

            RED4ext::CStack stack(entity, nullptr, 0, &resultType);
            
            try
            {
                if (!RttiUtils::g_IsDeadFunc->Execute(&stack))
                    return false;
            }
            catch (...)
            {
                return false;
            }

            int freeIndex = -1;
            int oldestIndex = 0;
            uint32_t oldestAge = 0;

            for (int i = 0; i < 128; i++)
            {
                auto& entry = g_DeathStateCache[i];
                if (!entry.IsValid)
                {
                    freeIndex = i;
                    break;
                }
                uint32_t age = g_CacheFrameCount - entry.Timestamp;
                if (age > oldestAge)
                {
                    oldestAge = age;
                    oldestIndex = i;
                }
            }

            int targetIndex = (freeIndex >= 0) ? freeIndex : oldestIndex;
            g_DeathStateCache[targetIndex].EntityPtr = entity;
            g_DeathStateCache[targetIndex].IsDead = isDead;
            g_DeathStateCache[targetIndex].Timestamp = g_CacheFrameCount;
            g_DeathStateCache[targetIndex].IsValid = true;

            return isDead;
        }

        void UpdateCacheFrame()
        {
            g_CacheFrameCount++;
        }

        bool IsEntityValid(void* entity)
        {
            if (!Utils::IsValidPtr(entity))
                return false;

            return true;
        }

        void* GetSkinnedMeshComponent(void* entity)
        {
            if (!Utils::IsValidPtr(entity))
                return nullptr;

            auto entityPtr = reinterpret_cast<uintptr_t>(entity);
            
            void* componentsStorage = nullptr;
            if (RttiUtils::Properties::g_Entity_ComponentsStorage)
            {
                auto componentsStoragePtr = entityPtr + RttiUtils::Properties::g_Entity_ComponentsStorage->valueOffset;
                if (Utils::IsValidPtr(reinterpret_cast<void*>(componentsStoragePtr)))
                {
                    componentsStorage = reinterpret_cast<void*>(componentsStoragePtr);
                }
            }
            
            if (!Utils::IsValidPtr(componentsStorage))
                return nullptr;

            auto componentsArrayPtr = reinterpret_cast<uintptr_t>(componentsStorage) + 0x30;
            if (!Utils::IsValidPtr(reinterpret_cast<void*>(componentsArrayPtr)))
                return nullptr;

            auto elementsPtr = *reinterpret_cast<void**>(componentsArrayPtr);
            if (!Utils::IsValidPtr(elementsPtr))
                return nullptr;

            auto count = *reinterpret_cast<uint32_t*>(componentsArrayPtr + 0x10);
            auto capacity = *reinterpret_cast<uint32_t*>(componentsArrayPtr + 0x14);

            auto rtti = RED4ext::CRTTISystem::Get();
            if (!Utils::IsValidPtr(rtti))
                return nullptr;

            if (!RttiUtils::g_SkinnedMeshComponentClass)
                RttiUtils::g_SkinnedMeshComponentClass = rtti->GetClass("entSkinnedMeshComponent");
            if (!Utils::IsValidPtr(RttiUtils::g_SkinnedMeshComponentClass))
                return nullptr;

            auto elements = reinterpret_cast<uintptr_t*>(elementsPtr);
            for (uint32_t i = 0; i < count && i < capacity; i++)
            {
                if (!Utils::IsValidPtr(reinterpret_cast<void*>(elements[i])))
                    continue;

                auto componentPtr = elements[i];
                auto componentClass = *reinterpret_cast<RED4ext::CClass**>(componentPtr);
                if (!Utils::IsValidPtr(componentClass))
                    continue;

                if (componentClass == RttiUtils::g_SkinnedMeshComponentClass)
                {
                    return reinterpret_cast<void*>(componentPtr);
                }
            }

            return nullptr;
        }

        void* GetSlotComponent(void* entity)
        {
            if (!Utils::IsValidPtr(entity))
                return nullptr;

            if (RttiUtils::Properties::g_ScriptedPuppet_SlotComponent)
            {
                auto entityPtr = reinterpret_cast<uintptr_t>(entity);
                auto slotComponentHandlePtr = entityPtr + RttiUtils::Properties::g_ScriptedPuppet_SlotComponent->valueOffset;
                
                if (Utils::IsValidPtr(reinterpret_cast<void*>(slotComponentHandlePtr)))
                {
                    auto handlePtr = *reinterpret_cast<void**>(slotComponentHandlePtr);
                    if (Utils::IsValidPtr(handlePtr))
                    {
                        auto slotComponentPtr = *reinterpret_cast<void**>(handlePtr);
                        if (Utils::IsValidPtr(slotComponentPtr))
                        {
                            return slotComponentPtr;
                        }
                    }
                }
            }

            auto entityPtr = reinterpret_cast<uintptr_t>(entity);
            
            void* componentsStorage = nullptr;
            if (RttiUtils::Properties::g_Entity_ComponentsStorage)
            {
                auto componentsStoragePtr = entityPtr + RttiUtils::Properties::g_Entity_ComponentsStorage->valueOffset;
                if (Utils::IsValidPtr(reinterpret_cast<void*>(componentsStoragePtr)))
                {
                    componentsStorage = reinterpret_cast<void*>(componentsStoragePtr);
                }
            }
            
            if (!Utils::IsValidPtr(componentsStorage))
                return nullptr;

            auto componentsArrayPtr = reinterpret_cast<uintptr_t>(componentsStorage) + 0x30;
            if (!Utils::IsValidPtr(reinterpret_cast<void*>(componentsArrayPtr)))
                return nullptr;

            auto elementsPtr = *reinterpret_cast<void**>(componentsArrayPtr);
            if (!Utils::IsValidPtr(elementsPtr))
                return nullptr;

            auto count = *reinterpret_cast<uint32_t*>(componentsArrayPtr + 0x10);
            auto capacity = *reinterpret_cast<uint32_t*>(componentsArrayPtr + 0x14);

            auto rtti = RED4ext::CRTTISystem::Get();
            if (!Utils::IsValidPtr(rtti))
                return nullptr;

            auto slotComponentClass = rtti->GetClass("entSlotComponent");
            if (!Utils::IsValidPtr(slotComponentClass))
                return nullptr;

            auto elements = reinterpret_cast<uintptr_t*>(elementsPtr);
            for (uint32_t i = 0; i < count && i < capacity; i++)
            {
                if (!Utils::IsValidPtr(reinterpret_cast<void*>(elements[i])))
                    continue;

                auto componentPtr = elements[i];
                auto componentClass = *reinterpret_cast<RED4ext::CClass**>(componentPtr);
                if (!Utils::IsValidPtr(componentClass))
                    continue;

                if (componentClass == slotComponentClass || componentClass->IsA(slotComponentClass))
                {
                    return reinterpret_cast<void*>(componentPtr);
                }
            }

            return nullptr;
        }

        Utils::Vector3 GetHeadPosition(void* entity)
        {
            if (!Utils::IsValidPtr(entity))
                return GetEntityPosition(entity);

            auto slotPos = GetHeadPositionFromSlot(entity);
            if (slotPos.IsValid())
                return slotPos;

            auto targetingPos = GetHeadPositionFromTargeting(entity, 0);
            if (targetingPos.IsValid())
                return targetingPos;

            auto basePos = GetEntityPosition(entity);
            return Utils::Vector3(basePos.X, basePos.Y, basePos.Z + 1.8f);
        }

        Utils::Vector3 GetHeadPositionFromTargeting(void* entity, int boneIndex)
        {
            g_CacheFrameCount++;

            if (!Utils::IsValidPtr(entity))
                return Utils::Vector3(0, 0, 0);

            static void* lastEntity = nullptr;
            static int lastBoneIndex = -1;
            
            bool cacheValid = (lastEntity == entity && lastBoneIndex == boneIndex);
            
            if (cacheValid)
            {
                auto cachedPos = GetCachedHeadPosition(entity);
                if (cachedPos.X != 0.0f || cachedPos.Y != 0.0f || cachedPos.Z != 0.0f)
                {
                    return cachedPos;
                }
            }
            
            if (lastEntity != entity || lastBoneIndex != boneIndex)
            {
                ClearCachedHeadPosition(entity);
            }
            
            lastEntity = entity;
            lastBoneIndex = boneIndex;

            auto rtti = RED4ext::CRTTISystem::Get();
            if (!rtti)
                return Utils::Vector3(0, 0, 0);

            static bool loggedInit = false;
            
            if (!RttiUtils::g_GetTargetingSystemFunc || !RttiUtils::g_GetTargetPartsFunc || 
                !RttiUtils::g_TargetPartGetComponentFunc || !RttiUtils::g_GetLocalToWorldFunc ||
                !RttiUtils::g_TSQ_ALLFunc)
            {
                if (!loggedInit)
                {
                    DBG_INFO("[Targeting] Required functions not initialized");
                    loggedInit = true;
                }
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
            RttiUtils::g_GetTargetingSystemFunc->Execute(&tsStack);

            if (!targetingSystemHandle.instance)
            {
                if (!loggedInit)
                {
                    DBG_INFO("[Targeting] Failed to get TargetingSystem");
                    loggedInit = true;
                }
                return Utils::Vector3(0, 0, 0);
            }

            auto targetingSystem = targetingSystemHandle.instance;

            RED4ext::CName queryTypeName = RED4ext::CName("gameTargetSearchQuery");
            auto queryType = rtti->GetType(queryTypeName);
            if (!queryType)
                return Utils::Vector3(0, 0, 0);

            auto scriptAllocator = GameUtils::MemoryUtils::GetScriptAllocator();
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
            RttiUtils::g_TSQ_ALLFunc->Execute(&queryStack);

            if (RttiUtils::g_GetEntityIDFunc)
            {
                RED4ext::ent::EntityID targetEntityID;
                RED4ext::CStackType eidResult;
                eidResult.type = rtti->GetType("entEntityID");
                eidResult.value = &targetEntityID;

                RED4ext::CStack eidStack(entity, nullptr, 0, &eidResult);
                RttiUtils::g_GetEntityIDFunc->Execute(&eidStack);

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

            auto playerHandle = g_PlayerHandle;
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
            RttiUtils::g_GetTargetPartsFunc->Execute(&getPartsStack);

            scriptAllocator->Free(allocResult);

            if (!getPartsResult || partsArray.size == 0)
                return Utils::Vector3(0, 0, 0);

            Utils::Vector3 bestPosition(0, 0, 0);
            float bestDistance = FLT_MAX;

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
                RttiUtils::g_TargetPartGetComponentFunc->Execute(&compStack);

                if (!componentWhandle.instance)
                    continue;

                auto component = componentWhandle.instance;
                
                RED4ext::Matrix worldMatrix;
                RED4ext::CStackType matrixResult;
                matrixResult.type = rtti->GetType("Matrix");
                matrixResult.value = &worldMatrix;

                RED4ext::CStack matrixStack(component, nullptr, 0, &matrixResult);
                RttiUtils::g_GetLocalToWorldFunc->Execute(&matrixStack);

                Utils::Vector3 pos(worldMatrix.W.X, worldMatrix.W.Y, worldMatrix.W.Z);

                if (!pos.IsValid() || (pos.X == 0.0f && pos.Y == 0.0f && pos.Z == 0.0f))
                    continue;

                bool shouldUse = TargetingParts::ShouldSelectPart(i, boneIndex);

                if (shouldUse)
                {
                    ESP::g_TargetingDebugInfo.SelectedPartIndex = i;
                    SetCachedHeadPosition(entity, pos, i);
                    return pos;
                }

                float distance = pos.Z;
                if (distance < bestDistance)
                {
                    bestDistance = distance;
                    bestPosition = pos;
                }
            }

            if (bestPosition.IsValid() && (bestPosition.X != 0.0f || bestPosition.Y != 0.0f || bestPosition.Z != 0.0f))
            {
                ESP::g_TargetingDebugInfo.SelectedPartIndex = -1;
                SetCachedHeadPosition(entity, bestPosition, -1);
                return bestPosition;
            }

            return Utils::Vector3(0, 0, 0);
        }

        Utils::Vector3 GetHeadPositionFromSlot(void* entity)
        {
            auto slotComponent = GetSlotComponent(entity);
            if (!Utils::IsValidPtr(slotComponent))
                return GetEntityPosition(entity);
            
            RED4ext::CName headSlot("head");
            RED4ext::WorldTransform worldTransform;
            
            if (!RttiUtils::g_GetSlotTransformFunc)
                return GetEntityPosition(entity);
            
            auto rtti = RED4ext::CRTTISystem::Get();
            if (!rtti)
                return GetEntityPosition(entity);
            
            RED4ext::CStackType args[2];
            args[0].type = rtti->GetType("CName");
            args[0].value = &headSlot;
            args[1].type = rtti->GetType("WorldTransform");
            args[1].value = &worldTransform;
            
            RED4ext::CStackType result;
            result.type = rtti->GetType("Bool");
            bool success = false;
            result.value = &success;
            
            RED4ext::CStack stack(slotComponent, args, 2, &result);
            RttiUtils::g_GetSlotTransformFunc->Execute(&stack);
            
            if (success)
            {
                float posX = static_cast<float>(worldTransform.Position.x.Bits) / 131072.0f;
                float posY = static_cast<float>(worldTransform.Position.y.Bits) / 131072.0f;
                float posZ = static_cast<float>(worldTransform.Position.z.Bits) / 131072.0f;
                return Utils::Vector3(posX, posY, posZ);
            }
            
            return GetEntityPosition(entity);
        }

        float GetEntityHeight(void* entity)
        {
            if (!Utils::IsValidPtr(entity))
                return 1.8f;

            auto skinnedMesh = GetSkinnedMeshComponent(entity);
            if (!Utils::IsValidPtr(skinnedMesh))
                return 1.8f;

            auto skinnedMeshPtr = reinterpret_cast<uintptr_t>(skinnedMesh);
            auto meshPtr = *reinterpret_cast<uintptr_t*>(skinnedMeshPtr + 0x28);

            if (!Utils::IsValidPtr(reinterpret_cast<void*>(meshPtr)))
                return 1.8f;

            auto mesh = reinterpret_cast<RED4ext::CMesh*>(meshPtr);

            if (!RttiUtils::g_CMesh_BoundingBox_Property)
                return 1.8f;

            auto boundingBoxPtr = reinterpret_cast<uintptr_t>(mesh) + RttiUtils::g_CMesh_BoundingBox_Property->valueOffset;
            if (!Utils::IsValidPtr(reinterpret_cast<void*>(boundingBoxPtr)))
                return 1.8f;

            auto boundingBox = reinterpret_cast<RED4ext::Box*>(boundingBoxPtr);
            if (!Utils::IsValidPtr(boundingBox))
                return 1.8f;

            float height = boundingBox->Max.Z - boundingBox->Min.Z;
            if (height <= 0.0f || height > 5.0f)
                return 1.8f;

            return height;
        }
    }
}
