#include "pch.h"
#include "Printer.h"
#include "Framework/ClassInfo.h"

int Printer::IndentLevel = 0;

void Printer::PrintFile(const ClassInfo& _class, ostream& out)
{
    // Print preprocessor directives
    Printer::Indent(out) << "#pragma warning disable CS0108" << endl;
    Printer::Indent(out) << "#pragma warning disable CS1591" << endl;
    out << endl;

    // Print namespace declaration
    Printer::Indent(out) << "namespace " << _class.PackageNameManaged << ";" << endl;
    out << endl;

    // Print type
    if (_class.IsInterface)
    {
        // Print interface declaration
        Printer::PrintInterface(_class, out);
    }
    else
    {
        // Print class declaration
        Printer::PrintClass(_class, out);
    }
}

void Printer::PrintInterface(const ClassInfo& _class, ostream& out)
{
    // Print interface comment
    Printer::Indent(out) << "/// <summary>" << endl;
    Printer::Indent(out) << "/// Interface: " << _class.ManagedName << "<br/>" << endl;
    Printer::Indent(out) << "/// (size = " << _class.PropertiesSize << ")" << endl;
    Printer::Indent(out) << "/// (flags = " << _class.Flags << ")" << endl;
    Printer::Indent(out) << "/// </summary>" << endl;

    // Print interface declaration
    Printer::Indent(out) << "public partial interface " << _class.ManagedName;

    // Workaround to prevent Core.Interface from trying to inherit GameObject
    if (_class.PathName != "Core.Interface" && _class.Super)
    {
        out << " : " << _class.Super->PackageNameManaged << "." << _class.Super->ManagedName;
    }
    out << endl;

    // Print interface body
    Printer::Indent(out) << "{" << endl;
    Printer::PushIndent();
    {
        for (auto i = 0u; i < _class.Members.size(); i++)
        {
            auto member = _class.Members[i];
            if (!dynamic_cast<PropertyInfo*>(member))
            {
                Printer::PrintMember(member, true, out);

                if (i < _class.Members.size() - 1)
                {
                    out << endl;
                }
            }
        }
    }
    Printer::PopIndent();
    Printer::Indent(out) << "}" << endl;
}

