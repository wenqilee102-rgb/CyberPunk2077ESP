#include "pch.h"
#include "ESP.h"
#include "Aimbot.h"
#include "Menu.h"
#include "GameUtils/RttiUtils.h"

using namespace directhook;

#pragma comment(lib, "dxgi.lib")

struct ImGuiD3D12Context
{
    ID3D12DescriptorHeap* FontDescriptorHeap = nullptr;
    ID3D12DescriptorHeap* RTVDescriptorHeap = nullptr;
    ID3D12CommandQueue* CommandQueue = nullptr;
    ID3D12GraphicsCommandList* CommandList = nullptr;
    std::vector<ID3D12CommandAllocator*> CommandAllocators;
    std::vector<ID3D12Resource*> BackBuffers;
    std::vector<D3D12_CPU_DESCRIPTOR_HANDLE> BackBufferDescriptors;
    UINT BufferIndex;
    UINT BufferCount;
};

static d3d12::PFN_DXGISwapChain_Present DxgiPresent = nullptr;
static WNDPROC Win32WndProc = nullptr;
static ImGuiD3D12Context Context;
static bool g_ImGuiInitialized = false;
static bool g_HookEnabled = false;
static bool g_WaitingForDebugger = true;
static bool g_D3D12HookInitialized = false;
static HANDLE g_InitThread = nullptr;
static DWORD g_LoadTime = 0;
static const DWORD g_DelayMs = 15000;

static bool CheckDebuggerOrTimeout()
{
    if (!g_WaitingForDebugger)
        return true;

    if (g_LoadTime == 0)
        g_LoadTime = GetTickCount();

    DWORD elapsed = GetTickCount() - g_LoadTime;

    if (IsDebuggerPresent())
    {
        DBG_INFO("Debugger detected! Starting hook...");
        g_WaitingForDebugger = false;
        return true;
    }

    if (GetAsyncKeyState(VK_F12) & 0x8000)
    {
        DBG_INFO("F12 pressed! Starting hook...");
        g_WaitingForDebugger = false;
        return true;
    }

    if (elapsed >= g_DelayMs)
    {
        DBG_INFO("Delay timeout (%d ms), starting hook...", g_DelayMs);
        g_WaitingForDebugger = false;
        return true;
    }

    return false;
}

extern IMGUI_IMPL_API LRESULT ImGui_ImplWin32_WndProcHandler(HWND hWnd, UINT msg, WPARAM wParam, LPARAM lParam);

static LRESULT CALLBACK MyWindowProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
    if (uMsg == WM_KEYDOWN)
    {
        if (wParam == VK_F1)
        {
            DBG_INFO("========================================");
            DBG_INFO("F1: Force re-initializing systems...");
            DBG_INFO("========================================");
            GameUtils::ForceInitialize();
        }
        else if (wParam == VK_F4)
        {
            Menu::ToggleVisibility();
        }
        else if (wParam == VK_F5)
        {
            DBG_INFO("========================================");
            DBG_INFO("F5 Debug: Entity List Analysis");
            DBG_INFO("========================================");
            ESP::DebugEntityList();
        }
        else if (wParam == VK_F3)
        {
            DBG_INFO("========================================");
            DBG_INFO("F3 Debug: Detailed System Info");
            DBG_INFO("========================================");
            DBG_INFO("RTTI Function Pointers:");
            DBG_INFO("  g_GetTargetingSystemFunc: 0x%p", GameUtils::RttiUtils::g_GetTargetingSystemFunc);
            DBG_INFO("  g_GetTargetPartsFunc: 0x%p", GameUtils::RttiUtils::g_GetTargetPartsFunc);
            DBG_INFO("  g_TargetPartGetComponentFunc: 0x%p", GameUtils::RttiUtils::g_TargetPartGetComponentFunc);
            DBG_INFO("  g_GetLocalToWorldFunc: 0x%p", GameUtils::RttiUtils::g_GetLocalToWorldFunc);
            DBG_INFO("  g_TSQ_EnemyNPCFunc: 0x%p", GameUtils::RttiUtils::g_TSQ_EnemyNPCFunc);
            DBG_INFO("  g_TSQ_ALLFunc: 0x%p", GameUtils::RttiUtils::g_TSQ_ALLFunc);
            DBG_INFO("  g_GetSlotTransformFunc: 0x%p", GameUtils::RttiUtils::g_GetSlotTransformFunc);
            DBG_INFO("  g_GetWorldPositionFunc: 0x%p", GameUtils::RttiUtils::g_GetWorldPositionFunc);
            DBG_INFO("RTTI Class Pointers:");
            DBG_INFO("  g_GameObjectClass: 0x%p", GameUtils::RttiUtils::g_GameObjectClass);
            DBG_INFO("  g_SkinnedMeshComponentClass: 0x%p", GameUtils::RttiUtils::g_SkinnedMeshComponentClass);
            DBG_INFO("  g_TargetingSystemClass: 0x%p", GameUtils::RttiUtils::g_TargetingSystemClass);
            DBG_INFO("  g_TargetPartInfoClass: 0x%p", GameUtils::RttiUtils::g_TargetPartInfoClass);
            DBG_INFO("Property Offsets:");
            DBG_INFO("  g_Entity_ComponentsStorage: 0x%p", GameUtils::RttiUtils::Properties::g_Entity_ComponentsStorage);
            DBG_INFO("  g_ScriptedPuppet_TargetingComponentsArray: 0x%p", GameUtils::RttiUtils::Properties::g_ScriptedPuppet_TargetingComponentsArray);
            DBG_INFO("  g_TargetingComponent_IsPrimary: 0x%p", GameUtils::RttiUtils::Properties::g_TargetingComponent_IsPrimary);
            DBG_INFO("Systems Initialized: %s", GameUtils::RttiUtils::g_SystemsInitialized ? "true" : "false");
            DBG_INFO("CameraSystem: 0x%p", GameUtils::RttiUtils::g_CameraSystem);
            DBG_INFO("========================================");
        }
    }

    if (ImGui_ImplWin32_WndProcHandler(hwnd, uMsg, wParam, lParam) > 0)
        return 1L;
    return ::CallWindowProcA(Win32WndProc, hwnd, uMsg, wParam, lParam);
}

