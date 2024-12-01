#include "pch.h"
#include "Detours.h"
#include "Offsets.h"
#include "Runtime.h"

DECLARE_DETOUR(ProcessEvent, void, UObject*, void*, UFunction*, void*, void*)

static void __fastcall ProcessEventDetour(UObject* pThis, void* unk, UFunction* Function, void* Parms, void* Result) {
	// Called on menu ready
	if (Function->GetFullName() == "Function BmGame.RGameInfo.GameInProgress.BeginState") {
		TRACE("GameInProgress");
	}

	// Called when in-game
	if (Function->GetFullName() == "Function BmGame.RPlayerController.ClientReady") {
		TRACE("ClientReady");
	}

	// Call original
	ProcessEvent(pThis, unk, Function, Parms, Result);
}

void Detours::DetourProcessEvent() {
	Detours::DetourFunction(Runtime::BaseAddress + Offsets::UObject_ProcessEvent, &ProcessEvent, &ProcessEventDetour);
}