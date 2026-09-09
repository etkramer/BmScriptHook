#include <Windows.h>

#include "Framework/offsets.h"
#include "Framework/detour_manager.h"

static void init_runtime() {
    // Bail out on unsupported builds rather than detouring a bogus address
    if (!offsets::init()) {
        return;
    }

    DetourRestoreAfterWith();
    DetourManager::RegisterEngineLoopPreInitDetour();
}

BOOL APIENTRY DllMain(HMODULE hModule, DWORD ul_reason_for_call, LPVOID lpReserved) {
    switch (ul_reason_for_call) {
        case DLL_PROCESS_ATTACH:
            init_runtime();
            break;
        case DLL_THREAD_ATTACH:
        case DLL_THREAD_DETACH:
        case DLL_PROCESS_DETACH:
            break;
    }
    return TRUE;
}
