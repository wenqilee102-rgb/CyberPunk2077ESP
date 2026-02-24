#pragma once

#include "../pch.h"
#include "RttiUtils.h"

namespace GameUtils
{
    namespace EntityUtils
    {
        void GetInheritancePath(RED4ext::CClass* cls, char* buffer, size_t bufferSize);
        Utils::Vector3 GetEntityPosition(void* entity);
        bool IsEntityDead(void* entity);
        bool IsEntityValid(void* entity);
        void* GetSkinnedMeshComponent(void* entity);
        void* GetSlotComponent(void* entity);
        Utils::Vector3 GetHeadPosition(void* entity);
        Utils::Vector3 GetHeadPositionFromTargeting(void* entity, int boneIndex);
        Utils::Vector3 GetHeadPositionFromSlot(void* entity);
        float GetEntityHeight(void* entity);
        void UpdateCacheFrame();
        void SwapCacheBuffers();
    }
}
