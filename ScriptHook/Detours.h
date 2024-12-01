#pragma once

#include <detours/detours.h>

class Detours {
private:
    Detours() = delete;

public:
    static void DetourProcessEvent();

    template <typename TFunc>
    static bool DetourFunction(uintptr_t pOrig, TFunc* pOrigRef, TFunc pDetour) {
        *pOrigRef = (TFunc)(void*)pOrig;

        DetourTransactionBegin();
        DetourAttach(&(PVOID&)*pOrigRef, pDetour);

        return DetourTransactionCommit() == NO_ERROR;
    }
};

#define DECLARE_DETOUR(NAME, RETURN, ...) \
    typedef RETURN (__fastcall* ##NAME##Func) (__VA_ARGS__); \
    ##NAME##Func NAME = nullptr;