void Printer::PrintClass(const ClassInfo& _class, ostream& out)
{
    // Print class comment
    Printer::Indent(out) << "/// <summary>" << endl;
    Printer::Indent(out) << "/// ";
    if (_class.IsAbstract)
    {
        out << "ABSTRACT ";
    }
    Printer::Indent(out) << "Class: " << _class.ManagedName << "<br/>" << endl;
    Printer::Indent(out) << "/// (size = " << _class.PropertiesSize << ")" << endl;
    Printer::Indent(out) << "/// (flags = " << _class.Flags << ")" << endl;
    Printer::Indent(out) << "/// </summary>" << endl;

    // Print class declaration
    Printer::Indent(out) << "public partial class " << _class.ManagedName << " : ";
    // Print base class
    if (_class.Super)
    {
        out << _class.Super->PackageNameManaged << "." << _class.Super->ManagedName << ", ";
    }
    // Print implemented interfaces
    if (!_class.Interfaces.empty())
    {
        for (auto& interfaceName : _class.Interfaces)
        {
            out << interfaceName << ", ";
        }
    }
    out << "BmSDK.IGameObject" << endl;

    // Print class body
    Printer::Indent(out) << "{" << endl;
    Printer::PushIndent();
    {
        // Print StaticClass() helper
        Printer::Indent(out) << "static BmSDK.Class s_staticClass = null;" << endl;
        Printer::Indent(out) << "public static BmSDK.Class StaticClass()" << endl;
        Printer::Indent(out) << "{" << endl;
        Printer::PushIndent();
        {
            Printer::Indent(out) << "if (s_staticClass is null)" << endl;
            Printer::Indent(out) << "{" << endl;
            Printer::PushIndent();
            {
                Printer::Indent(out)
                    << "s_staticClass = StaticFindObjectChecked<Class>(null, null, \""
                    << _class.PathName << "\", false);" << endl;
                Printer::Indent(out) << "s_staticClass.AddToRoot();" << endl;
            }
            Printer::PopIndent();
            Printer::Indent(out) << "}" << endl;

            Printer::Indent(out) << "return s_staticClass;" << endl;
        }
        Printer::PopIndent();
        Printer::Indent(out) << "}" << endl;

        out << endl;

        // Print strongly-typed CDO getter.
        if (_class.ManagedName != "Class")
        {
            Printer::Indent(out) << "/// <summary>" << endl;
            Printer::Indent(out) << "/// Gets the class default object as "
                << _class.ManagedName << "." << endl;
            Printer::Indent(out) << "/// </summary>" << endl;
            Printer::Indent(out) << "public static " << _class.ManagedName
                << " DefaultObject => (" << _class.ManagedName
                << ")StaticClass().DefaultObject;" << endl;

            out << endl;
        }

        // Print internal ctor
        Printer::Indent(out) << "internal " << _class.ManagedName << "() { }" << endl << endl;

        // Print main ctor (unless abstract)
        if (!_class.IsAbstract)
        {
            Printer::Indent(out) << "/// <summary>" << endl;
            Printer::Indent(out) << "/// Constructs a new " << _class.ManagedName << endl;
            Printer::Indent(out) << "/// </summary>" << endl;

            if (_class.IsActor)
            {
                Printer::Indent(out)
                    << "public " << _class.ManagedName
                    << "(System.Numerics.Vector3 Location = default, "
                    "BmSDK.Rotator Rotation = default, "
                    "BmSDK.Engine.Actor Template = null, "
                    "BmSDK.GameObject Owner = null, "
                    "BmSDK.GameObject Instigator = null, "
                    "BmSDK.Engine.Level Level = null) "
                    ": base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), "
                    "default, Location, Rotation, Template, Owner, Instigator, Level)) { }"
                    << endl
                    << endl;
            }
            else
            {
                Printer::Indent(out)
                    << "public " << _class.ManagedName
                    << "(BmSDK.GameObject Outer, string Name = null, "
                    "BmSDK.GameObject.EObjectFlags SetFlags = 0, "
                    << _class.ManagedName
                    << " Template = null) : base(ConstructObjectInternal(StaticClass(), "
                    "Outer, Name, SetFlags, Template)) { }"
                    << endl
                    << endl;
            }
        }

        // Print pointer ctor
        Printer::Indent(out) << "/// <summary>" << endl;
        Printer::Indent(out)
            << "/// Constructs a new wrapper instance from the given object pointer." << endl;
        Printer::Indent(out) << "/// </summary>" << endl;
        Printer::Indent(out) << "protected " << _class.ManagedName << "(nint ptr)";
        if (_class.Name == "Object")
        {
            out << " { Ptr = ptr; }" << endl;
        }
        else
        {
            out << " : base(ptr) { }" << endl;
        }
        out << endl;

        // Print strongly-typed ScriptComponent helpers
        Printer::PrintScHelpers(_class, out);

        // Print fields
        for (auto i = 0u; i < _class.Members.size(); i++)
        {
            // Don't print any members for intrinsic classes - they occasionally exist
            // at runtime, but we just want their declaration so we can reference them.
            if (_class.IsIntrinsic)
            {
                break;
            }

            Printer::PrintMember(_class.Members[i], false, out);

            if (i < _class.Members.size() - 1)
            {
                out << endl;
            }
        }
    }
    Printer::PopIndent();
    Printer::Indent(out) << "}" << endl;
}

void Printer::PrintScHelpers(const ClassInfo& _class, ostream& out)
{
    auto type = _class.ManagedName;
    Printer::PrintScHelper("void", "AttachScriptComponent", false, false, false, type, out);
    Printer::PrintScHelper("TComponent", "AttachScriptComponent", true, true, true, type, out);
    Printer::PrintScHelper("bool", "HasScriptComponent", false, false, false, type, out);
    Printer::PrintScHelper("bool", "HasScriptComponent", true, false, false, type, out);
    Printer::PrintScHelper("TComponent", "GetScriptComponent", true, false, true, type, out);

    // Print GetScriptComponents (list)
    Printer::Indent(out) << "/// <inheritdoc cref=\"GameObject.GetScriptComponents(Type)\"/>" << endl;
    Printer::Indent(out) << "public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()" << endl;
    Printer::PushIndent();
    Printer::Indent(out) << "where TComponent : class, Framework.IScriptComponent<" << type << ">" << endl;
    Printer::Indent(out) << "=> ((GameObject)this).GetScriptComponents(typeof(TComponent))"
        << ".Cast<TComponent>().ToList();" << endl;
    Printer::PopIndent();
    out << endl;

    Printer::PrintScHelper("void", "DetachScriptComponent", false, false, false, type, out);
    Printer::PrintScHelper("void", "DetachScriptComponents", true, false, false, type, out);
}

