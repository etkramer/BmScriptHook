#pragma once

class Offsets {
private:
    Offsets() = delete;

public:
    // Globals
    static const uintptr_t GNames = 0x11EC5E8;
    static const uintptr_t GObjects = 0x122E900;
    static const uintptr_t GWorld = 0x124F520;

    // Functions
    static const uintptr_t UObject_ProcessEvent = 0x00446A60 - 0x400000;
    static const uintptr_t UObject_LoadPackage = 0x0049FCA0 - 0x400000;
    static const uintptr_t UClass_GetDefaultObject = 0x0044C8E0 - 0x400000;
};