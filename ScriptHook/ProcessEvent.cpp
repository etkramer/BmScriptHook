#include "pch.h"
#include "Detours.h"
#include "Offsets.h"
#include "Runtime.h"
#include "Functions.h"

#include "SdkHeaders.hpp"

DECLARE_DETOUR(ProcessEvent, void, UObject*, void*, UFunction*, void*, void*)

static void __fastcall ProcessEventDetour(UObject* pThis, void* unk, UFunction* Function, void* Parms, void* Result) {
	// Called on first load
	if (Function->GetFullName() == "Function BmGame.RGameInfo.GameInProgress.BeginState") {
		TRACE("GameInProgress");

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

		// Test 4
		auto pkg = Functions::LoadPackage(NULL, L"Playable_Robin_SF", 0);
		auto robinClass = Functions::DynamicLoadObject<UClass>(L"BmScript.RPawnPlayerRobin");
		TRACE("{}", robinClass->GetName());

		// TODO: SpawnActor(robinClass)
	}

	// Called on every subsequent load
	if (Function->GetFullName() == "Function BmGame.RPlayerController.ClientReady") {
		TRACE("ClientReady");
	}

	// Call original
	ProcessEvent(pThis, unk, Function, Parms, Result);
}

void Detours::DetourProcessEvent() {
	Detours::DetourFunction(Runtime::BaseAddress + Offsets::UObject_ProcessEvent, &ProcessEvent, &ProcessEventDetour);
}