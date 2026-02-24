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

    struct EntityData
    {
        void* EntityPtr = nullptr;
        Utils::Vector3 Position{};
        float Distance = 0.0f;
        bool IsValid = false;
        
        bool IsDead = false;
        int DeathFlag = 0;
        uint32_t DeathCheckFrame = 0;
        
        float Height = 0.0f;
        float Width = 0.0f;
        
        bool IsCivilian = false;
        bool IsPolice = false;
        bool IsGanger = false;
        bool IsCyberpsycho = false;
        
        int TargetingPartIndex = 0;
        uint32_t TargetingCheckFrame = 0;
        
        char TypeName[128] = {};
        char InheritancePath[512] = {};
        
        bool IsStructureValid() const
        {
            if (!IsValid) return false;
            if (!Utils::IsValidPtr(EntityPtr)) return false;
            uintptr_t ptr = reinterpret_cast<uintptr_t>(EntityPtr);
            if (ptr < 0x10000) return false;
            
            uintptr_t* vtable = *reinterpret_cast<uintptr_t**>(EntityPtr);
            if (!Utils::IsValidPtr(vtable)) return false;
            
            return Position.IsValid();
        }
        
        void Reset()
        {
            EntityPtr = nullptr;
            Position = Utils::Vector3{};
            Distance = 0.0f;
            IsValid = false;
            IsDead = false;
            DeathFlag = 0;
            DeathCheckFrame = 0;
            Height = 0.0f;
            Width = 0.0f;
            IsCivilian = false;
            IsPolice = false;
            IsGanger = false;
            IsCyberpsycho = false;
            TargetingPartIndex = 0;
            TargetingCheckFrame = 0;
            TypeName[0] = '\0';
            InheritancePath[0] = '\0';
        }
    };
    extern int g_CachedEntityCount;
    extern int g_VisibleEntityCount;
    extern int g_FrameCount;
    extern const int g_CacheUpdateInterval;

    struct EntityCache
    {
        EntityData Entities[500];
        int EntityCount = 0;
        uint32_t UpdateFrame = 0;
        
        void Reset()
        {
            EntityCount = 0;
            UpdateFrame = 0;
            for (int i = 0; i < 500; i++)
            {
                Entities[i].Reset();
            }
        }
    };
    extern EntityCache g_EntityCache;

    struct EntityCacheBuffer
    {
        EntityData Entities[150];
        int EntityCount = 0;
        uint32_t UpdateFrame = 0;
        
        void Reset()
        {
            EntityCount = 0;
            UpdateFrame = 0;
            for (int i = 0; i < 150; i++)
            {
                Entities[i].Reset();
            }
        }
    };
    extern EntityCacheBuffer g_EntityCacheBuffers[2];
    extern std::atomic<int> g_CurrentReadBufferIndex;

    struct TargetingDebugInfo
    {
        void* EntityPtr;
        int BoneIndex;
        int PartsCount;
        int SelectedPartIndex;
        bool IsValid;
        char PartsInfo[512];
    };
    extern TargetingDebugInfo g_TargetingDebugInfo;

    void DrawESPBox(ImDrawList* drawList, const Utils::Vector3& pos, float height, float distance, 
                   float screenWidth, float screenHeight, ImU32 color);
    void DrawESPDot(ImDrawList* drawList, const Utils::Vector3& pos, float distance, 
                   float screenWidth, float screenHeight, ImU32 color);
    void UpdateEntityCache();
    void DrawESP(ImDrawList* drawList, float screenWidth, float screenHeight);
    void GetAndPrintNearestNPCs(int maxCount = 20);
    void DebugEntityList();
    void DrawTargetingParts(ImDrawList* drawList, void* entity, float screenWidth, float screenHeight);
    void DrawTargetingDebugInfo(ImDrawList* drawList);
}
