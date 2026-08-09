namespace BmSDK.Framework;

/// <summary>
/// Marks a method inside of a ScriptComponent declaration as a local/conditional
/// detour to a target method. It only applies to Actor instances that have the
/// ScriptComponent attached. The Actor type is inferred from the generic argument
/// of <see cref="ScriptComponent{TActor}"/>
/// </summary>
/// <remarks>
/// You may only redirect methods that are declared on the ScriptComponent's target
/// actor type or its base types. The target UFunction cannot be static.
/// The method being marked CANNOT be static because the target instance is only exposed
/// via <see cref="ScriptComponent{TActor}.Owner"/>. Therefore, the artificial
/// <c>self</c> object MUST NOT be declared as a method parameter unlike the global
/// <see cref="RedirectAttribute"/>. Use <c>Owner</c> instead.
/// The redirect's function signature must match the original's one-to-one:
/// Return type, parameter types and parameter order must remain.
/// Names and the access modifier are both irrelevant.</remarks>
/// <example>
/// [ScriptComponent]
/// public class RegenReductionComponent : ScriptComponent&lt;RPawnPlayer&gt;
/// {
///     [ComponentRedirect(nameof(RPawnPlayer.ExperienceAwarded))]
///     private void ExperienceAwardedRedirect(int xp, int teethXp)
///     {
///         Debug.Log("Experiencing less...");
///         Owner.ExperienceAwarded(xp / 10, teethXp / 10);
///     }
/// }
/// </example>
/// <param name="targetMethod">The name of the original method to detour.
/// Use <see langword="nameof"/> to get it safely.</param>
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public sealed class ComponentRedirectAttribute(string targetMethod) : Attribute
{
    public string TargetMethod { get; } = targetMethod;

    /// <summary>
    /// The name of the state to detour the function of.
    /// </summary>
    public string? TargetState { get; init; }
}
