#include "pch.h"
#include "Detours.h"
#include "Offsets.h"
#include "Runtime.h"

DECLARE_DETOUR(BeginPlay, void, UWorld*, void*, FURL&, BOOL)

static void __fastcall BeginPlayDetour(UWorld* pThis, void* unk, FURL& InURL, BOOL bResetTime) {
	TRACE("EVENT: BeginPlay");

	// Call original
	BeginPlay(pThis, unk, InURL, bResetTime);

	// Test 1
	auto obj = UObject::GObjObjects()->at(20);
	TRACE("Object {} is from package {}", obj->GetName(), obj->GetPackageName().ToString());

	// Test 2
	auto worldInfo = UEngine::GetCurrentWorldInfo();
	TRACE("World (from {}) has gravity {}", worldInfo->GetPackageName().ToString(), worldInfo->WorldGravityZ);
}

void Detours::DetourBeginPlay() {
	Detours::DetourFunction(Runtime::BaseAddress + Offsets::UWorld_BeginPlay, &BeginPlay, &BeginPlayDetour);
}