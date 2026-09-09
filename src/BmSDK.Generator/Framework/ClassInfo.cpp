#include "pch.h"
#include "ClassInfo.h"
#include "Engine/UClass.h"
#include "Engine/UEnum.h"
#include "Engine/UFunction.h"
#include "Engine/UProperty.h"

#include <map>

string GetFieldNameManaged(UField* field)
{
    // Manually rename some classes to avoid conflicts with the System namespace
    if (field->GetPathName() == "Core.Object")
    {
        return "GameObject";
    }
    else if (field->GetPathName() == "Core.System")
    {
        return "_System";
    }
    else if (field->GetPathName() == "Engine.Console")
    {
        return "_Console";
    }

    if (field->IsA(UScriptStruct::StaticClass()))
    {
        return "F" + field->GetName();
    }

    // Workaround fields with same name as their outer
    if (field->Outer && field->GetName() == field->Outer->GetName())
    {
        return "_" + field->GetName();
    }

    // Ensure that every function override will have the same name
    if (field->IsA(UFunction::StaticClass()))
    {
        auto func = (UFunction*)field;
        if (func->SuperStruct)
        {
            return GetFieldNameManaged((UField*)func->SuperStruct);
        }
    }

    // De-duplicate prop names for structs and functions
    if (field->Outer && field->IsA(UProperty::StaticClass()) &&
        (field->Outer->IsA(UFunction::StaticClass()) ||
            field->Outer->IsA(UScriptStruct::StaticClass())))
    {
        int numDuplicates = 0;
        auto propLink = ((UStruct*)field->Outer)->Children;
        while (propLink && propLink != field)
        {
            if (propLink->GetName() == field->GetName())
            {
                numDuplicates++;
            }

            propLink = propLink->Next;
        }

        if (numDuplicates > 0)
        {
            return field->GetName() + "_" + to_string(numDuplicates);
        }
    }

    return field->GetName();
}

string GetFieldPathNameManaged(UField* field)
{
    auto managedName = GetFieldNameManaged(field);

    if (field->IsA(UClass::StaticClass()))
    {
        return field->GetPackageNameManaged() + "." + managedName;
    }

    if (field->Outer && field->Outer->IsA(UField::StaticClass()))
    {
        return GetFieldPathNameManaged((UField*)field->Outer) + "." + managedName;
    }

    return managedName;
}

PropertyInfo::PropertyInfo(UProperty* prop, bool isInStruct)
{
    Name = prop->GetName();
    ManagedName = GetFieldNameManaged(prop);
    TypeName = prop->GetInnerTypeNameManaged();
    ClassName = prop->Class->GetName();
    ArrayDim = prop->ArrayDim;
    Offset = prop->Offset;
    ElementSize = prop->ElementSize;
    Flags = (uint64_t)prop->PropertyFlags;
    IsInStruct = isInStruct;
    IsBool = prop->IsA(UBoolProperty::StaticClass());
    IsParam = Flags & (uint64_t)EPropertyFlags::CPF_Parm;
    IsOptionalParam = Flags & (uint64_t)EPropertyFlags::CPF_OptionalParm;
    // Keep "const out" as regular input param
    IsOutParam = (Flags & (uint64_t)EPropertyFlags::CPF_OutParm) && !(Flags & (uint64_t)EPropertyFlags::CPF_Const);
    IsReturnParam = Flags & (uint64_t)EPropertyFlags::CPF_ReturnParm;
    ShouldReturnByRef = prop->ShouldReturnByRef() && !IsInStruct;

    if (IsBool)
    {
        BitMask = ((UBoolProperty*)prop)->BitMask;
    }
}

StructInfo::StructInfo(UStruct* _struct)
{
    ManagedName = GetFieldNameManaged(_struct);
    PropertiesSize = _struct->PropertiesSize;
}

StructInfo::StructInfo(UScriptStruct* _struct) : StructInfo((UStruct*)_struct)
{
    for (auto field = _struct->Children; field; field = field->Next)
    {
        if (field->IsA(UProperty::StaticClass()))
        {
            Members.push_back(new PropertyInfo((UProperty*)field, true));
        }
    }
}