static BOOL GetCommandQueueOffset(UINT& offset)
{
    OSVERSIONINFOEXW osInfo{};
    osInfo.dwOSVersionInfoSize = sizeof(OSVERSIONINFOEXW);
    typedef LONG(WINAPI* RtlGetVersionPtr)(OSVERSIONINFOEXW*);
    HMODULE hMod = GetModuleHandleW(L"ntdll.dll");
    if (hMod)
    {
        RtlGetVersionPtr rtlGetVersion = (RtlGetVersionPtr)GetProcAddress(hMod, "RtlGetVersion");
        if (rtlGetVersion != nullptr)
        {
            if (rtlGetVersion(&osInfo) == 0)
            {
                if (osInfo.dwBuildNumber >= 26100) offset = 0x138;
                else if (osInfo.dwBuildNumber >= 21996) offset = 0x168;
                else offset = 0x118;
                return TRUE;
            }
        }
    }
    return FALSE;
}

static HRESULT STDMETHODCALLTYPE MyPresent(IDXGISwapChain* SwapChain, UINT SyncInterval, UINT Flags)
{
    if (!CheckDebuggerOrTimeout())
    {
        return DxgiPresent(SwapChain, SyncInterval, Flags);
    }

    if (!g_HookEnabled)
    {
        g_HookEnabled = true;
        DBG_INFO("Hook enabled! Initializing...");
        DBG_INFO("========================================");
        DBG_INFO("Auto-initializing ESP systems...");
        DBG_INFO("========================================");
        GameUtils::InitializeSystems();
    }

    if (!g_ImGuiInitialized)
    {
        DXGI_SWAP_CHAIN_DESC swapchainDesc{};
        if (FAILED(SwapChain->GetDesc(&swapchainDesc)))
            return DxgiPresent(SwapChain, SyncInterval, Flags);

        Win32WndProc = (WNDPROC)::SetWindowLongPtr(swapchainDesc.OutputWindow, GWLP_WNDPROC, reinterpret_cast<LONG_PTR>(MyWindowProc));

        ID3D12Device* device = nullptr;
        if (FAILED(SwapChain->GetDevice(IID_PPV_ARGS(&device))))
            return DxgiPresent(SwapChain, SyncInterval, Flags);

        if (!Context.CommandQueue)
        {
            UINT queueOffset;
            if (GetCommandQueueOffset(queueOffset))
            {
                Context.CommandQueue = *reinterpret_cast<ID3D12CommandQueue**>((uintptr_t)SwapChain + queueOffset);
                DBG_INFO("CommandQueue: 0x%p", Context.CommandQueue);
            }
        }

        D3D12_DESCRIPTOR_HEAP_DESC fontHeapDesc{};
        fontHeapDesc.NumDescriptors = 1;
        fontHeapDesc.Type = D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV;
        fontHeapDesc.Flags = D3D12_DESCRIPTOR_HEAP_FLAG_SHADER_VISIBLE;
        fontHeapDesc.NodeMask = 0;
        if (FAILED(device->CreateDescriptorHeap(&fontHeapDesc, IID_PPV_ARGS(&Context.FontDescriptorHeap))))
        {
            DBG_ERROR("Failed to create font descriptor heap");
            return DxgiPresent(SwapChain, SyncInterval, Flags);
        }

        IDXGISwapChain3* SwapChain3 = nullptr;
        if (FAILED(SwapChain->QueryInterface(&SwapChain3)))
            return DxgiPresent(SwapChain, SyncInterval, Flags);

        Context.BufferIndex = SwapChain3->GetCurrentBackBufferIndex();
        Context.BufferCount = swapchainDesc.BufferCount;

        D3D12_DESCRIPTOR_HEAP_DESC rtvHeapDesc{};
        rtvHeapDesc.Type = D3D12_DESCRIPTOR_HEAP_TYPE_RTV;
        rtvHeapDesc.NumDescriptors = Context.BufferCount;
        rtvHeapDesc.Flags = D3D12_DESCRIPTOR_HEAP_FLAG_NONE;

        if (device->CreateDescriptorHeap(&rtvHeapDesc, IID_PPV_ARGS(&Context.RTVDescriptorHeap)) != S_OK)
            return DxgiPresent(SwapChain, SyncInterval, Flags);

        Context.BackBuffers.resize(Context.BufferCount);
        Context.BackBufferDescriptors.resize(Context.BufferCount);
        UINT rtvDescriptorSize = device->GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE_RTV);
        D3D12_CPU_DESCRIPTOR_HANDLE rtvHandle = Context.RTVDescriptorHeap->GetCPUDescriptorHandleForHeapStart();
        for (UINT i = 0; i < Context.BufferCount; i++)
        {
            Context.BackBufferDescriptors[i] = rtvHandle;
            SwapChain->GetBuffer(i, IID_PPV_ARGS(&Context.BackBuffers[i]));
            device->CreateRenderTargetView(Context.BackBuffers[i], nullptr, rtvHandle);
            rtvHandle.ptr += rtvDescriptorSize;
        }

        Context.CommandAllocators.resize(Context.BufferCount);
        for (UINT i = 0; i < Context.BufferCount; ++i)
        {
            if (FAILED(device->CreateCommandAllocator(D3D12_COMMAND_LIST_TYPE_DIRECT, IID_PPV_ARGS(&Context.CommandAllocators[i]))))
                return DxgiPresent(SwapChain, SyncInterval, Flags);
        }

        if (FAILED(device->CreateCommandList(0, D3D12_COMMAND_LIST_TYPE_DIRECT, Context.CommandAllocators[0], nullptr, IID_PPV_ARGS(&Context.CommandList))))
            return DxgiPresent(SwapChain, SyncInterval, Flags);

        D3D12_CPU_DESCRIPTOR_HANDLE cpuHandle = Context.FontDescriptorHeap->GetCPUDescriptorHandleForHeapStart();
        D3D12_GPU_DESCRIPTOR_HANDLE gpuHandle = Context.FontDescriptorHeap->GetGPUDescriptorHandleForHeapStart();
        ImGui::CreateContext();
        ImGui_ImplWin32_Init(swapchainDesc.OutputWindow);
        ImGui_ImplDX12_InitInfo init_info;
        init_info.Device = device;
        init_info.NumFramesInFlight = swapchainDesc.BufferCount;
        init_info.RTVFormat = swapchainDesc.BufferDesc.Format;
        init_info.SrvDescriptorHeap = Context.FontDescriptorHeap;
        init_info.LegacySingleSrvCpuDescriptor = cpuHandle;
        init_info.LegacySingleSrvGpuDescriptor = gpuHandle;
        init_info.CommandQueue = Context.CommandQueue;
        ImGui_ImplDX12_Init(&init_info);
        g_ImGuiInitialized = true;
        DBG_INFO("ImGui initialized successfully");
    }

    if (!Context.CommandQueue)
        return DxgiPresent(SwapChain, SyncInterval, Flags);

    ImGui_ImplDX12_NewFrame();
    ImGui_ImplWin32_NewFrame();
    ImGui::NewFrame();

    ImGuiIO& io = ImGui::GetIO();
    float screenWidth = io.DisplaySize.x;
    float screenHeight = io.DisplaySize.y;

    ImDrawList* drawList = ImGui::GetBackgroundDrawList();
    
    ESP::DrawESP(drawList, screenWidth, screenHeight);
    Aimbot::Update(screenWidth, screenHeight);
    Aimbot::DrawFOVCircle(drawList, screenWidth, screenHeight);
    Aimbot::DrawTargetIndicator(drawList, screenWidth, screenHeight);
    ESP::DrawTargetingDebugInfo(drawList);

    if (Menu::IsVisible())
    {
        io.MouseDrawCursor = true;
        io.ConfigFlags &= ~ImGuiConfigFlags_NoMouseCursorChange;
    }
    else
    {
        io.MouseDrawCursor = false;
        io.ConfigFlags |= ImGuiConfigFlags_NoMouseCursorChange;
    }

    ImGui::SetNextWindowPos(ImVec2(10, 10), ImGuiCond_Always);
    ImGui::SetNextWindowSize(ImVec2(280, 60), ImGuiCond_Always);
    ImGui::PushStyleColor(ImGuiCol_WindowBg, ImVec4(0.0f, 0.0f, 0.0f, 0.7f));
    ImGui::PushStyleVar(ImGuiStyleVar_WindowBorderSize, 0.0f);

    if (ImGui::Begin("##Status", nullptr, ImGuiWindowFlags_NoTitleBar | ImGuiWindowFlags_NoResize | ImGuiWindowFlags_NoMove | ImGuiWindowFlags_NoScrollbar))
    {
        ImGui::TextColored(ImVec4(0.0f, 1.0f, 0.0f, 1.0f), "SUCCESS!");
        ImGui::Text("F4 Menu | F1 Re-init | Cached: %d | Visible: %d", ESP::g_CachedEntityCount, ESP::g_VisibleEntityCount);
        ImGui::End();
    }

    ImGui::PopStyleVar();
    ImGui::PopStyleColor();

    Menu::Render();

    ImGui::Render();

    D3D12_RESOURCE_BARRIER Barrier;
    Barrier.Type = D3D12_RESOURCE_BARRIER_TYPE_TRANSITION;
    Barrier.Flags = D3D12_RESOURCE_BARRIER_FLAG_NONE;
    Barrier.Transition.pResource = Context.BackBuffers[Context.BufferIndex];
    Barrier.Transition.Subresource = D3D12_RESOURCE_BARRIER_ALL_SUBRESOURCES;
    Barrier.Transition.StateBefore = D3D12_RESOURCE_STATE_PRESENT;
    Barrier.Transition.StateAfter = D3D12_RESOURCE_STATE_RENDER_TARGET;
    Context.CommandList->ResourceBarrier(1, &Barrier);

    Context.CommandList->OMSetRenderTargets(1, &Context.BackBufferDescriptors[Context.BufferIndex], FALSE, nullptr);
    Context.CommandList->SetDescriptorHeaps(1, &Context.FontDescriptorHeap);
    ImGui_ImplDX12_RenderDrawData(ImGui::GetDrawData(), Context.CommandList);

    Barrier.Transition.StateBefore = D3D12_RESOURCE_STATE_RENDER_TARGET;
    Barrier.Transition.StateAfter = D3D12_RESOURCE_STATE_PRESENT;
    Context.CommandList->ResourceBarrier(1, &Barrier);

    Context.CommandList->Close();
    Context.CommandQueue->ExecuteCommandLists(1, reinterpret_cast<ID3D12CommandList* const*>(&Context.CommandList));
    Context.CommandAllocators[Context.BufferIndex]->Reset();
    Context.CommandList->Reset(Context.CommandAllocators[Context.BufferIndex], nullptr);

    Context.BufferIndex = (Context.BufferIndex + 1) % Context.BufferCount;
    return DxgiPresent(SwapChain, SyncInterval, Flags);
}

