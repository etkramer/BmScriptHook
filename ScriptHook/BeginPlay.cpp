#include "pch.h"
#include "Detours.h"
#include "Offsets.h"
#include "Runtime.h"
#include "Functions.h"

#include "SdkHeaders.hpp"

DECLARE_DETOUR(BeginPlay, void, UWorld*, void*, FURL&, BOOL)

static void __fastcall BeginPlayDetour(UWorld* pThis, void* unk, FURL& InURL, BOOL bResetTime) {
	TRACE("EVENT: BeginPlay");

	// Call original
	BeginPlay(pThis, unk, InURL, bResetTime);

	static bool isFirstRun = true;
	if (isFirstRun) {
		// Test 1 (call instance fn)
		auto obj = UObject::GObjObjects()->at(20);
		TRACE("Object {} is from package {}", obj->GetName(), obj->GetPackageName().ToString());

		// Test 2 (call static fn)
		auto worldInfo = UEngine::GetCurrentWorldInfo();
		TRACE("World (from {}) has gravity {}", worldInfo->GetPackageName().ToString(), worldInfo->WorldGravityZ);

		// Test 3 (modify object archetype)
		auto counterMove = Functions::GetDefaultObject<ARCombatMove_BatmanCounter>();
		counterMove->bShouldKill = true;
		TRACE("One-hit counters enabled");

		isFirstRun = false;
	}
}

void Detours::DetourBeginPlay() {
	Detours::DetourFunction(Runtime::BaseAddress + Offsets::UWorld_BeginPlay, &BeginPlay, &BeginPlayDetour);
}