#define WIN32_LEAN_AND_MEAN
#include <windows.h>

#include "GameDefines.cpp"
#include "SDK_HEADERS\Core_structs.hpp"
#include "SDK_HEADERS\Core_classes.hpp"
#include "SDK_HEADERS\Core_parameters.hpp"

static DWORD WINAPI init(LPVOID lpParam) {
	Sleep(1000);
	OutputDebugStringA("HOOK INIT\n");

	// Find base address
	auto baseAddress = (uintptr_t)(GetModuleHandle(NULL));

	// Load GNames/GObjects
	GNames = (TArray<FNameEntry*>*)(baseAddress + GNames_Offset);
	GObjects = (TArray<UObject*>*)(baseAddress + GObjects_Offset);

	return 0;
}

BOOL APIENTRY DllMain(HMODULE hModule, DWORD ul_reason_for_call, LPVOID lpReserved) {
	switch (ul_reason_for_call) {
	case DLL_PROCESS_ATTACH:
		CreateThread(NULL, NULL, &init, NULL, NULL, NULL);
		break;
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		break;
	}
	return TRUE;
}
