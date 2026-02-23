#pragma once

#define WIN32_LEAN_AND_MEAN
#include <windows.h>
#include <VersionHelpers.h>

#include <cstdio>
#include <cstdint>
#include <cstddef>
#include <cmath>
#include <cstdlib>
#include <cstring>

#include <string>
#include <vector>
#include <memory>
#include <functional>

#define DH_USE_D3D12 1
#include "DirectHook/directhook.h"

#include <d3d12.h>
#include <dxgi1_4.h>
#include <dxgi1_5.h>
#include <dxgi1_6.h>

#include "Imgui/imgui.h"
#include "Imgui/backends/imgui_impl_win32.h"
#include "Imgui/backends/imgui_impl_dx12.h"

#include "DebugConsole.h"

#include "RED4ext/RED4ext.hpp"
#include "RED4ext/GameEngine.hpp"
#include "RED4ext/RTTISystem.hpp"
#include "RED4ext/RTTITypes.hpp"
#include "RED4ext/Scripting/IScriptable.hpp"
#include "RED4ext/Scripting/CProperty.hpp"
#include "RED4ext/Scripting/Natives/ScriptGameInstance.hpp"
#include "RED4ext/Scripting/Natives/entEntity.hpp"
#include "RED4ext/Scripting/Natives/entIPlacedComponent.hpp"
#include "RED4ext/Scripting/Natives/Vector4.hpp"
#include "RED4ext/Scripting/Natives/WorldPosition.hpp"
#include "RED4ext/Scripting/Natives/Generated/game/TargetingSet.hpp"
#include "RED4ext/Scripting/Natives/Generated/game/TargetSearchQuery.hpp"
#include "RED4ext/Scripting/Natives/Generated/game/targeting/TargetPartInfo.hpp"
#include "RED4ext/Scripting/Natives/Generated/Matrix.hpp"
#include "RED4ext/DynArray.hpp"
#include "RED4ext/Handle.hpp"
#include "RED4ext/CString.hpp"
#include "RED4ext/CName.hpp"
#include "RED4ext/Scripting/Stack.hpp"

namespace Utils
{
    constexpr uintptr_t MIN_VALID_ADDRESS = 0x10000;
    constexpr uintptr_t MAX_VALID_ADDRESS = 0x7FFFFFFFFFFF;

    inline bool IsValidPtrFast(const void* ptr)
    {
        if (ptr == nullptr)
            return false;
        auto addr = reinterpret_cast<uintptr_t>(ptr);
        return addr >= MIN_VALID_ADDRESS && addr <= MAX_VALID_ADDRESS;
    }

    inline bool IsValidPtr(const void* ptr)
    {
        return IsValidPtrFast(ptr);
    }

    struct Vector3
    {
        float X, Y, Z;

        Vector3() : X(0), Y(0), Z(0) {}
        Vector3(float x, float y, float z) : X(x), Y(y), Z(z) {}

        bool IsValid() const
        {
            return !std::isnan(X) && !std::isnan(Y) && !std::isnan(Z) &&
                   !std::isinf(X) && !std::isinf(Y) && !std::isinf(Z);
        }
        
        Vector3 operator+(const Vector3& other) const
        {
            return Vector3(X + other.X, Y + other.Y, Z + other.Z);
        }
        
        Vector3 operator-(const Vector3& other) const
        {
            return Vector3(X - other.X, Y - other.Y, Z - other.Z);
        }
        
        float DistanceTo(const Vector3& other) const
        {
            float dx = X - other.X;
            float dy = Y - other.Y;
            float dz = Z - other.Z;
            return sqrtf(dx * dx + dy * dy + dz * dz);
        }
    };

    struct Vector4
    {
        float X, Y, Z, W;

        Vector4() : X(0), Y(0), Z(0), W(0) {}
        Vector4(float x, float y, float z, float w = 1.0f) : X(x), Y(y), Z(z), W(w) {}

        bool IsValid() const
        {
            return !std::isnan(X) && !std::isnan(Y) && !std::isnan(Z) &&
                   !std::isinf(X) && !std::isinf(Y) && !std::isinf(Z);
        }
    };

    namespace Game
    {
        inline Vector3 GetBonePosition(const Vector3& basePos, int boneIndex)
        {
            Vector3 pos = basePos;
            switch (boneIndex)
            {
            case 0: pos.Z += 1.6f; break;
            case 1: pos.Z += 0.9f; break;
            case 2: pos.Z += 0.1f; break;
            default: pos.Z += 0.9f; break;
            }
            return pos;
        }
    }
}
