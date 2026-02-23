#pragma once

namespace Menu
{
    extern bool g_MenuVisible;

    void Initialize();
    void Render();
    void ToggleVisibility();
    bool IsVisible();
}