static bool InitializeD3D12Hook()
{
    DBG_INFO("Initializing D3D12 hook...");

    HMODULE d3d12 = GetModuleHandleW(L"d3d12.dll");
    HMODULE dxgi = GetModuleHandleW(L"dxgi.dll");

    if (!d3d12 || !dxgi)
    {
        DBG_ERROR("D3D12 or DXGI not loaded yet");
        return false;
    }

    DH_Status dh = DH_Initialize();
    if (dh != DH_Status::Success)
    {
        DBG_ERROR("DH_Initialize failed with status: %d", (int)dh);
        return false;
    }

    DBG_INFO("DirectHook initialized");
    Hook(d3d12::SwapChain_Present, DxgiPresent, MyPresent);
    DBG_INFO("Present hook installed");
    return true;
}

static DWORD WINAPI InitThreadProc(LPVOID lpParameter)
{
    DBG_INFO("Init thread started, waiting for D3D12/DXGI...");

    int attempts = 0;
    while (!g_D3D12HookInitialized && attempts < 300)
    {
        if (InitializeD3D12Hook())
        {
            g_D3D12HookInitialized = true;
            DBG_INFO("D3D12 hook initialized successfully!");
            break;
        }

        Sleep(100);
        attempts++;

        if (attempts % 10 == 0)
        {
            DBG_INFO("Still waiting for D3D12/DXGI... (%d seconds)", attempts / 10);
        }
    }

    if (!g_D3D12HookInitialized)
    {
        DBG_ERROR("Failed to initialize D3D12 hook after 30 seconds");
    }

    return 0;
}

