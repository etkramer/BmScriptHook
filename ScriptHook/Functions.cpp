#include "pch.h"
#include "Functions.h"
#include "Runtime.h"
#include "Offsets.h"

UObject* Functions::GetDefaultObject(UClass* pClass, BOOL bForce) {
    static auto pFn = (GetDefaultObjectFunc)(void*)(Runtime::BaseAddress + Offsets::UClass_GetDefaultObject);
    return pFn(pClass, bForce);
}

UPackage* Functions::LoadPackage(UPackage* InOuter, const wchar_t* Filename, int LoadFlags) {
    static auto pFn = (LoadPackageFunc)(void*)(Runtime::BaseAddress + Offsets::UObject_LoadPackage);
    return pFn(InOuter, Filename, LoadFlags);
}