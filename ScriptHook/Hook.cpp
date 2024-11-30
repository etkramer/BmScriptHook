#include "Shared.h"
#include "Hook.h"

// Include SDK
#include "GameDefines.cpp"
#include "SDK_HEADERS/Core_classes.cpp"
#include "SDK_HEADERS/Engine_classes.cpp"

void Hook::Init() {
	TRACE("Init");

	// Find base address
	auto baseAddress = (uintptr_t)(GetModuleHandle(NULL));

	// Load GNames/GObjects
	GNames = (TArray<FNameEntry*>*)(baseAddress + GNames_Offset);
	GObjects = (TArray<UObject*>*)(baseAddress + GObjects_Offset);

	// Test some stuff
	RunTests();
}

void Hook::RunTests() {
	// Call an instance fn
	auto obj = UObject::GObjObjects()->at(20);
	TRACE("Object {} is from package {}", obj->GetName(), obj->GetPackageName().ToString());

	// Call a static fn
	auto worldInfo = UEngine::GetCurrentWorldInfo();
	TRACE("World (from {}) has gravity {}", worldInfo->GetPackageName().ToString(), worldInfo->WorldGravityZ);
}