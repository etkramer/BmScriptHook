#include "pch.h"
#include "Runtime.h"
#include "Offsets.h"
#include "Detours.h"

// Include SDK
#include "GameDefines.cpp"
#include "SDK_HEADERS/Core_classes.cpp"
#include "SDK_HEADERS/Engine_classes.cpp"

#include <detours/detours.h>

uintptr_t Runtime::BaseAddress = 0;

void Runtime::Init() {
	TRACE("Init");

	// Find base address
	BaseAddress = (uintptr_t)(GetModuleHandle(NULL));

	// Load GNames/GObjects
	GNames = (TArray<FNameEntry*>*)(BaseAddress + Offsets::GNames);
	GObjects = (TArray<UObject*>*)(BaseAddress + Offsets::GObjects);

	// Set up detours
	Detours::DetourBeginPlay();
	Detours::DetourProcessEvent();
}

BOOL APIENTRY DllMain(HMODULE hModule, DWORD ul_reason_for_call, LPVOID lpReserved) {
	switch (ul_reason_for_call) {
	case DLL_PROCESS_ATTACH:
		Runtime::Init();
		break;
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		break;
	}
	return TRUE;
}