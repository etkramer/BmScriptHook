#define WIN32_LEAN_AND_MEAN
#include <windows.h>
#include <string>

#include "GameDefines.cpp"
#include "SDK_HEADERS/Core_classes.cpp"
#include "SDK_HEADERS/Engine_classes.cpp"

using namespace std;

static DWORD WINAPI init(LPVOID lpParam) {
	Sleep(5000);
	OutputDebugStringA("HOOK INIT\n");

	// Find base address
	auto baseAddress = (uintptr_t)(GetModuleHandle(NULL));

	// Load GNames/GObjects
	GNames = (TArray<FNameEntry*>*)(baseAddress + GNames_Offset);
	GObjects = (TArray<UObject*>*)(baseAddress + GObjects_Offset);

	// Call an instance fn
	auto obj = GObjects->at(20);
	auto message = format("Object {} is from package {}\n", obj->GetName(), obj->GetPackageName().ToString());
	OutputDebugStringA(message.c_str());

	// Call a static fn
	auto worldInfo = UEngine::GetCurrentWorldInfo();
	auto message2 = format("World (from {}) has gravity {}\n", worldInfo->GetPackageName().ToString(), worldInfo->WorldGravityZ);
	OutputDebugStringA(message2.c_str());

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
