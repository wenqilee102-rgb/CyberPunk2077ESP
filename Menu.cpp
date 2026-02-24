#include "pch.h"
#include "Menu.h"
#include "ESP.h"
#include "Aimbot.h"

namespace Menu
{
    bool g_MenuVisible = false;

    void Initialize()
    {
        DBG_INFO("Menu initialized");
    }

    void ToggleVisibility()
    {
        g_MenuVisible = !g_MenuVisible;
        DBG_INFO("Menu %s", g_MenuVisible ? "shown" : "hidden");
    }

    bool IsVisible()
    {
        return g_MenuVisible;
    }

    void Render()
    {
        if (!g_MenuVisible)
            return;

        ImGui::SetNextWindowPos(ImVec2(300, 10), ImGuiCond_FirstUseEver);
        ImGui::SetNextWindowSize(ImVec2(320, 400), ImGuiCond_FirstUseEver);
        
        if (ImGui::Begin("2077ESP Menu", &g_MenuVisible, 0))
        {
            if (ImGui::CollapsingHeader("ESP", ImGuiTreeNodeFlags_DefaultOpen))
            {
                ImGui::Checkbox("Enable ESP", &ESP::ESPSettings::g_Enabled);
                ImGui::SameLine();
                ImGui::TextColored(ESP::ESPSettings::g_Enabled ? ImVec4(0,1,0,1) : ImVec4(1,0,0,1), 
                    "%s", ESP::ESPSettings::g_Enabled ? "ON" : "OFF");
                
                ImGui::Separator();
                ImGui::Checkbox("Debug Mode", &ESP::ESPSettings::g_DebugMode);
                
                ImGui::Checkbox("Show Box", &ESP::ESPSettings::g_ShowBox);
                ImGui::Checkbox("Show Dot", &ESP::ESPSettings::g_ShowDot);
                
                ImGui::Separator();
                ImGui::Text("Entity Types:");
                ImGui::Checkbox("Civilian", &ESP::ESPSettings::g_ShowCivilian);
                ImGui::Checkbox("Police", &ESP::ESPSettings::g_ShowPolice);
                ImGui::Checkbox("Ganger", &ESP::ESPSettings::g_ShowGanger);
                ImGui::Checkbox("Cyberpsycho", &ESP::ESPSettings::g_ShowCyberpsycho);
                ImGui::Checkbox("Other", &ESP::ESPSettings::g_ShowOther);
                ImGui::Checkbox("Show Dead", &ESP::ESPSettings::g_ShowDead);
                
                ImGui::Separator();
                ImGui::SliderFloat("ESP Max Distance", &ESP::ESPSettings::g_MaxDistance, 10.0f, 500.0f, "%.0fm");
            }
            
            if (ImGui::CollapsingHeader("Aimbot"))
            {
                ImGui::Checkbox("Enable Aimbot", &Aimbot::g_Enabled);
                ImGui::SameLine();
                ImGui::TextColored(Aimbot::g_Enabled ? ImVec4(0,1,0,1) : ImVec4(1,0,0,1), 
                    "%s", Aimbot::g_Enabled ? "ON" : "OFF");
                
                ImGui::Separator();
                ImGui::SliderFloat("FOV", &Aimbot::g_FOV, 10.0f, 180.0f, "%.0f");
                ImGui::SliderFloat("Smoothness", &Aimbot::g_Smoothness, 0.0f, 1.0f, "%.2f");
                ImGui::SliderFloat("Aimbot Max Distance", &Aimbot::g_MaxDistance, 10.0f, 500.0f, "%.0fm");
                
                ImGui::Separator();
                ImGui::Checkbox("Use Targeting System", &Aimbot::g_UseTargetingSystem);
                ImGui::SameLine();
                ImGui::TextColored(Aimbot::g_UseTargetingSystem ? ImVec4(0,1,0,1) : ImVec4(1,0,0,1), 
                    "%s", Aimbot::g_UseTargetingSystem ? "ON" : "OFF");
                
                if (Aimbot::g_UseTargetingSystem)
                {
                    ImGui::Separator();
                    ImGui::TextColored(ImVec4(0.5f, 0.8f, 1.0f, 1.0f), 
                        "Targeting System Part Selection:");
                    ImGui::RadioButton("Head (Marker 4)", &Aimbot::g_TargetingSystemPart, 0);
                    ImGui::RadioButton("Chest (Marker 0/6)", &Aimbot::g_TargetingSystemPart, 1);
                    ImGui::RadioButton("Limbs (Marker 1/2/3/5)", &Aimbot::g_TargetingSystemPart, 2);
                    
                    ImGui::Separator();
                    ImGui::TextColored(ImVec4(0.7f, 0.7f, 0.7f, 1.0f), 
                        "Marker 0: Red (Base)");
                    ImGui::TextColored(ImVec4(0.7f, 0.7f, 0.7f, 1.0f), 
                        "Marker 1-6: Blue");
                    ImGui::TextColored(ImVec4(0.7f, 0.7f, 0.7f, 1.0f), 
                        "Head: Marker 4");
                    ImGui::TextColored(ImVec4(0.7f, 0.7f, 0.7f, 1.0f), 
                        "Left Hand: Marker 1");
                    ImGui::TextColored(ImVec4(0.7f, 0.7f, 0.7f, 1.0f), 
                        "Right Hand: Marker 2");
                    ImGui::TextColored(ImVec4(0.7f, 0.7f, 0.7f, 1.0f), 
                        "Left Leg: Marker 3");
                    ImGui::TextColored(ImVec4(0.7f, 0.7f, 0.7f, 1.0f), 
                        "Right Leg: Marker 5");
                    ImGui::TextColored(ImVec4(0.7f, 0.7f, 0.7f, 1.0f), 
                        "Neck: Marker 6");
                    ImGui::TextColored(ImVec4(0.7f, 0.7f, 0.7f, 1.0f), 
                        "Chest: Marker 0");
                }
                
                ImGui::Separator();
                ImGui::Text("Target Bone:");
                ImGui::RadioButton("Head", &Aimbot::g_TargetBone, 0);
                ImGui::RadioButton("Chest", &Aimbot::g_TargetBone, 1);
                ImGui::RadioButton("Feet", &Aimbot::g_TargetBone, 2);
            }
            
            ImGui::End();
        }
    }
}
