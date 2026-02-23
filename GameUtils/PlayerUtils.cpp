#include "pch.h"
#include "PlayerUtils.h"

namespace GameUtils
{
    Utils::Vector3 g_PlayerPosition(0, 0, 0);
    bool g_PlayerPosValid = false;
    RED4ext::Handle<RED4ext::IScriptable> g_PlayerHandle;

    namespace PlayerUtils
    {
        void UpdatePlayerPosition()
        {
            g_PlayerPosValid = false;

            if (!g_PlayerHandle.GetPtr())
            {
                auto rtti = RED4ext::CRTTISystem::Get();
                if (!rtti) return;

                auto engine = RED4ext::CGameEngine::Get();
                if (!engine || !engine->framework || !engine->framework->gameInstance) return;

                auto gameInstance = engine->framework->gameInstance;

                auto cpPlayerSystemClass = rtti->GetClass("cpPlayerSystem");
                if (!cpPlayerSystemClass) return;

                auto playerSystem = gameInstance->GetSystem(cpPlayerSystemClass);
                if (!playerSystem) return;

                auto getLocalPlayerFunc = cpPlayerSystemClass->GetFunction(RED4ext::CName("GetLocalPlayerMainGameObject"));
                if (!getLocalPlayerFunc) return;

                RED4ext::Handle<RED4ext::IScriptable> playerHandle;
                RED4ext::CStackType resultType;
                resultType.type = rtti->GetType("handle:gameObject");
                resultType.value = &playerHandle;

                RED4ext::CStack stack(playerSystem, nullptr, 0, &resultType);
                getLocalPlayerFunc->Execute(&stack);

                auto ptr = playerHandle.GetPtr();
                
                if (ptr != nullptr && Utils::IsValidPtr(ptr))
                {
                    g_PlayerHandle = playerHandle;
                }
                else
                {
                    return;
                }
            }

            auto puppet = g_PlayerHandle.GetPtr();
            if (!Utils::IsValidPtr(puppet))
            {
                g_PlayerHandle.Reset();
                return;
            }

            g_PlayerPosition = EntityUtils::GetEntityPosition(puppet);

            if (g_PlayerPosition.IsValid() &&
                (g_PlayerPosition.X != 0.0f || g_PlayerPosition.Y != 0.0f || g_PlayerPosition.Z != 0.0f))
            {
                g_PlayerPosValid = true;
            }
            else
            {
                g_PlayerHandle.Reset();
            }
        }
    }
}