void Printer::PrintScHelper(string returnType, string helper, bool generic, bool ctor, bool cast, string type, ostream& out)
{
    if (generic)
    {
        Printer::Indent(out) << "/// <inheritdoc cref=\"GameObject." << helper << "(Type)\"/>" << endl;
        Printer::Indent(out) << "public " << returnType << " " << helper << "<TComponent>()" << endl;
        Printer::PushIndent();
        Printer::Indent(out) << "where TComponent : class, Framework.IScriptComponent<" << type << ">"
            << (ctor ? ", new()" : "") << endl;
        Printer::Indent(out) << "=> " << (cast ? "(TComponent)" : "")
            << "((GameObject)this)." << helper << "(typeof(TComponent));" << endl;
        Printer::PopIndent();
        out << endl;
    }
    else
    {
        Printer::Indent(out) << "/// <inheritdoc cref=\"GameObject." << helper << "(Framework.IScriptComponent)\"/>" << endl;
        Printer::Indent(out) << "public " << returnType << " " << helper << "<TComponent>(TComponent component)" << endl;
        Printer::PushIndent();
        Printer::Indent(out) << "where TComponent : class, Framework.IScriptComponent<" << type << ">" << endl;
        Printer::Indent(out) << "=> ((GameObject)this)." << helper << "((Framework.IScriptComponent)component);" << endl;
        Printer::PopIndent();
        out << endl;
    }

}

void Printer::PrintStruct(const StructInfo& _struct, ostream& out)
{
    // Print struct comment
    Printer::Indent(out) << "/// <summary>" << endl;
    Printer::Indent(out) << "/// Struct: " << _struct.ManagedName << endl;
    Printer::Indent(out) << "/// </summary>" << endl;

    // Print struct declaration
    Printer::Indent(out) << "[StructLayout(LayoutKind.Explicit, Size = " << _struct.PropertiesSize
        << ")]" << endl;
    Printer::Indent(out) << "public partial record struct " << _struct.ManagedName << endl;

    // Print struct body
    Printer::Indent(out) << "{" << endl;
    Printer::PushIndent();
    {
        for (auto i = 0u; i < _struct.Members.size(); i++)
        {
            Printer::PrintMember(_struct.Members[i], false, out);

            if (i < _struct.Members.size() - 1)
            {
                out << endl;
            }
        }
    }
    Printer::PopIndent();
    Printer::Indent(out) << "}" << endl;
}

void Printer::PrintEnum(const EnumInfo& _enum, ostream& out)
{
    // Print prop comment
    Printer::Indent(out) << "/// <summary>" << endl;
    Printer::Indent(out) << "/// Enum: " << _enum.Name << endl;
    Printer::Indent(out) << "/// </summary>" << endl;

    // Print prop declaration
    Printer::Indent(out) << "public enum " << _enum.ManagedName << " : byte" << endl;

    // Print prop body
    Printer::Indent(out) << "{" << endl;
    Printer::PushIndent();
    {
        for (auto i = 0u; i < _enum.Names.size(); i++)
        {
            Printer::Indent(out) << _enum.Names.at(i) << " = " << i << "," << endl;
        }
    }
    Printer::PopIndent();
    Printer::Indent(out) << "}" << endl;
}

