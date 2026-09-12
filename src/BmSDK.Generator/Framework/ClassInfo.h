#pragma once

string GetFieldNameManaged(class UField* field);
string GetFieldPathNameManaged(class UField* field);

struct MemberInfo
{
    virtual ~MemberInfo() = default;
};

struct PropertyInfo : MemberInfo
{
    PropertyInfo() = default;
    PropertyInfo(class UProperty* prop, bool isInStruct);

    string Name;
    string ManagedName;
    string TypeName;
    string ClassName;
    int32_t ArrayDim = 0;
    int32_t Offset = 0;
    int32_t ElementSize = 0;
    int32_t BitMask = 0;
    uint64_t Flags = 0;
    bool IsInStruct = false;
    bool IsBool = false;
    bool IsParam = false;
    bool IsOptionalParam = false;
    bool IsOutParam = false;
    bool IsConstParam = false;
    bool IsRefParam = false;
    bool IsReturnParam = false;
    bool ShouldReturnByRef = false;
};

struct StructInfo : MemberInfo
{
    StructInfo() = default;
    StructInfo(class UStruct* _struct);
    StructInfo(class UScriptStruct* _struct);

    string ManagedName;
    int32_t PropertiesSize = 0;
    vector<MemberInfo*> Members;
};

struct EnumInfo : MemberInfo
{
    EnumInfo() = default;
    EnumInfo(class UEnum* _enum);

    string Name;
    string ManagedName;
    vector<string> Names;
};

struct FunctionInfo : MemberInfo
{
    FunctionInfo() = default;
    FunctionInfo(class UFunction* func);

    string Name;
    string ManagedName;
    string PathName;
    int32_t PropertiesSize = 0;
    uint32_t Flags = 0;
    bool IsStatic = false;
    bool IsNative = false;
    bool IsPrivate = false;
    bool IsOverride = false;
    bool ShouldSuppressOptional = false;
    bool HasReturnParam = false;
    PropertyInfo ReturnParam;
    vector<PropertyInfo> Params;
};

struct ClassInfo : StructInfo
{
    ClassInfo() = default;
    ClassInfo(class UClass* _class);
    void ResolveSuper(vector<ClassInfo>& classes);

    string Name;
    string PathName;
    string PackageName;
    string PackageNameManaged;
    class UClass* Class = nullptr;
    class UClass* SuperClass = nullptr;
    ClassInfo* Super = nullptr;
    uint32_t Flags = 0;
    bool IsAbstract = false;
    bool IsInterface = false;
    bool IsIntrinsic = false;
    bool IsActor = false;
    vector<string> Interfaces;
};
