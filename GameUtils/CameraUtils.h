#pragma once

#include "../pch.h"
#include "RttiUtils.h"

namespace GameUtils
{
    namespace CameraUtils
    {
        bool WorldToScreen(const Utils::Vector3& worldPos, ImVec2& screenPos, float screenWidth, float screenHeight);
        bool WorldToScreenWithDepth(const Utils::Vector3& worldPos, ImVec2& screenPos, float& depth, float screenWidth, float screenHeight);
        float GetDistanceToCrosshair(const Utils::Vector3& worldPos, float screenWidth, float screenHeight);
        bool IsInFieldOfView(const Utils::Vector3& worldPos, float screenWidth, float screenHeight);
    }
}
