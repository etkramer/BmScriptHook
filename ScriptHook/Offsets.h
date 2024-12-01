#pragma once

class Offsets {
private:
    Offsets() = delete;

public:
    // Globals
    static const uintptr_t GNames = 0x11EC5E8;
    static const uintptr_t GObjects = 0x122E900;

    // Functions
    static const uintptr_t UWorld_BeginPlay = 0x008AEE10 - 0x400000;
    static const uintptr_t UObject_ProcessEvent = 0x00446A60 - 0x400000;
};