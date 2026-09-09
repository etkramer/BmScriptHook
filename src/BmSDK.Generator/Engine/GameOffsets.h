#pragma once

#include <Windows.h>
#include <cstdint>

namespace GameOffsets
{
    inline constexpr uint32_t TimeDateStampEpic = 0x5D9F84DF;
    inline constexpr uint32_t TimeDateStampSteam = 0x520000F7;

    // Globals
    inline uintptr_t GObjects = 0;
    inline uintptr_t GNames = 0;
    inline uintptr_t StaticFindObject = 0;
    inline uintptr_t LoadPackage = 0;
    inline uintptr_t CollectGarbage = 0;

    // Identifies the build from the PE header's TimeDateStamp
    inline bool Init(uintptr_t baseAddress)
    {
        auto dosHeader = (PIMAGE_DOS_HEADER)baseAddress;
        auto ntHeaders = (PIMAGE_NT_HEADERS32)(baseAddress + dosHeader->e_lfanew);

        switch (ntHeaders->FileHeader.TimeDateStamp)
        {
            case TimeDateStampEpic:
                GObjects = 0x122E900;
                GNames = 0x11EC5E8;
                StaticFindObject = 0x8ED20;
                LoadPackage = 0x9FCA0;
                CollectGarbage = 0xAF0C0;
                return true;
            case TimeDateStampSteam:
                GObjects = 0x1243CE0;
                GNames = 0x12019C8;
                StaticFindObject = 0x8F3A0;
                LoadPackage = 0xA06D0;
                CollectGarbage = 0xAF980;
                return true;
            default:
                return false;
        }
    }
}