EnumInfo::EnumInfo(UEnum* _enum)
{
    Name = _enum->GetName();
    ManagedName = GetFieldNameManaged(_enum);

    map<string, int> enumNameFreqs;
    for (auto i = 0; i < _enum->Names.Num; i++)
    {
        auto name = _enum->Names.ElementAt(i).ToString();
        enumNameFreqs[name]++;

        if (enumNameFreqs[name] > 1)
        {
            Names.push_back(name + "_" + to_string(enumNameFreqs[name]));
        }
        else
        {
            Names.push_back(name);
        }
    }
}

FunctionInfo::FunctionInfo(UFunction* func)
{
    Name = func->GetName();
    ManagedName = GetFieldNameManaged(func);
    PathName = func->GetPathName();
    PropertiesSize = func->PropertiesSize;
    Flags = (uint32_t)func->FunctionFlags;
    IsStatic = Flags & (uint32_t)EFunctionFlags::FUNC_Static;
    IsNative = Flags & (uint32_t)EFunctionFlags::FUNC_Native;
    IsPrivate = Flags & (uint32_t)EFunctionFlags::FUNC_Private;
    IsOverride = func->SuperStruct && func->SuperStruct->IsA(UFunction::StaticClass());

    for (auto field = func->Children; field; field = field->Next)
    {
        if (!field->IsA(UProperty::StaticClass()))
        {
            continue;
        }

        auto prop = (UProperty*)field;
        auto propInfo = PropertyInfo(prop, false);
        if (propInfo.IsReturnParam)
        {
            ReturnParam = propInfo;
            HasReturnParam = true;
        }
        else if (propInfo.IsParam)
        {
            Params.push_back(propInfo);
        }
    }

    for (auto& param : Params)
    {
        if (param.IsOptionalParam && param.IsOutParam)
        {
            ShouldSuppressOptional = true;
            break;
        }
    }
}

ClassInfo::ClassInfo(UClass* _class) : StructInfo((UStruct*)_class)
{
    Class = _class;
    SuperClass = (UClass*)_class->SuperStruct;
    Name = _class->GetName();
    PathName = _class->GetPathName();
    PackageName = _class->GetPackageName();
    PackageNameManaged = _class->GetPackageNameManaged();
    Flags = (uint32_t)_class->ClassFlags;
    IsAbstract = Flags & (uint32_t)EClassFlags::CLASS_Abstract;
    IsInterface = Flags & (uint32_t)EClassFlags::CLASS_Interface;
    IsIntrinsic = Flags & (uint32_t)EClassFlags::CLASS_Intrinsic;

    for (auto super = _class->SuperStruct; super; super = super->SuperStruct)
    {
        if (super->GetPathName() == "Engine.Actor")
        {
            IsActor = true;
            break;
        }
    }

    for (int i = 0; i < _class->Interfaces.Num; i++)
    {
        Interfaces.push_back(GetFieldPathNameManaged(_class->Interfaces.ElementAt(i).Class));
    }

    for (auto field = _class->Children; field; field = field->Next)
    {
        if (field->IsA(UProperty::StaticClass()))
        {
            Members.push_back(new PropertyInfo((UProperty*)field, false));
        }
        else if (field->IsA(UScriptStruct::StaticClass()))
        {
            Members.push_back(new StructInfo((UScriptStruct*)field));
        }
        else if (field->IsA(UEnum::StaticClass()))
        {
            Members.push_back(new EnumInfo((UEnum*)field));
        }
        else if (field->IsA(UFunction::StaticClass()))
        {
            auto func = (UFunction*)field;
            auto flags = (uint32_t)func->FunctionFlags;
            if (flags & ((uint32_t)EFunctionFlags::FUNC_Operator | (uint32_t)EFunctionFlags::FUNC_Iterator))
            {
                continue;
            }

            Members.push_back(new FunctionInfo(func));
        }
    }
}

void ClassInfo::ResolveSuper(vector<ClassInfo>& classes)
{
    if (!SuperClass)
    {
        return;
    }

    for (auto& _class : classes)
    {
        if (_class.Class == SuperClass)
        {
            Super = &_class;
            return;
        }
    }
}
