#pragma once

#include "GameUtils/GameUtils.h"

namespace ESP
{
    namespace ESPSettings
    {
        extern bool g_Enabled;
        extern bool g_ShowBox;
        extern bool g_ShowDot;
        extern bool g_ShowCivilian;
        extern bool g_ShowPolice;
        extern bool g_ShowGanger;
        extern bool g_ShowCyberpsycho;
        extern bool g_ShowOther;
        extern bool g_ShowDead;
        extern float g_MaxDistance;
        extern bool g_DebugMode;
    }

    struct CachedEntity
    {
        void* EntityPtr;
        Utils::Vector3 Position;
        float Distance;
        bool IsValid;
        bool IsDead;
        float Height;
        float Width;
        bool IsCivilian;
        bool IsPolice;
        bool IsGanger;
        bool IsCyberpsycho;
        char TypeName[128];
        char InheritancePath[512];
    };
    extern CachedEntity g_CachedEntities[128];
    extern int g_CachedEntityCount;
    extern int g_VisibleEntityCount;
    extern int g_FrameCount;
    extern const int g_CacheUpdateInterval;

    void DrawESPBox(ImDrawList* drawList, const Utils::Vector3& pos, float height, float distance, 
                   float screenWidth, float screenHeight, ImU32 color);
    void DrawESPDot(ImDrawList* drawList, const Utils::Vector3& pos, float distance, 
                   float screenWidth, float screenHeight, ImU32 color);
    void UpdateEntityCache();
    void DrawESP(ImDrawList* drawList, float screenWidth, float screenHeight);
    void GetAndPrintNearestNPCs(int maxCount = 20);
    void DebugEntityList();
}
