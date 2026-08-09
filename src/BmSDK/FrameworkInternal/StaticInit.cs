using System.Reflection;

namespace BmSDK.Framework;

internal static partial class StaticInit
{
    private const BindingFlags FuncSearchFlags =
        BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;

    public static Type GetManagedTypeForClassPath(string classPath)
    {
        if (_classPathToManagedTypeMap.TryGetValue(classPath, out var res))
        {
            return res;
        }

        Debug.LogWarning($"Couldn't find managed type for class '{classPath}'");
        return typeof(GameObject);
    }

    public static string GetClassPathForManagedType(Type type)
    {
        _managedTypeToClassPathMap.TryGetValue(type, out var res);
        return Guard.NotNull(
            res,
            $"{type.FullName} is not a managed type for any in-game unmanaged type."
        );
    }

    /// <summary>
    /// Returns an enumerable collection of the specified type and all its base types, starting from the given type and
    /// traversing up the inheritance hierarchy.
    /// </summary>
    /// <param name="type">The type from which to begin enumeration. Must not be null.</param>
    /// <returns>An enumerable sequence of <see cref="Type"/> objects, beginning with <paramref name="type"/> and followed by
    /// each of its base types up to the root.</returns>
    public static IEnumerable<Type> EnumerateSelfAndSupers(Type type)
    {
        for (var cur = type; cur != null; cur = cur.BaseType)
        {
            yield return cur;
        }
    }

    /// <summary>
    /// This function enumerates all supers until it finds the first class that declares the requested method.
    /// This is necessary so a method of a non-declaring subclass can be redirected.
    /// </summary>
    /// <param name="type">The type at the bottom of the hierarchy to go up from</param>
    /// <param name="methodName">The name of the method to seach for</param>
    /// <returns>The declaring type or null if not found.</returns>
    public static Type? GetDeclaringTypeForMethod(Type type, string methodName) =>
        type.GetMethod(methodName, FuncSearchFlags)?.DeclaringType;

    /// <summary>
    /// Gets the fully qualified path of the method definition for the given type in the UE3 format.
    /// </summary>
    /// <remarks>If the specified method is inherited, the path will refer to the base type where the method
    /// is originally declared.</remarks>
    /// <param name="type">The type to search for the method declaration. This can be a derived type; the method's actual declaring type
    /// will be resolved.</param>
    /// <param name="stateName">The state the function is defined in.</param>
    /// <param name="methodName">The name of the method whose defining type path is to be retrieved.</param>
    /// <returns>A string representing the path to the method definition: "Namespace.Type:Method".
    /// If a state is supplied, it looks like this: "Namespace.Type:State:Method"</returns>
    public static string GetDeclaringFuncPath(Type type, string? stateName, string methodName)
    {
        // TODO: generate states and evaluate type for states properly
        var declaringType = GetDeclaringTypeForMethod(type, methodName) ?? type;
        var declaringTypePath = GetClassPathForManagedType(declaringType);

        if (stateName is not null)
        {
            return $"{declaringTypePath}:{stateName}:{methodName}";
        }
        else
        {
            return $"{declaringTypePath}:{methodName}";
        }
    }
}
