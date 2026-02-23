#include "pch.h"
#include "CameraUtils.h"

namespace GameUtils
{
    namespace CameraUtils
    {
        bool WorldToScreenWithDepth(const Utils::Vector3& worldPos, ImVec2& screenPos, float& depth, float screenWidth, float screenHeight)
        {
            if (!Utils::IsValidPtr(RttiUtils::g_CameraSystem))
                return false;

            auto camera = static_cast<RED4ext::IScriptable*>(RttiUtils::g_CameraSystem);
            auto cameraSystemClass = camera->GetNativeType();
            if (!Utils::IsValidPtr(cameraSystemClass))
                return false;

            auto projectPointFunc = cameraSystemClass->GetFunction(RED4ext::CName("ProjectPoint"));
            if (!Utils::IsValidPtr(projectPointFunc))
                return false;

            auto rtti = RED4ext::CRTTISystem::Get();
            if (!Utils::IsValidPtr(rtti))
                return false;

            Utils::Vector4 worldPos4(worldPos.X, worldPos.Y, worldPos.Z, 1.0f);
            Utils::Vector4 screenResult;

            RED4ext::CStackType args[1];
            args[0].type = rtti->GetType("Vector4");
            args[0].value = &worldPos4;

            RED4ext::CStackType resultType;
            resultType.type = rtti->GetType("Vector4");
            resultType.value = &screenResult;

            RED4ext::CStack stack(camera, args, 1, &resultType);
            projectPointFunc->Execute(&stack);

            if (std::isnan(screenResult.X) || std::isnan(screenResult.Y))
                return false;

            depth = screenResult.Z;

            if (depth < 0.0f)
                return false;

            screenPos.x = (screenResult.X + 1.0f) * 0.5f * screenWidth;
            screenPos.y = (1.0f - screenResult.Y) * 0.5f * screenHeight;

            return screenPos.x >= 0 && screenPos.x <= screenWidth && 
                   screenPos.y >= 0 && screenPos.y <= screenHeight;
        }

        bool WorldToScreen(const Utils::Vector3& worldPos, ImVec2& screenPos, float screenWidth, float screenHeight)
        {
            float depth;
            return WorldToScreenWithDepth(worldPos, screenPos, depth, screenWidth, screenHeight);
        }

        float GetDistanceToCrosshair(const Utils::Vector3& worldPos, float screenWidth, float screenHeight)
        {
            ImVec2 screenPos;
            if (!WorldToScreen(worldPos, screenPos, screenWidth, screenHeight))
                return FLT_MAX;

            float centerX = screenWidth * 0.5f;
            float centerY = screenHeight * 0.5f;

            float dx = screenPos.x - centerX;
            float dy = screenPos.y - centerY;

            return sqrtf(dx * dx + dy * dy);
        }

        bool IsInFieldOfView(const Utils::Vector3& worldPos, float screenWidth, float screenHeight)
        {
            if (!Utils::IsValidPtr(RttiUtils::g_CameraSystem))
                return true;

            auto camera = static_cast<RED4ext::IScriptable*>(RttiUtils::g_CameraSystem);
            auto cameraSystemClass = camera->GetNativeType();
            if (!Utils::IsValidPtr(cameraSystemClass))
                return true;

            auto projectPointFunc = cameraSystemClass->GetFunction(RED4ext::CName("ProjectPoint"));
            if (!Utils::IsValidPtr(projectPointFunc))
                return true;

            auto rtti = RED4ext::CRTTISystem::Get();
            if (!Utils::IsValidPtr(rtti))
                return true;

            Utils::Vector4 worldPos4(worldPos.X, worldPos.Y, worldPos.Z, 1.0f);
            Utils::Vector4 screenResult;

            RED4ext::CStackType args[1];
            args[0].type = rtti->GetType("Vector4");
            args[0].value = &worldPos4;

            RED4ext::CStackType resultType;
            resultType.type = rtti->GetType("Vector4");
            resultType.value = &screenResult;

            RED4ext::CStack stack(camera, args, 1, &resultType);
            projectPointFunc->Execute(&stack);

            if (std::isnan(screenResult.X) || std::isnan(screenResult.Y) || std::isnan(screenResult.Z))
                return false;

            if (screenResult.Z < 0.0f)
                return false;

            return true;
        }
    }
}