void Printer::PrintProperty(const PropertyInfo& prop, ostream& out)
{
    if (!prop.IsInStruct && prop.ArrayDim > 1)
    {
        Printer::Indent(out) << "/// <summary>" << endl;
        Printer::Indent(out) << "/// InlineArray{" << prop.ClassName << "}: " << prop.Name << endl;
        Printer::Indent(out) << "/// </summary>" << endl;

        Printer::Indent(out) << "public InlineArray<" << prop.TypeName << "> "
            << prop.ManagedName << " => new(" << prop.ArrayDim
            << ", Ptr + " << prop.Offset << ", " << prop.ElementSize << ", this);"
            << endl << endl;
    }

    for (auto i = 0; i < prop.ArrayDim; i++)
    {
        auto propOffset = prop.Offset + (i * prop.ElementSize);
        auto propNameManaged = prop.ManagedName;

        // Print prop comment
        Printer::Indent(out) << "/// <summary>" << endl;
        Printer::Indent(out) << "/// " << prop.ClassName << ": " << prop.Name << endl;
        Printer::Indent(out) << "/// </summary>" << endl;

        if (prop.ArrayDim > 1)
        {
            propNameManaged += "_";
            propNameManaged += to_string(i);
        }

        if (prop.ShouldReturnByRef)
        {
            Printer::Indent(out) << "public unsafe ref " << prop.TypeName << " "
                << propNameManaged << endl;

            Printer::PushIndent();
            Printer::Indent(out) << "=> ref BmSDK.Framework.MarshalUtil.AsRef<"
                << prop.TypeName << ">(Ptr + " << propOffset << ");" << endl;
            Printer::PopIndent();
        }
        else
        {
            // Print prop declaration
            Printer::Indent(out) << "public unsafe " << prop.TypeName << " "
                << propNameManaged << endl;

            // Print prop body
            Printer::Indent(out) << "{" << endl;
            Printer::PushIndent();
            {
                // Print prop getter (single line)
                Printer::Indent(out) << "get { ";
                {
                    // Make Ptr available locally so we can reuse the same getter code
                    if (prop.IsInStruct)
                    {
                        out << "fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; ";
                    }

                    // Booleans (stored as bitmasks) need special handling
                    if (prop.IsBool)
                    {
                        out << "return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + " << propOffset
                            << ") & " << prop.BitMask << ") != 0;";
                    }
                    else
                    {
                        out << "return BmSDK.Framework.MarshalUtil.ToManaged<"
                            << prop.TypeName << ">(Ptr + " << propOffset << ");";
                    }

                    if (prop.IsInStruct)
                    {
                        out << " };";
                    }
                }
                out << " }" << endl;

                // Print prop setter (single line)
                Printer::Indent(out) << "set { ";
                {
                    // Make Ptr available locally so we can reuse the same setter code
                    if (prop.IsInStruct)
                    {
                        out << "fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; ";
                    }

                    // Booleans (stored as bitmasks) need special handling
                    if (prop.IsBool)
                    {
                        out << "var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + "
                            << propOffset << ");";
                        out << " var newMask = value ? (currentMask | " << prop.BitMask
                            << ") : (currentMask & ~" << prop.BitMask << ");";

                        out << " BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + "
                            << propOffset << ");";
                    }
                    else
                    {
                        out << "BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + " << propOffset
                            << ");";
                    }

                    if (prop.IsInStruct)
                    {
                        out << " };";
                    }
                }
                out << " }" << endl;
            }
            Printer::PopIndent();
            Printer::Indent(out) << "}" << endl;
        }
    }
}