static void Cleanup()
{
    if (g_InitThread)
    {
        TerminateThread(g_InitThread, 0);
        CloseHandle(g_InitThread);
        g_InitThread = nullptr;
    }

    ImGui_ImplDX12_Shutdown();
    ImGui_ImplWin32_Shutdown();
    ImGui::DestroyContext();

    for (auto& buffer : Context.BackBuffers)
    {
        if (buffer) buffer->Release();
    }
    Context.BackBuffers.clear();

    for (auto& allocator : Context.CommandAllocators)
    {
        if (allocator) allocator->Release();
    }
    Context.CommandAllocators.clear();

    if (Context.CommandList)
    {
        Context.CommandList->Release();
        Context.CommandList = nullptr;
    }

    if (Context.RTVDescriptorHeap)
    {
        Context.RTVDescriptorHeap->Release();
        Context.RTVDescriptorHeap = nullptr;
    }

    if (Context.FontDescriptorHeap)
    {
        Context.FontDescriptorHeap->Release();
        Context.FontDescriptorHeap = nullptr;
    }

    if (g_D3D12HookInitialized)
    {
        DH_Shutdown();
    }
}

RED4EXT_C_EXPORT bool RED4EXT_CALL Main(RED4ext::PluginHandle aHandle, RED4ext::EMainReason aReason, const RED4ext::Sdk* aSdk)
{
    switch (aReason)
    {
    case RED4ext::EMainReason::Load:
    {
        DebugConsole::Instance().Initialize("2077ESP Debug Console");
        DBG_INFO("2077ESP plugin loaded");
        DBG_INFO("Plugin handle: 0x%p", aHandle);
        DBG_INFO("========================================");
        DBG_INFO("Waiting for debugger or timeout...");
        DBG_INFO("- Attach debugger now, or");
        DBG_INFO("- Press F12 to start immediately, or");
        DBG_INFO("- Wait %d seconds for auto-start", g_DelayMs / 1000);
        DBG_INFO("========================================");

        g_InitThread = CreateThread(nullptr, 0, InitThreadProc, nullptr, 0, nullptr);
        if (!g_InitThread)
        {
            DBG_ERROR("Failed to create init thread");
            return false;
        }

        break;
    }
    case RED4ext::EMainReason::Unload:
    {
        DBG_INFO("2077ESP plugin unloading...");
        Cleanup();
        DebugConsole::Instance().Shutdown();
        break;
    }
    }
    return true;
}

RED4EXT_C_EXPORT bool RED4EXT_CALL Query(RED4ext::PluginInfo* aInfo)
{
    aInfo->name = L"2077ESP";
    aInfo->author = L"2077ESP";
    aInfo->version = RED4EXT_SEMVER(1, 0, 0);
    aInfo->runtime = RED4EXT_RUNTIME_LATEST;
    aInfo->sdk = RED4EXT_SDK_LATEST;
    return true;
}

RED4EXT_C_EXPORT uint32_t RED4EXT_CALL Supports()
{
    return RED4EXT_API_VERSION_LATEST;
}