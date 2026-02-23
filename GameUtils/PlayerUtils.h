#pragma once

#include "../pch.h"
#include "EntityUtils.h"

namespace GameUtils
{
    extern Utils::Vector3 g_PlayerPosition;
    extern bool g_PlayerPosValid;
    extern RED4ext::Handle<RED4ext::IScriptable> g_PlayerHandle;

    namespace PlayerUtils
    {
        void UpdatePlayerPosition();
    }
}
