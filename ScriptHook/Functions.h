#pragma once

class Functions {
private:
    Functions() = delete;

private:
    typedef UObject* (__fastcall* GetDefaultObjectFunc) (UClass*, BOOL);
    typedef UPackage* (__cdecl* LoadPackageFunc) (UObject*, const wchar_t*, int);

public:
    // Base
    static UObject* GetDefaultObject(UClass* pClass, BOOL bForce = 0);
    static UPackage* LoadPackage(UPackage* InOuter, const wchar_t* Filename, int LoadFlags = 0);

    // Helpers
    template <typename T>
    static T* GetDefaultObject(BOOL bForce = 0) { return (T*)GetDefaultObject(T::StaticClass(), bForce); }

    template <typename T>
    static T* DynamicLoadObject(const FString& ObjectName, bool optionalMayFail = false) { return (T*)UObject::DynamicLoadObject(ObjectName, T::StaticClass(), optionalMayFail); }
};