void Printer::PrintFunction(const FunctionInfo& func, bool isInInterface, ostream& out)
{
    // Print func comment
    Printer::Indent(out) << "/// <summary>" << endl;
    Printer::Indent(out) << "/// Function: " << func.Name << endl;
    Printer::Indent(out) << "/// </summary>" << endl;

    // Print func declaration
    Printer::Indent(out) << "public unsafe ";
    if (func.IsStatic)
    {
        out << "static ";
    }
    else
    {
        if (!func.IsPrivate && !isInInterface)
        {
            if (func.IsOverride)
            {
                out << "override ";
            }
            else
            {
                out << "virtual ";
            }
        }
    }
    out << (func.HasReturnParam ? func.ReturnParam.TypeName : "void") << " ";
    out << func.ManagedName << "(";
    for (auto i = 0u; i < func.Params.size(); i++)
    {
        auto& prop = func.Params[i];

        // UE3 out params are read as well as written, so they map to "ref"
        if (prop.IsRefParam)
        {
            out << "ref ";
        }

        // Print param declaration
        out << prop.TypeName << " " << prop.ManagedName;
        if (prop.IsOptionalParam && !func.ShouldSuppressOptional)
        {
            out << " = default";
        }

        if (i < func.Params.size() - 1)
        {
            out << ", ";
        }
    }
    out << ")";

    if (isInInterface) {
        out << ";" << endl;
        return;
    }
    else {
        out << endl;
    }

    // Print func body
    Printer::Indent(out) << "{" << endl;
    Printer::PushIndent();
    {
        string ptrText = func.IsStatic ? "StaticClass().DefaultObject.Ptr" : "Ptr";

        Printer::Indent(out) << "var funcManaged = "
            "BmSDK.GameObject.StaticFindObjectChecked<BmSDK."
            "Function>(BmSDK.Function.StaticClass(), null, \""
            << func.PathName << "\", true);" << endl;

        Printer::Indent(out) << "byte* paramsPtr = stackalloc byte[" << func.PropertiesSize << "];"
            << endl;
        for (auto i = 0u; i < func.Params.size(); i++)
        {
            auto& param = func.Params[i];

            // ProcessEvent seeds the callee's locals from this buffer, so every param marshals in
            Printer::Indent(out) << "BmSDK.Framework.MarshalUtil.ToUnmanaged("
                << param.ManagedName << ", paramsPtr + " << param.Offset
                << ");" << endl;
        }

        if (func.IsNative)
        {
            Printer::Indent(out) << "var oldFlags = funcManaged.FunctionFlags;" << endl;
            Printer::Indent(out) << "var oldNative = funcManaged.iNative;" << endl;
            Printer::Indent(out)
                << "funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;"
                << endl;
            Printer::Indent(out)
                << "funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;"
                << endl;
            Printer::Indent(out) << "funcManaged.iNative = 0;" << endl;
        }

        Printer::Indent(out) << "BmSDK.Framework.GameFunctions.ProcessEvent(" << ptrText
            << ", funcManaged.Ptr, (nint)paramsPtr, 0);" << endl;

        if (func.IsNative)
        {
            Printer::Indent(out) << "funcManaged.iNative = oldNative;" << endl;
            Printer::Indent(out) << "funcManaged.FunctionFlags = oldFlags;" << endl;
        }

        // Marshal/assign ref params
        for (auto i = 0u; i < func.Params.size(); i++)
        {
            auto& param = func.Params[i];

            if (param.IsRefParam)
            {
                Printer::Indent(out)
                    << param.ManagedName << " = BmSDK.Framework.MarshalUtil.ToManaged<"
                    << param.TypeName << ">(paramsPtr + " << param.Offset << ");"
                    << endl;
            }
        }

        if (func.HasReturnParam)
        {
            // Print return param declaration
            Printer::Indent(out) << "return BmSDK.Framework.MarshalUtil.ToManaged<"
                << func.ReturnParam.TypeName << ">(paramsPtr + "
                << func.ReturnParam.Offset << ");" << endl;
        }
        else
        {
            Printer::Indent(out) << "return;" << endl;
        }
    }
    Printer::PopIndent();
    Printer::Indent(out) << "}" << endl;
}

void Printer::PrintMember(const MemberInfo* member, bool isInInterface, ostream& out)
{
    if (auto prop = dynamic_cast<const PropertyInfo*>(member))
    {
        Printer::PrintProperty(*prop, out);
    }
    else if (auto _struct = dynamic_cast<const StructInfo*>(member))
    {
        Printer::PrintStruct(*_struct, out);
    }
    else if (auto _enum = dynamic_cast<const EnumInfo*>(member))
    {
        Printer::PrintEnum(*_enum, out);
    }
    else if (auto func = dynamic_cast<const FunctionInfo*>(member))
    {
        Printer::PrintFunction(*func, isInInterface, out);
    }
}

void Printer::PrintStaticInit(const vector<ClassInfo>& classes, ostream& out)
{
    // Print usings
    Printer::Indent(out) << "using System.Collections.Generic;" << endl;
    out << endl;
    Printer::Indent(out) << "namespace BmSDK.Framework;" << endl;
    out << endl;

    // Print class declaration
    Printer::Indent(out) << "internal static partial class StaticInit" << endl;
    Printer::Indent(out) << "{" << endl;
    Printer::PushIndent();
    {
        // Print props
        Printer::Indent(out) << "private static Dictionary<string, Type> _classPathToManagedTypeMap = [];"
            << endl;
        Printer::Indent(out) << "private static Dictionary<Type, string> _managedTypeToClassPathMap = [];"
            << endl;
        out << endl;

        // Print StaticInitClasses()
        Printer::Indent(out) << "public static void StaticInitClasses()" << endl;
        Printer::Indent(out) << "{" << endl;
        Printer::PushIndent();
        {
            for (auto& _class : classes)
            {
                Printer::Indent(out) << "_classPathToManagedTypeMap[\"" << _class.PathName
                    << "\"] = typeof(" << _class.PackageNameManaged << "."
                    << _class.ManagedName << ");" << endl;

                Printer::Indent(out) << "_managedTypeToClassPathMap[typeof("
                    << _class.PackageNameManaged << "." << _class.ManagedName
                    << ")] = \"" << _class.PathName << "\";" << endl;
            }
        }
        Printer::PopIndent();
        Printer::Indent(out) << "}" << endl;
    }
    Printer::PopIndent();
    Printer::Indent(out) << "}" << endl;
}
