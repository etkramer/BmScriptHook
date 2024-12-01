#pragma once
#include <cstdint>
#include <GameDefines.hpp>

class Offsets {
private:
    Offsets() = delete;

public:
    // Globals
    static const uintptr_t GNames = GNames_Offset;
    static const uintptr_t GObjects = GObjects_Offset;

    // Functions
    static const uintptr_t UWorld_BeginPlay = 0x008AEE10 - 0x400000;
    static const uintptr_t UObject_ProcessEvent = 0x00446A60 - 0x400000;
};