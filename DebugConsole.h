#pragma once
#include <windows.h>
#include <stdio.h>
#include <string>

class DebugConsole
{
public:
    static DebugConsole& Instance()
    {
        static DebugConsole instance;
        return instance;
    }

    bool Initialize(const char* title = "Debug Console")
    {
        if (m_initialized)
            return true;

        if (!AllocConsole())
            return false;

        SetConsoleTitleA(title);

        FILE* fp;
        freopen_s(&fp, "CONOUT$", "w", stdout);
        freopen_s(&fp, "CONOUT$", "w", stderr);
        freopen_s(&fp, "CONIN$", "r", stdin);

        SetConsoleOutputCP(CP_UTF8);
        SetConsoleCP(CP_UTF8);

        HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
        if (hConsole != INVALID_HANDLE_VALUE)
        {
            CONSOLE_SCREEN_BUFFER_INFO csbi;
            if (GetConsoleScreenBufferInfo(hConsole, &csbi))
            {
                COORD newSize;
                newSize.X = 120;
                newSize.Y = 500;
                SetConsoleScreenBufferSize(hConsole, newSize);
            }

            SMALL_RECT rect;
            rect.Left = 0;
            rect.Top = 0;
            rect.Right = 119;
            rect.Bottom = 39;
            SetConsoleWindowInfo(hConsole, TRUE, &rect);
        }

        m_stdoutHandle = hConsole;

        m_initialized = true;
        return true;
    }

    void Shutdown()
    {
        if (!m_initialized)
            return;

        fclose(stdout);
        fclose(stderr);
        fclose(stdin);

        FreeConsole();
        m_initialized = false;
    }

    void Log(const char* format, ...)
    {
        if (!m_initialized)
            return;

        va_list args;
        va_start(args, format);

        printf("[LOG] ");
        vprintf(format, args);
        printf("\n");

        va_end(args);
    }

    void LogInfo(const char* format, ...)
    {
        if (!m_initialized)
            return;

        SetConsoleTextAttribute(m_stdoutHandle, FOREGROUND_GREEN | FOREGROUND_INTENSITY);

        va_list args;
        va_start(args, format);

        printf("[INFO] ");
        vprintf(format, args);
        printf("\n");

        va_end(args);

        SetConsoleTextAttribute(m_stdoutHandle, FOREGROUND_RED | FOREGROUND_GREEN | FOREGROUND_BLUE);
    }

    void LogWarning(const char* format, ...)
    {
        if (!m_initialized)
            return;

        SetConsoleTextAttribute(m_stdoutHandle, FOREGROUND_RED | FOREGROUND_GREEN | FOREGROUND_INTENSITY);

        va_list args;
        va_start(args, format);

        printf("[WARN] ");
        vprintf(format, args);
        printf("\n");

        va_end(args);

        SetConsoleTextAttribute(m_stdoutHandle, FOREGROUND_RED | FOREGROUND_GREEN | FOREGROUND_BLUE);
    }

    void LogError(const char* format, ...)
    {
        if (!m_initialized)
            return;

        SetConsoleTextAttribute(m_stdoutHandle, FOREGROUND_RED | FOREGROUND_INTENSITY);

        va_list args;
        va_start(args, format);

        printf("[ERROR] ");
        vprintf(format, args);
        printf("\n");

        va_end(args);

        SetConsoleTextAttribute(m_stdoutHandle, FOREGROUND_RED | FOREGROUND_GREEN | FOREGROUND_BLUE);
    }

    void LogDebug(const char* format, ...)
    {
        if (!m_initialized)
            return;

        SetConsoleTextAttribute(m_stdoutHandle, FOREGROUND_BLUE | FOREGROUND_GREEN | FOREGROUND_INTENSITY);

        va_list args;
        va_start(args, format);

        printf("[DEBUG] ");
        vprintf(format, args);
        printf("\n");

        va_end(args);

        SetConsoleTextAttribute(m_stdoutHandle, FOREGROUND_RED | FOREGROUND_GREEN | FOREGROUND_BLUE);
    }

    void Clear()
    {
        if (!m_initialized)
            return;

        system("cls");
    }

    bool IsInitialized() const { return m_initialized; }

private:
    DebugConsole() : m_initialized(false), m_stdoutHandle(nullptr) {}
    ~DebugConsole() { Shutdown(); }

    DebugConsole(const DebugConsole&) = delete;
    DebugConsole& operator=(const DebugConsole&) = delete;

    bool m_initialized;
    HANDLE m_stdoutHandle;
};

#define DBG_LOG(...) DebugConsole::Instance().Log(__VA_ARGS__)
#define DBG_INFO(...) DebugConsole::Instance().LogInfo(__VA_ARGS__)
#define DBG_WARN(...) DebugConsole::Instance().LogWarning(__VA_ARGS__)
#define DBG_ERROR(...) DebugConsole::Instance().LogError(__VA_ARGS__)
#define DBG_DEBUG(...) DebugConsole::Instance().LogDebug(__VA_ARGS__)
