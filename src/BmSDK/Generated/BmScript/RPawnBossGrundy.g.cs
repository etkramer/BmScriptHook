#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnBossGrundy<br/>
/// (size = 8736)
/// (flags = 10486326)
/// </summary>
public partial class RPawnBossGrundy : BmSDK.BmGame.RPawnBossGrundyBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnBossGrundy", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnBossGrundy.
    /// </summary>
    public static RPawnBossGrundy DefaultObject => (RPawnBossGrundy)StaticClass().DefaultObject;

    internal RPawnBossGrundy() { }

    /// <summary>
    /// Constructs a new RPawnBossGrundy
    /// </summary>
    public RPawnBossGrundy(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnBossGrundy(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossGrundy>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossGrundy>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossGrundy>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossGrundy>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossGrundy>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossGrundy>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossGrundy>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossGrundy>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: CreateBasicWeaponConfig
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateBasicWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets, BmSDK.Engine.AnimSet TurnAnimSet = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.CreateBasicWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[6900];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSets, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnAnimSet, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: dbgBlowPadsUp
    /// </summary>
    public unsafe override void dbgBlowPadsUp()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.dbgBlowPadsUp", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetAllPadsDamageStates
    /// </summary>
    public unsafe virtual void SetAllPadsDamageStates(int State)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SetAllPadsDamageStates", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(State, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetSmashReturnPoint
    /// </summary>
    public unsafe virtual void SetSmashReturnPoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SetSmashReturnPoint", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReturnWeightToThisLocation
    /// </summary>
    public unsafe virtual void ReturnWeightToThisLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.ReturnWeightToThisLocation", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EndChainRetraction
    /// </summary>
    public unsafe virtual void EndChainRetraction()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.EndChainRetraction", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsInBeamHitReact
    /// </summary>
    public unsafe virtual bool IsInBeamHitReact()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.IsInBeamHitReact", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FlashBeamsOn
    /// </summary>
    public unsafe virtual void FlashBeamsOn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.FlashBeamsOn", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FlashBeamsOff
    /// </summary>
    public unsafe virtual void FlashBeamsOff()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.FlashBeamsOff", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FinishBeamHitReact
    /// </summary>
    public unsafe virtual void FinishBeamHitReact()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.FinishBeamHitReact", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerBeamHitReact
    /// </summary>
    public unsafe virtual void TriggerBeamHitReact()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.TriggerBeamHitReact", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerRoomShutdownScreenShake
    /// </summary>
    public unsafe virtual void TriggerRoomShutdownScreenShake()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.TriggerRoomShutdownScreenShake", true);
        byte* paramsPtr = stackalloc byte[148];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverloadExplosion3
    /// </summary>
    public unsafe virtual void OverloadExplosion3()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.OverloadExplosion3", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverloadExplosion2
    /// </summary>
    public unsafe virtual void OverloadExplosion2()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.OverloadExplosion2", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverloadExplosion1
    /// </summary>
    public unsafe virtual void OverloadExplosion1()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.OverloadExplosion1", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GrundyRumbleNotify
    /// </summary>
    public unsafe virtual void GrundyRumbleNotify()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.GrundyRumbleNotify", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisablePadSmoke
    /// </summary>
    public unsafe virtual void DisablePadSmoke()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.DisablePadSmoke", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnablePadSmoke
    /// </summary>
    public unsafe virtual void EnablePadSmoke()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.EnablePadSmoke", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopExtraBeams
    /// </summary>
    public unsafe virtual void StopExtraBeams()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StopExtraBeams", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartExtraBeams
    /// </summary>
    public unsafe virtual void StartExtraBeams()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StartExtraBeams", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartRoomBits
    /// </summary>
    public unsafe virtual void StartRoomBits()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StartRoomBits", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopFailBeams
    /// </summary>
    public unsafe virtual void StopFailBeams()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StopFailBeams", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartFailBeams
    /// </summary>
    public unsafe virtual void StartFailBeams()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StartFailBeams", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerFailBeams3
    /// </summary>
    public unsafe virtual void TriggerFailBeams3()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.TriggerFailBeams3", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerFailBeams2
    /// </summary>
    public unsafe virtual void TriggerFailBeams2()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.TriggerFailBeams2", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerFailBeams1
    /// </summary>
    public unsafe virtual void TriggerFailBeams1()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.TriggerFailBeams1", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RewindIgniteAnimsToUncutPoint
    /// </summary>
    public unsafe virtual void RewindIgniteAnimsToUncutPoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.RewindIgniteAnimsToUncutPoint", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IgniteCameraReturnFromCut
    /// </summary>
    public unsafe virtual void IgniteCameraReturnFromCut()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.IgniteCameraReturnFromCut", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IgniteCameraCut
    /// </summary>
    public unsafe virtual void IgniteCameraCut()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.IgniteCameraCut", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PenguinButtonPressed
    /// </summary>
    public unsafe virtual void PenguinButtonPressed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.PenguinButtonPressed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnableFakeDeathBlockingVolumes
    /// </summary>
    public unsafe virtual void EnableFakeDeathBlockingVolumes(bool bEnabled)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.EnableFakeDeathBlockingVolumes", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterCrushButtonPress
    /// </summary>
    public unsafe virtual void RegisterCrushButtonPress()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.RegisterCrushButtonPress", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActionPerformed
    /// </summary>
    public unsafe override void ActionPerformed(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.ActionPerformed", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetHelpTextState
    /// </summary>
    public unsafe virtual void SetHelpTextState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SetHelpTextState", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateHelpText
    /// </summary>
    public unsafe virtual void UpdateHelpText(float UpdateTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdateHelpText", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GelPlaced
    /// </summary>
    public unsafe virtual bool GelPlaced()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.GelPlaced", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RemovePlacedGel
    /// </summary>
    public unsafe virtual void RemovePlacedGel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.RemovePlacedGel", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateGrundyGlow
    /// </summary>
    public unsafe virtual void UpdateGrundyGlow(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdateGrundyGlow", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdatePadGlow
    /// </summary>
    public unsafe virtual void UpdatePadGlow(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdatePadGlow", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayHeartBeatAnim
    /// </summary>
    public unsafe virtual void PlayHeartBeatAnim()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.PlayHeartBeatAnim", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HeartBeat
    /// </summary>
    public unsafe virtual void HeartBeat()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.HeartBeat", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateHeartBeat
    /// </summary>
    public unsafe virtual void UpdateHeartBeat(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdateHeartBeat", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnableHeartAnim
    /// </summary>
    public unsafe virtual void EnableHeartAnim()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.EnableHeartAnim", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisableHeartAnim
    /// </summary>
    public unsafe virtual void DisableHeartAnim()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.DisableHeartAnim", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearDrumPads
    /// </summary>
    public unsafe virtual void ClearDrumPads()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.ClearDrumPads", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartDrumPads
    /// </summary>
    public unsafe virtual void StartDrumPads()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StartDrumPads", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HeartBeatMarker
    /// </summary>
    public unsafe virtual void HeartBeatMarker(int CallbackFlags, int MarkerID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.HeartBeatMarker", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CallbackFlags, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MarkerID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPadGroupPos
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPadGroupPos(int padGroup)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.GetPadGroupPos", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(padGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsPadGroupActive
    /// </summary>
    public unsafe virtual bool IsPadGroupActive(int padGroup)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.IsPadGroupActive", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(padGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TriggerPadDetonateEvent
    /// </summary>
    public unsafe virtual void TriggerPadDetonateEvent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.TriggerPadDetonateEvent", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawPadDebug
    /// </summary>
    public unsafe virtual void DrawPadDebug()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.DrawPadDebug", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BlowUpPadGroup
    /// </summary>
    public unsafe virtual void BlowUpPadGroup(int padGroup)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.BlowUpPadGroup", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(padGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrumPadExploded
    /// </summary>
    public unsafe virtual void DrumPadExploded(BmSDK.BmScript.RGrundyDrumPad HitPad)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.DrumPadExploded", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPad, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoMachineDisableRumble
    /// </summary>
    public unsafe virtual void DoMachineDisableRumble()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.DoMachineDisableRumble", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ElectricPillarsShouldBeOn
    /// </summary>
    public unsafe virtual bool ElectricPillarsShouldBeOn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.ElectricPillarsShouldBeOn", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ArePadsVulnerable
    /// </summary>
    public unsafe virtual bool ArePadsVulnerable()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.ArePadsVulnerable", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsOnBeat
    /// </summary>
    public unsafe virtual bool IsOnBeat(BmSDK.BmScript.RPawnBossGrundy.eGrundyBeatMatch beatMatchType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.IsOnBeat", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(beatMatchType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: StartHUD
    /// </summary>
    public unsafe virtual void StartHUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StartHUD", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateHud
    /// </summary>
    public unsafe virtual void UpdateHud(float TimeDelta)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdateHud", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeDelta, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopElectrics
    /// </summary>
    public unsafe virtual void StopElectrics()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StopElectrics", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GeneratorPunch
    /// </summary>
    public unsafe virtual void GeneratorPunch()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.GeneratorPunch", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartElectrics
    /// </summary>
    public unsafe virtual void StartElectrics()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StartElectrics", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreStartElectrics
    /// </summary>
    public unsafe virtual void PreStartElectrics()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.PreStartElectrics", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayGrundyImpactSound
    /// </summary>
    public unsafe virtual void PlayGrundyImpactSound(bool bBigBlow)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.PlayGrundyImpactSound", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBigBlow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DamageGrundy
    /// </summary>
    public unsafe virtual bool DamageGrundy(float DamageAmount, bool canTriggerStageTransition, bool canTriggerDaze = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.DamageGrundy", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(canTriggerStageTransition, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(canTriggerDaze, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: CanRepelAttack
    /// </summary>
    public unsafe override bool CanRepelAttack(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.CanRepelAttack", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.Destroyed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BatmanInRangeForStomp
    /// </summary>
    public unsafe virtual bool BatmanInRangeForStomp()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.BatmanInRangeForStomp", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AllowCamera
    /// </summary>
    public unsafe override bool AllowCamera(BmSDK.BmGame.RSpecialMoveConfig SpecialMove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.AllowCamera", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: PrepareMaterials
    /// </summary>
    public unsafe virtual void PrepareMaterials()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.PrepareMaterials", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnMaggots
    /// </summary>
    public unsafe virtual void SpawnMaggots()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SpawnMaggots", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetMaggotDamage
    /// </summary>
    public unsafe virtual float GetMaggotDamage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.GetMaggotDamage", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetMaggotSpawnSocket
    /// </summary>
    public unsafe virtual BmSDK.FName GetMaggotSpawnSocket()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.GetMaggotSpawnSocket", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: KeepInView
    /// </summary>
    public unsafe virtual void KeepInView(BmSDK.Engine.Actor Pawn, float MaxYaw = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.KeepInView", true);
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxYaw, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateKeepInViewTarget
    /// </summary>
    public unsafe virtual void UpdateKeepInViewTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdateKeepInViewTarget", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateVFXPositions
    /// </summary>
    public unsafe virtual void UpdateVFXPositions()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdateVFXPositions", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.DamagedBy", true);
        byte* paramsPtr = stackalloc byte[245];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 244);
    }

    /// <summary>
    /// Function: DisallowBeating
    /// </summary>
    public unsafe virtual void DisallowBeating()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.DisallowBeating", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AllowBeating
    /// </summary>
    public unsafe virtual void AllowBeating()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.AllowBeating", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BossCanTakeGooHit
    /// </summary>
    public unsafe override bool BossCanTakeGooHit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.BossCanTakeGooHit", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanBeGlideKicked
    /// </summary>
    public unsafe override bool CanBeGlideKicked()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.CanBeGlideKicked", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsBoss
    /// </summary>
    public unsafe override bool IsBoss()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.IsBoss", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DouseFlames
    /// </summary>
    public unsafe virtual void DouseFlames()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.DouseFlames", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetRibsDamageState
    /// </summary>
    public unsafe virtual void SetRibsDamageState(int Index, bool doFX = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SetRibsDamageState", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(doFX, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetDepthBiasOnEmissive
    /// </summary>
    public unsafe virtual void SetDepthBiasOnEmissive()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SetDepthBiasOnEmissive", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SwapToBurntMats
    /// </summary>
    public unsafe virtual void SwapToBurntMats()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SwapToBurntMats", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SwitchToUnBurnt
    /// </summary>
    public unsafe virtual void SwitchToUnBurnt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SwitchToUnBurnt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SwitchToBurnt
    /// </summary>
    public unsafe virtual void SwitchToBurnt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SwitchToBurnt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Ignite2
    /// </summary>
    public unsafe virtual void Ignite2()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.Ignite2", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Ignite
    /// </summary>
    public unsafe override void Ignite()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.Ignite", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InputRightStick
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 InputRightStick()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.InputRightStick", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SpawnSpecialAttack
    /// </summary>
    public unsafe override bool SpawnSpecialAttack(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SpawnSpecialAttack", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: CanRedirect
    /// </summary>
    public unsafe override bool CanRedirect()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.CanRedirect", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: EnableKeepInView
    /// </summary>
    public unsafe virtual void EnableKeepInView()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.EnableKeepInView", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MudSplatter
    /// </summary>
    public unsafe virtual void MudSplatter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.MudSplatter", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveCounterIcon
    /// </summary>
    public unsafe override void RemoveCounterIcon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.RemoveCounterIcon", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopAttackingFX
    /// </summary>
    public unsafe override void StopAttackingFX(bool bSuccess = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StopAttackingFX", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccess, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartAttackingFX
    /// </summary>
    public unsafe override void StartAttackingFX(int CTypeInt, BmSDK.BmGame.RPlayerController PC = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StartAttackingFX", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CTypeInt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayPunchedInHeadAnim
    /// </summary>
    public unsafe virtual void PlayPunchedInHeadAnim(bool bLeftPunch)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.PlayPunchedInHeadAnim", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLeftPunch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateCinematicCamExtraRot
    /// </summary>
    public unsafe virtual void UpdateCinematicCamExtraRot(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdateCinematicCamExtraRot", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoesCameraMaintainLos
    /// </summary>
    public unsafe virtual bool DoesCameraMaintainLos(BmSDK.BmGame.RInGameCinematicCam CinematicCamera)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.DoesCameraMaintainLos", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CinematicCamera, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: StopCinematicCameraAnim
    /// </summary>
    public unsafe virtual void StopCinematicCameraAnim(float BlendTime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StopCinematicCameraAnim", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BlendFromCinematicToGrundyCam
    /// </summary>
    public unsafe virtual void BlendFromCinematicToGrundyCam()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.BlendFromCinematicToGrundyCam", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayCinematicCameraAnim
    /// </summary>
    public unsafe virtual bool PlayCinematicCameraAnim(BmSDK.FName AnimName, System.Numerics.Vector3 rootLoc, BmSDK.Rotator RootRot, float BlendTime = default, float StartTime = default, bool bCheckOcclusion = default, bool bBlendBackToGrundy = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.PlayCinematicCameraAnim", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rootLoc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RootRot, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendTime, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTime, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckOcclusion, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBlendBackToGrundy, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    /// <summary>
    /// Function: StopMeleeCamera
    /// </summary>
    public unsafe override void StopMeleeCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StopMeleeCamera", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: KillAllMaggots
    /// </summary>
    public unsafe virtual void KillAllMaggots()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.KillAllMaggots", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnSingleMaggot
    /// </summary>
    public unsafe override void SpawnSingleMaggot(System.Numerics.Vector3 SpawnLoc, BmSDK.Rotator SpawnRot)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SpawnSingleMaggot", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckMaggots
    /// </summary>
    public unsafe virtual void CheckMaggots()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.CheckMaggots", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsVulnerableToTakedown
    /// </summary>
    public unsafe override bool IsVulnerableToTakedown(BmSDK.FString takedown)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.IsVulnerableToTakedown", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: IsAwareOfPlayer
    /// </summary>
    public unsafe override bool IsAwareOfPlayer(BmSDK.BmGame.RPawnPlayer PlayerPawn, BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.IsAwareOfPlayer", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: HeartGone
    /// </summary>
    public unsafe virtual void HeartGone()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.HeartGone", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HeartRemoved
    /// </summary>
    public unsafe virtual void HeartRemoved()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.HeartRemoved", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HeartPunch
    /// </summary>
    public unsafe virtual void HeartPunch()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.HeartPunch", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: KillAllGroundRings
    /// </summary>
    public unsafe virtual void KillAllGroundRings()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.KillAllGroundRings", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateFloorRings
    /// </summary>
    public unsafe virtual void UpdateFloorRings(float UpdateTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdateFloorRings", true);
        byte* paramsPtr = stackalloc byte[172];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: KillAllFloorSparks
    /// </summary>
    public unsafe virtual void KillAllFloorSparks()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.KillAllFloorSparks", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateFloorSparks
    /// </summary>
    public unsafe virtual void UpdateFloorSparks(float UpdateTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdateFloorSparks", true);
        byte* paramsPtr = stackalloc byte[148];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnFloorRing
    /// </summary>
    public unsafe virtual void SpawnFloorRing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SpawnFloorRing", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnFloorRings
    /// </summary>
    public unsafe virtual void SpawnFloorRings()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SpawnFloorRings", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartFloorSparks
    /// </summary>
    public unsafe virtual void StartFloorSparks()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StartFloorSparks", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnElectricAttackExtras
    /// </summary>
    public unsafe virtual void SpawnElectricAttackExtras()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SpawnElectricAttackExtras", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReadSmashNotifies
    /// </summary>
    public unsafe virtual void ReadSmashNotifies()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.ReadSmashNotifies", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateFirePatchs
    /// </summary>
    public unsafe virtual void UpdateFirePatchs(float UpdateTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdateFirePatchs", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SwingStartedCallback
    /// </summary>
    public unsafe virtual void SwingStartedCallback(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId NextAnim)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SwingStartedCallback", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextAnim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ElectrocuteBatman
    /// </summary>
    public unsafe virtual void ElectrocuteBatman(System.Numerics.Vector3 fromLocation, BmSDK.BmGame.RPawnCombat Damager, bool canDoDamage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.ElectrocuteBatman", true);
        byte* paramsPtr = stackalloc byte[280];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fromLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damager, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(canDoDamage, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FinishBMCombatMoveNotify
    /// </summary>
    public unsafe virtual void FinishBMCombatMoveNotify()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.FinishBMCombatMoveNotify", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FinishBMCombatMove
    /// </summary>
    public unsafe virtual void FinishBMCombatMove(bool FinishAnim = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.FinishBMCombatMove", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishAnim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartBMCombatMove
    /// </summary>
    public unsafe virtual void StartBMCombatMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StartBMCombatMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SwapChainEnds
    /// </summary>
    public unsafe virtual void SwapChainEnds()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SwapChainEnds", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReleaseChains
    /// </summary>
    public unsafe virtual void ReleaseChains()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.ReleaseChains", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HoldChains
    /// </summary>
    public unsafe virtual void HoldChains()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.HoldChains", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartBMCrushMove
    /// </summary>
    public unsafe virtual void StartBMCrushMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StartBMCrushMove", true);
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChangeMeshMatsForXray
    /// </summary>
    public unsafe virtual void ChangeMeshMatsForXray(int meshIndex, BmSDK.Engine.SkeletalMeshComponent ChangeMesh, BmSDK.Engine.SkeletalMeshComponent DefaultMesh, BmSDK.Engine.MaterialInterface OverrideMaterial, float translucencyPri)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.ChangeMeshMatsForXray", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(meshIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChangeMesh, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefaultMesh, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMaterial, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(translucencyPri, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChangeRopeMatsForXray
    /// </summary>
    public unsafe virtual void ChangeRopeMatsForXray(BmSDK.BmGame.RGrundyRopeComponent ChangeMesh)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.ChangeRopeMatsForXray", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChangeMesh, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetPropsInXray
    /// </summary>
    public unsafe override void SetPropsInXray(bool bActivate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SetPropsInXray", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe override void SetInXrayMode(bool show, bool bForceOff)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SetInXrayMode", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(show, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RechargeHealth
    /// </summary>
    public unsafe virtual void RechargeHealth(float UpdateTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.RechargeHealth", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DegenerateHealth
    /// </summary>
    public unsafe virtual void DegenerateHealth(float UpdateTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.DegenerateHealth", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateRotatingConductors
    /// </summary>
    public unsafe virtual void UpdateRotatingConductors(float UpdateTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdateRotatingConductors", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DeactivateElectricityPillar
    /// </summary>
    public unsafe virtual void DeactivateElectricityPillar(int Index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.DeactivateElectricityPillar", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActivateElectricityPillar
    /// </summary>
    public unsafe virtual void ActivateElectricityPillar(int I)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.ActivateElectricityPillar", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(I, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DeactivateAllElectricityPillars
    /// </summary>
    public unsafe virtual void DeactivateAllElectricityPillars()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.DeactivateAllElectricityPillars", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActivateAllElectricityPillars
    /// </summary>
    public unsafe virtual void ActivateAllElectricityPillars()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.ActivateAllElectricityPillars", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckForPillarsHittingMaggots
    /// </summary>
    public unsafe virtual void CheckForPillarsHittingMaggots()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.CheckForPillarsHittingMaggots", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateElectricityPillars
    /// </summary>
    public unsafe virtual void UpdateElectricityPillars()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdateElectricityPillars", true);
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitElectricityPillars
    /// </summary>
    public unsafe virtual void InitElectricityPillars()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.InitElectricityPillars", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UndoPillarDisabling
    /// </summary>
    public unsafe virtual void UndoPillarDisabling()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UndoPillarDisabling", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisablePillar
    /// </summary>
    public unsafe virtual void DisablePillar(int Index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.DisablePillar", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdatePillarDisabling
    /// </summary>
    public unsafe virtual void UpdatePillarDisabling(float UpdateTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdatePillarDisabling", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RechargeInCallback
    /// </summary>
    public unsafe virtual void RechargeInCallback(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId NextAnim)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.RechargeInCallback", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextAnim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PauseCape
    /// </summary>
    public unsafe virtual void PauseCape()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.PauseCape", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetSinglePadState
    /// </summary>
    public unsafe virtual void SetSinglePadState(int padIndex, BmSDK.BmScript.RGrundyDrumPad.eDrumPadLightStates padState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SetSinglePadState", true);
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(padIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(padState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetPadState
    /// </summary>
    public unsafe virtual void SetPadState(BmSDK.BmScript.RGrundyDrumPad.eDrumPadLightStates padState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SetPadState", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(padState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetGrundymaticMode
    /// </summary>
    public unsafe virtual void SetGrundymaticMode(bool bEnable)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SetGrundymaticMode", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnable, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CrushKickNotify
    /// </summary>
    public unsafe virtual void CrushKickNotify()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.CrushKickNotify", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SurpriseNotify
    /// </summary>
    public unsafe virtual void SurpriseNotify()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SurpriseNotify", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnableRoomCogs
    /// </summary>
    public unsafe virtual void EnableRoomCogs(bool bEnabled, bool bInstant = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.EnableRoomCogs", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstant, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnablePadCogs
    /// </summary>
    public unsafe virtual void EnablePadCogs(int padIndex, bool bEnabled, bool bInstant = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.EnablePadCogs", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(padIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstant, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateSingleCogMatineeSpeed
    /// </summary>
    public unsafe virtual void UpdateSingleCogMatineeSpeed(float UpdateTime, BmSDK.Engine.SeqAct_Interp Matinee, bool bEnabled)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdateSingleCogMatineeSpeed", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Matinee, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateCogSpeeds
    /// </summary>
    public unsafe virtual void UpdateCogSpeeds(float UpdateTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdateCogSpeeds", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetClosestActivePadLocation
    /// </summary>
    public unsafe virtual bool GetClosestActivePadLocation(System.Numerics.Vector3 TestLoc, ref System.Numerics.Vector3 ResultLoc, bool bIgnoreIdlePads = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.GetClosestActivePadLocation", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResultLoc, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreIdlePads, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ResultLoc = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: GetSafeDirectionForKnockBack
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetSafeDirectionForKnockBack(System.Numerics.Vector3 DesiredDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.GetSafeDirectionForKnockBack", true);
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: AreMaggotsActive
    /// </summary>
    public unsafe virtual bool AreMaggotsActive()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.AreMaggotsActive", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DoOverchargeExplosion
    /// </summary>
    public unsafe virtual void DoOverchargeExplosion(int Index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.DoOverchargeExplosion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverchargeExplosion10
    /// </summary>
    public unsafe virtual void OverchargeExplosion10()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.OverchargeExplosion10", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverchargeExplosion9
    /// </summary>
    public unsafe virtual void OverchargeExplosion9()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.OverchargeExplosion9", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverchargeExplosion8
    /// </summary>
    public unsafe virtual void OverchargeExplosion8()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.OverchargeExplosion8", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverchargeExplosion7
    /// </summary>
    public unsafe virtual void OverchargeExplosion7()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.OverchargeExplosion7", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverchargeExplosion6
    /// </summary>
    public unsafe virtual void OverchargeExplosion6()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.OverchargeExplosion6", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverchargeExplosion5
    /// </summary>
    public unsafe virtual void OverchargeExplosion5()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.OverchargeExplosion5", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverchargeExplosion4
    /// </summary>
    public unsafe virtual void OverchargeExplosion4()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.OverchargeExplosion4", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverchargeExplosion3
    /// </summary>
    public unsafe virtual void OverchargeExplosion3()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.OverchargeExplosion3", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverchargeExplosion2
    /// </summary>
    public unsafe virtual void OverchargeExplosion2()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.OverchargeExplosion2", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverchargeExplosion1
    /// </summary>
    public unsafe virtual void OverchargeExplosion1()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.OverchargeExplosion1", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: KickOffRibs
    /// </summary>
    public unsafe virtual void KickOffRibs()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.KickOffRibs", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopBeamAudioLoop
    /// </summary>
    public unsafe virtual void StopBeamAudioLoop()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StopBeamAudioLoop", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartBeamAudioLoop
    /// </summary>
    public unsafe virtual void StartBeamAudioLoop()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StartBeamAudioLoop", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StoppedRecharging
    /// </summary>
    public unsafe virtual void StoppedRecharging()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StoppedRecharging", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartedRecharging
    /// </summary>
    public unsafe virtual void StartedRecharging()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StartedRecharging", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IntroCinematicFinished
    /// </summary>
    public unsafe override void IntroCinematicFinished()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.IntroCinematicFinished", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverloadBallCogs
    /// </summary>
    public unsafe virtual void OverloadBallCogs()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.OverloadBallCogs", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateBallCogs
    /// </summary>
    public unsafe virtual void UpdateBallCogs()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdateBallCogs", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayCapeAnim
    /// </summary>
    public unsafe virtual void PlayCapeAnim(BmSDK.FName AnimName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.PlayCapeAnim", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnFootstepParticles
    /// </summary>
    public unsafe override void SpawnFootstepParticles(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact, System.Numerics.Vector3 FootLocation, BmSDK.BmGame.RPhysicalMaterialProperty Property)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SpawnFootstepParticles", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FootLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Property, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateVeinSecondaryPulse
    /// </summary>
    public unsafe virtual void UpdateVeinSecondaryPulse(float UpdateTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdateVeinSecondaryPulse", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateVeinColour
    /// </summary>
    public unsafe virtual void UpdateVeinColour(float UpdateTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdateVeinColour", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetUppercutAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetUppercutAnimSet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.GetUppercutAnimSet", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetUppercutAnimName
    /// </summary>
    public unsafe override BmSDK.FName GetUppercutAnimName()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.GetUppercutAnimName", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SmashHitNotify
    /// </summary>
    public unsafe virtual void SmashHitNotify()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SmashHitNotify", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetOnKnees
    /// </summary>
    public unsafe virtual void SetOnKnees()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SetOnKnees", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnableVeins
    /// </summary>
    public unsafe virtual void EnableVeins(bool enableOnBody, bool enableOnHeart)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.EnableVeins", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(enableOnBody, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(enableOnHeart, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateBeamSoundPositions
    /// </summary>
    public unsafe virtual void UpdateBeamSoundPositions()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.UpdateBeamSoundPositions", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartGrowingBlockingCylinder
    /// </summary>
    public unsafe virtual void StartGrowingBlockingCylinder()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.StartGrowingBlockingCylinder", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoBiggestRumble
    /// </summary>
    public unsafe virtual void DoBiggestRumble()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.DoBiggestRumble", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float UpdateTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.Tick", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetHealth
    /// </summary>
    public unsafe override void SetHealth()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossGrundy.SetHealth", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: eSwingRumbleState
    /// </summary>
    public enum eSwingRumbleState : byte
    {
        ESRR_OutOfRange = 0,
        ESRR_Weak = 1,
        ESRR_Strong = 2,
        ESRR_MAX = 3,
    }

    /// <summary>
    /// Enum: eGrundyVeinColourScheme
    /// </summary>
    public enum eGrundyVeinColourScheme : byte
    {
        eGVCS_0 = 0,
        eGVCS_1 = 1,
        eGVCS_Health = 2,
        eGVCS_Charging = 3,
        eGVCS_MAX = 4,
    }

    /// <summary>
    /// Enum: eGrundyHelpTextState
    /// </summary>
    public enum eGrundyHelpTextState : byte
    {
        eGHTS_None = 0,
        eGHTS_Gel = 1,
        eGHTS_Detonate = 2,
        eGHTS_Batarang = 3,
        eGHTS_DetectiveMode = 4,
        eGHTS_SpellItOut = 5,
        eGHTS_MAX = 6,
    }

    /// <summary>
    /// Struct: FmeshSavedXrayMats
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 13)]
    public partial record struct FmeshSavedXrayMats
    {
        /// <summary>
        /// ArrayProperty: SavedMats
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> SavedMats
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: dpg
        /// </summary>
        public unsafe BmSDK.Engine.Scene.ESceneDepthPriorityGroup dpg
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Scene.ESceneDepthPriorityGroup>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: eGrundyBeatMatch
    /// </summary>
    public enum eGrundyBeatMatch : byte
    {
        eGBM_BEFORE = 0,
        eGBM_AFTER = 1,
        eGBM_AFTER_PRECLOSEANIM = 2,
        eGBM_EITHER = 3,
        eGBM_MAX = 4,
    }

    /// <summary>
    /// Struct: FRotatingConductor
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FRotatingConductor
    {
        /// <summary>
        /// ArrayProperty: conductorPieces
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.InterpActor> conductorPieces
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.InterpActor>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FElectricPillarPFX
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FElectricPillarPFX
    {
        /// <summary>
        /// StructProperty: baseLoc
        /// </summary>
        public unsafe System.Numerics.Vector3 baseLoc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bOn
        /// </summary>
        public unsafe bool bOn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bForceOff
        /// </summary>
        public unsafe bool bForceOff
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: unForceOffTime
        /// </summary>
        public unsafe float unForceOffTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ComponentProperty: VerticalPillar
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent VerticalPillar
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ComponentProperty: VerticalPillarExtra
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent VerticalPillarExtra
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ComponentProperty: UpsideDownPillar
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent UpsideDownPillar
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ComponentProperty: CeilingToGrundy
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent CeilingToGrundy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ComponentProperty: CeilingToGrundyExtra
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent CeilingToGrundyExtra
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ComponentProperty: KickStart
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent KickStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ComponentProperty: Warmup
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent Warmup
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// ComponentProperty: BeamEnd
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent BeamEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
    }

    /// <summary>
    /// Struct: FFloorRing
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FFloorRing
    {
        /// <summary>
        /// StructProperty: centre
        /// </summary>
        public unsafe System.Numerics.Vector3 centre
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Radius
        /// </summary>
        public unsafe float Radius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: Thickness
        /// </summary>
        public unsafe float Thickness
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: Speed
        /// </summary>
        public unsafe float Speed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: PFXIndex
        /// </summary>
        public unsafe int PFXIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FElectrifiedAttackData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FElectrifiedAttackData
    {
        /// <summary>
        /// BoolProperty: bSpawnSparks
        /// </summary>
        public unsafe bool bSpawnSparks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bSpawnRings
        /// </summary>
        public unsafe bool bSpawnRings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: E_SwingChainState
    /// </summary>
    public enum E_SwingChainState : byte
    {
        E_SwingChainState_Anim = 0,
        E_SwingChainState_ToBM = 1,
        E_SwingChainState_ToAnim = 2,
        E_SwingChainState_MAX = 3,
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: GrundyMesh
    /// </summary>
    public InlineArray<BmSDK.Engine.SkeletalMeshComponent> GrundyMesh => new(2, Ptr + 7124, 4, this);

    /// <summary>
    /// ComponentProperty: GrundyMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent GrundyMesh_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7124); }
    }
    /// <summary>
    /// ComponentProperty: GrundyMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent GrundyMesh_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7128); }
    }

    /// <summary>
    /// ComponentProperty: LeftArmChainMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent LeftArmChainMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7132); }
    }

    /// <summary>
    /// ComponentProperty: RightArmChainMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent RightArmChainMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7136); }
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: ChestMesh
    /// </summary>
    public InlineArray<BmSDK.Engine.SkeletalMeshComponent> ChestMesh => new(2, Ptr + 7140, 4, this);

    /// <summary>
    /// ComponentProperty: ChestMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent ChestMesh_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7140); }
    }
    /// <summary>
    /// ComponentProperty: ChestMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent ChestMesh_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7144); }
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: HeartMesh
    /// </summary>
    public InlineArray<BmSDK.Engine.SkeletalMeshComponent> HeartMesh => new(2, Ptr + 7148, 4, this);

    /// <summary>
    /// ComponentProperty: HeartMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent HeartMesh_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7148); }
    }
    /// <summary>
    /// ComponentProperty: HeartMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent HeartMesh_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7152); }
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: HeartDettachedMesh
    /// </summary>
    public InlineArray<BmSDK.Engine.SkeletalMeshComponent> HeartDettachedMesh => new(2, Ptr + 7156, 4, this);

    /// <summary>
    /// ComponentProperty: HeartDettachedMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent HeartDettachedMesh_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7156); }
    }
    /// <summary>
    /// ComponentProperty: HeartDettachedMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent HeartDettachedMesh_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7160); }
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: RibsMeshes
    /// </summary>
    public InlineArray<BmSDK.Engine.SkeletalMeshComponent> RibsMeshes => new(4, Ptr + 7164, 4, this);

    /// <summary>
    /// ComponentProperty: RibsMeshes
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent RibsMeshes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7164); }
    }
    /// <summary>
    /// ComponentProperty: RibsMeshes
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent RibsMeshes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7168); }
    }
    /// <summary>
    /// ComponentProperty: RibsMeshes
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent RibsMeshes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7172); }
    }
    /// <summary>
    /// ComponentProperty: RibsMeshes
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent RibsMeshes_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7176); }
    }

    /// <summary>
    /// ComponentProperty: CoatMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent CoatMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7180); }
    }

    /// <summary>
    /// ComponentProperty: BeltMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent BeltMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7184); }
    }

    /// <summary>
    /// ComponentProperty: RightRope
    /// </summary>
    public unsafe BmSDK.BmGame.RGrundyRopeComponent RightRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrundyRopeComponent>(Ptr + 7188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7188); }
    }

    /// <summary>
    /// ComponentProperty: LeftRope
    /// </summary>
    public unsafe BmSDK.BmGame.RGrundyRopeComponent LeftRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrundyRopeComponent>(Ptr + 7192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7192); }
    }

    /// <summary>
    /// FloatProperty: grundyAttackStartTime
    /// </summary>
    public unsafe float grundyAttackStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7196); }
    }

    /// <summary>
    /// StructProperty: currentTransitionID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId currentTransitionID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 7200);

    /// <summary>
    /// StructProperty: BMTransitionID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId BMTransitionID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 7204);

    /// <summary>
    /// StructProperty: leapStartPos_BM
    /// </summary>
    public unsafe ref System.Numerics.Vector3 leapStartPos_BM
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7208);

    /// <summary>
    /// StructProperty: leapStartDir_BMToGrundy
    /// </summary>
    public unsafe ref BmSDK.Rotator leapStartDir_BMToGrundy
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 7220);

    /// <summary>
    /// ByteProperty: swingChainState
    /// </summary>
    public unsafe BmSDK.BmScript.RPawnBossGrundy.E_SwingChainState swingChainState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnBossGrundy.E_SwingChainState>(Ptr + 7232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7232); }
    }

    /// <summary>
    /// ByteProperty: nextChosenAttack
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnBossGrundyBase.EGrundyAttacks nextChosenAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossGrundyBase.EGrundyAttacks>(Ptr + 7233); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7233); }
    }

    /// <summary>
    /// ByteProperty: currHelpTextState
    /// </summary>
    public unsafe BmSDK.BmScript.RPawnBossGrundy.eGrundyHelpTextState currHelpTextState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnBossGrundy.eGrundyHelpTextState>(Ptr + 7234); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7234); }
    }

    /// <summary>
    /// ByteProperty: prevHelpTextState
    /// </summary>
    public unsafe BmSDK.BmScript.RPawnBossGrundy.eGrundyHelpTextState prevHelpTextState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnBossGrundy.eGrundyHelpTextState>(Ptr + 7235); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7235); }
    }

    /// <summary>
    /// ByteProperty: veinColourScheme
    /// </summary>
    public unsafe BmSDK.BmScript.RPawnBossGrundy.eGrundyVeinColourScheme veinColourScheme
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnBossGrundy.eGrundyVeinColourScheme>(Ptr + 7236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7236); }
    }

    /// <summary>
    /// ByteProperty: swingRumbleState
    /// </summary>
    public unsafe BmSDK.BmScript.RPawnBossGrundy.eSwingRumbleState swingRumbleState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnBossGrundy.eSwingRumbleState>(Ptr + 7237); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7237); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: chainExtraLength
    /// </summary>
    public InlineArray<float> chainExtraLength => new(2, Ptr + 7240, 4, this);

    /// <summary>
    /// FloatProperty: chainExtraLength
    /// </summary>
    public unsafe float chainExtraLength_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7240); }
    }
    /// <summary>
    /// FloatProperty: chainExtraLength
    /// </summary>
    public unsafe float chainExtraLength_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7244); }
    }

    /// <summary>
    /// ObjectProperty: bmCombatMove
    /// </summary>
    public unsafe BmSDK.BmScript.RCombatMove_BatmanGrabbedByGrundy bmCombatMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RCombatMove_BatmanGrabbedByGrundy>(Ptr + 7248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7248); }
    }

    /// <summary>
    /// ArrayProperty: ThrowTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDummyTarget> ThrowTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDummyTarget>>(Ptr + 7252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7252); }
    }

    /// <summary>
    /// IntProperty: chosenThrowTarget
    /// </summary>
    public unsafe int chosenThrowTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7264); }
    }

    /// <summary>
    /// BoolProperty: bFinishedLeapPt1
    /// </summary>
    public unsafe bool bFinishedLeapPt1
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bAdjustingTransitionTarget
    /// </summary>
    public unsafe bool bAdjustingTransitionTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bInControllableCinematicCam
    /// </summary>
    public unsafe bool bInControllableCinematicCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bPlayingCinematicCamAnim
    /// </summary>
    public unsafe bool bPlayingCinematicCamAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: heartRemovalTriggered
    /// </summary>
    public unsafe bool heartRemovalTriggered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bCrushFinished
    /// </summary>
    public unsafe bool bCrushFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bPlayingCrushIdle
    /// </summary>
    public unsafe bool bPlayingCrushIdle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bHelpTextSupressed
    /// </summary>
    public unsafe bool bHelpTextSupressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bPadHasEverBeenBlownUp
    /// </summary>
    public unsafe bool bPadHasEverBeenBlownUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bCanHeadtrackBM
    /// </summary>
    public unsafe bool bCanHeadtrackBM
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bInLateCounterWindow
    /// </summary>
    public unsafe bool bInLateCounterWindow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bSuccessfulCounter_Early
    /// </summary>
    public unsafe bool bSuccessfulCounter_Early
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: playingMeleeCam
    /// </summary>
    public unsafe bool playingMeleeCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bDeferredDaze
    /// </summary>
    public unsafe bool bDeferredDaze
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bFinishedTransIn
    /// </summary>
    public unsafe bool bFinishedTransIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bElectricsStarted
    /// </summary>
    public unsafe bool bElectricsStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: nextAttackShouldBeMaggots
    /// </summary>
    public unsafe bool nextAttackShouldBeMaggots
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bDrawPadDebug
    /// </summary>
    public unsafe bool bDrawPadDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bRecharging
    /// </summary>
    public unsafe bool bRecharging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bRechargeFinished
    /// </summary>
    public unsafe bool bRechargeFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bNeedToRestartCape
    /// </summary>
    public unsafe bool bNeedToRestartCape
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bNeedDeferredPauseCape
    /// </summary>
    public unsafe bool bNeedDeferredPauseCape
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bStartedCrushMove
    /// </summary>
    public unsafe bool bStartedCrushMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bDoneFirstPillarDisable
    /// </summary>
    public unsafe bool bDoneFirstPillarDisable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bHadRECRecharge
    /// </summary>
    public unsafe bool bHadRECRecharge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bRoomCogsOn
    /// </summary>
    public unsafe bool bRoomCogsOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bHeartBeatAnimEnabled
    /// </summary>
    public unsafe bool bHeartBeatAnimEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bDonePhysInit
    /// </summary>
    public unsafe bool bDonePhysInit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bPluggedIn
    /// </summary>
    public unsafe bool bPluggedIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bFailBeams
    /// </summary>
    public unsafe bool bFailBeams
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bExtraBeams
    /// </summary>
    public unsafe bool bExtraBeams
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bHasSetRoomDamageState
    /// </summary>
    public unsafe bool bHasSetRoomDamageState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7268); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7268); }
    }

    /// <summary>
    /// BoolProperty: bSkippedToFirePostSequence
    /// </summary>
    public unsafe bool bSkippedToFirePostSequence
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// BoolProperty: bSkippedToElectroPostSequence
    /// </summary>
    public unsafe bool bSkippedToElectroPostSequence
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// BoolProperty: bFinishedIgniteCloseup
    /// </summary>
    public unsafe bool bFinishedIgniteCloseup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// BoolProperty: bDoneWindowLengthLog
    /// </summary>
    public unsafe bool bDoneWindowLengthLog
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// BoolProperty: bInIgniteCameraCut
    /// </summary>
    public unsafe bool bInIgniteCameraCut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// BoolProperty: bSmashHasHit
    /// </summary>
    public unsafe bool bSmashHasHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// BoolProperty: bSwingGotWithinRange
    /// </summary>
    public unsafe bool bSwingGotWithinRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// BoolProperty: bAddedExtraHighSwing
    /// </summary>
    public unsafe bool bAddedExtraHighSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// BoolProperty: switchToAnim
    /// </summary>
    public unsafe bool switchToAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// BoolProperty: switchToPhys
    /// </summary>
    public unsafe bool switchToPhys
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// BoolProperty: dbgPadDetonated
    /// </summary>
    public unsafe bool dbgPadDetonated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// BoolProperty: bWaitingForQueuedIn
    /// </summary>
    public unsafe bool bWaitingForQueuedIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// BoolProperty: beamLoopPlaying
    /// </summary>
    public unsafe bool beamLoopPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// BoolProperty: bFakeDeathVolumesEnabled
    /// </summary>
    public unsafe bool bFakeDeathVolumesEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// BoolProperty: bBorrowedBMHealth
    /// </summary>
    public unsafe bool bBorrowedBMHealth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// BoolProperty: bHeartRemoved
    /// </summary>
    public unsafe bool bHeartRemoved
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// BoolProperty: bDoneFirstRecharge
    /// </summary>
    public unsafe bool bDoneFirstRecharge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// BoolProperty: bNoIgniteRumble
    /// </summary>
    public unsafe bool bNoIgniteRumble
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// BoolProperty: bGrowingBlockingCylinder
    /// </summary>
    public unsafe bool bGrowingBlockingCylinder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7272); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7272); }
    }

    /// <summary>
    /// ArrayProperty: grundyMaterialConstants
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> grundyMaterialConstants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 7276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7276); }
    }

    /// <summary>
    /// ArrayProperty: grundyHeartMICs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> grundyHeartMICs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 7288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7288); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: TetherPoints
    /// </summary>
    public InlineArray<BmSDK.Engine.Actor> TetherPoints => new(2, Ptr + 7300, 4, this);

    /// <summary>
    /// ObjectProperty: TetherPoints
    /// </summary>
    public unsafe BmSDK.Engine.Actor TetherPoints_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 7300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7300); }
    }
    /// <summary>
    /// ObjectProperty: TetherPoints
    /// </summary>
    public unsafe BmSDK.Engine.Actor TetherPoints_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 7304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7304); }
    }

    /// <summary>
    /// ObjectProperty: OverloadBMTeleport
    /// </summary>
    public unsafe BmSDK.Engine.Actor OverloadBMTeleport
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 7308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7308); }
    }

    /// <summary>
    /// ObjectProperty: IgniteBMTeleport1
    /// </summary>
    public unsafe BmSDK.Engine.Actor IgniteBMTeleport1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 7312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7312); }
    }

    /// <summary>
    /// ObjectProperty: IgniteBMTeleport2
    /// </summary>
    public unsafe BmSDK.Engine.Actor IgniteBMTeleport2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 7316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7316); }
    }

    /// <summary>
    /// ObjectProperty: IgnitePengLoc
    /// </summary>
    public unsafe BmSDK.Engine.Actor IgnitePengLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 7320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7320); }
    }

    /// <summary>
    /// ArrayProperty: DrumPads
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RGrundyDrumPad> DrumPads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RGrundyDrumPad>>(Ptr + 7324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7324); }
    }

    /// <summary>
    /// ObjectProperty: ballCogs
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshActor ballCogs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshActor>(Ptr + 7336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7336); }
    }

    /// <summary>
    /// ObjectProperty: ballCogsAnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence ballCogsAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 7340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7340); }
    }

    /// <summary>
    /// ComponentProperty: BodyIgnitePFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BodyIgnitePFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7344); }
    }

    /// <summary>
    /// ComponentProperty: ChestIgnitePFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ChestIgnitePFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7348); }
    }

    /// <summary>
    /// ComponentProperty: BallSkimPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BallSkimPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7352); }
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: FireOnBallsPFX
    /// </summary>
    public InlineArray<BmSDK.Engine.ParticleSystemComponent> FireOnBallsPFX => new(2, Ptr + 7356, 4, this);

    /// <summary>
    /// ComponentProperty: FireOnBallsPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FireOnBallsPFX_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7356); }
    }
    /// <summary>
    /// ComponentProperty: FireOnBallsPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FireOnBallsPFX_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7360); }
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: ElectricityOnBallsPFX
    /// </summary>
    public InlineArray<BmSDK.Engine.ParticleSystemComponent> ElectricityOnBallsPFX => new(2, Ptr + 7364, 4, this);

    /// <summary>
    /// ComponentProperty: ElectricityOnBallsPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ElectricityOnBallsPFX_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7364); }
    }
    /// <summary>
    /// ComponentProperty: ElectricityOnBallsPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ElectricityOnBallsPFX_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7368); }
    }

    /// <summary>
    /// StructProperty: ImpactScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ImpactScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 7372);

    /// <summary>
    /// StructProperty: lookRot
    /// </summary>
    public unsafe ref BmSDK.Rotator lookRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 7516);

    /// <summary>
    /// FloatProperty: timeSinceLook
    /// </summary>
    public unsafe float timeSinceLook
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7528); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: ChainWrapBoneNames
    /// </summary>
    public InlineArray<BmSDK.FName> ChainWrapBoneNames => new(2, Ptr + 7532, 8, this);

    /// <summary>
    /// NameProperty: ChainWrapBoneNames
    /// </summary>
    public unsafe BmSDK.FName ChainWrapBoneNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7532); }
    }
    /// <summary>
    /// NameProperty: ChainWrapBoneNames
    /// </summary>
    public unsafe BmSDK.FName ChainWrapBoneNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7540); }
    }

    /// <summary>
    /// IntProperty: numPadsDetonatedThisStage
    /// </summary>
    public unsafe int numPadsDetonatedThisStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7548); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: GeneratorHitReacts
    /// </summary>
    public InlineArray<BmSDK.FName> GeneratorHitReacts => new(2, Ptr + 7552, 8, this);

    /// <summary>
    /// NameProperty: GeneratorHitReacts
    /// </summary>
    public unsafe BmSDK.FName GeneratorHitReacts_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7552); }
    }
    /// <summary>
    /// NameProperty: GeneratorHitReacts
    /// </summary>
    public unsafe BmSDK.FName GeneratorHitReacts_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7560); }
    }

    /// <summary>
    /// ObjectProperty: twoArmTetheredPos
    /// </summary>
    public unsafe BmSDK.Engine.Actor twoArmTetheredPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 7568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7568); }
    }

    /// <summary>
    /// IntProperty: numMaggotsToSpawn
    /// </summary>
    public unsafe int numMaggotsToSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7572); }
    }

    /// <summary>
    /// IntProperty: heartBoneIndex
    /// </summary>
    public unsafe int heartBoneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7576); }
    }

    /// <summary>
    /// StructProperty: nextElectrifiedAttackData
    /// </summary>
    public unsafe ref BmSDK.BmScript.RPawnBossGrundy.FElectrifiedAttackData nextElectrifiedAttackData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RPawnBossGrundy.FElectrifiedAttackData>(Ptr + 7580);

    /// <summary>
    /// FloatProperty: minElectricSmashDeviance
    /// </summary>
    public unsafe float minElectricSmashDeviance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7584); }
    }

    /// <summary>
    /// FloatProperty: maxElectricSmashDeviance
    /// </summary>
    public unsafe float maxElectricSmashDeviance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7588); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: floorRingSpeed
    /// </summary>
    public InlineArray<float> floorRingSpeed => new(3, Ptr + 7592, 4, this);

    /// <summary>
    /// FloatProperty: floorRingSpeed
    /// </summary>
    public unsafe float floorRingSpeed_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7592); }
    }
    /// <summary>
    /// FloatProperty: floorRingSpeed
    /// </summary>
    public unsafe float floorRingSpeed_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7596); }
    }
    /// <summary>
    /// FloatProperty: floorRingSpeed
    /// </summary>
    public unsafe float floorRingSpeed_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7600); }
    }

    /// <summary>
    /// FloatProperty: floorRingMaxRadius
    /// </summary>
    public unsafe float floorRingMaxRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7604); }
    }

    /// <summary>
    /// FloatProperty: floorRingThickness
    /// </summary>
    public unsafe float floorRingThickness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7608); }
    }

    /// <summary>
    /// IntProperty: minFloorRingsToSpawn
    /// </summary>
    public unsafe int minFloorRingsToSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7612); }
    }

    /// <summary>
    /// IntProperty: maxFloorRingsToSpawn
    /// </summary>
    public unsafe int maxFloorRingsToSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7616); }
    }

    /// <summary>
    /// FloatProperty: gapBetweenFloorRings
    /// </summary>
    public unsafe float gapBetweenFloorRings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7620); }
    }

    /// <summary>
    /// FloatProperty: ringFXBaseSize
    /// </summary>
    public unsafe float ringFXBaseSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7624); }
    }

    /// <summary>
    /// FloatProperty: crushShakeAmpX
    /// </summary>
    public unsafe float crushShakeAmpX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7628); }
    }

    /// <summary>
    /// FloatProperty: crushShakeAmpY
    /// </summary>
    public unsafe float crushShakeAmpY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7632); }
    }

    /// <summary>
    /// FloatProperty: crushShakeAmpZ
    /// </summary>
    public unsafe float crushShakeAmpZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7636); }
    }

    /// <summary>
    /// FloatProperty: crushShakeLocFreq
    /// </summary>
    public unsafe float crushShakeLocFreq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7640); }
    }

    /// <summary>
    /// FloatProperty: crushShakeRotAmpX
    /// </summary>
    public unsafe float crushShakeRotAmpX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7644); }
    }

    /// <summary>
    /// FloatProperty: crushShakeRotAmpY
    /// </summary>
    public unsafe float crushShakeRotAmpY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7648); }
    }

    /// <summary>
    /// FloatProperty: crushShakeRotAmpZ
    /// </summary>
    public unsafe float crushShakeRotAmpZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7652); }
    }

    /// <summary>
    /// FloatProperty: crushShakeRotFreq
    /// </summary>
    public unsafe float crushShakeRotFreq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7656); }
    }

    /// <summary>
    /// FloatProperty: crushFreqDropPower
    /// </summary>
    public unsafe float crushFreqDropPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7660); }
    }

    /// <summary>
    /// FloatProperty: crushFreqDropFactor
    /// </summary>
    public unsafe float crushFreqDropFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7664); }
    }

    /// <summary>
    /// FloatProperty: crushShakeDuration
    /// </summary>
    public unsafe float crushShakeDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7668); }
    }

    /// <summary>
    /// FloatProperty: nextCrushShakeTime
    /// </summary>
    public unsafe float nextCrushShakeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7672); }
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: FloorRingPFX
    /// </summary>
    public InlineArray<BmSDK.Engine.ParticleSystemComponent> FloorRingPFX => new(8, Ptr + 7676, 4, this);

    /// <summary>
    /// ComponentProperty: FloorRingPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorRingPFX_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7676); }
    }
    /// <summary>
    /// ComponentProperty: FloorRingPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorRingPFX_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7680); }
    }
    /// <summary>
    /// ComponentProperty: FloorRingPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorRingPFX_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7684); }
    }
    /// <summary>
    /// ComponentProperty: FloorRingPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorRingPFX_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7688); }
    }
    /// <summary>
    /// ComponentProperty: FloorRingPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorRingPFX_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7692); }
    }
    /// <summary>
    /// ComponentProperty: FloorRingPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorRingPFX_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7696); }
    }
    /// <summary>
    /// ComponentProperty: FloorRingPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorRingPFX_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7700); }
    }
    /// <summary>
    /// ComponentProperty: FloorRingPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorRingPFX_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7704); }
    }

    /// <summary>
    /// IntProperty: nextFloorRing
    /// </summary>
    public unsafe int nextFloorRing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7708); }
    }

    /// <summary>
    /// ArrayProperty: floorRings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RPawnBossGrundy.FFloorRing> floorRings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RPawnBossGrundy.FFloorRing>>(Ptr + 7712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7712); }
    }

    /// <summary>
    /// IntProperty: numFloorRingsToSpawn
    /// </summary>
    public unsafe int numFloorRingsToSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7724); }
    }

    /// <summary>
    /// FloatProperty: nextFloorRingSpawnTime
    /// </summary>
    public unsafe float nextFloorRingSpawnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7728); }
    }

    /// <summary>
    /// FloatProperty: floorRingSpawnInterval
    /// </summary>
    public unsafe float floorRingSpawnInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7732); }
    }

    /// <summary>
    /// StructProperty: SavedFloorRingSpawnPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SavedFloorRingSpawnPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7736);

    /// <summary>
    /// IntProperty: numConsecutiveElectricSmashes
    /// </summary>
    public unsafe int numConsecutiveElectricSmashes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7748); }
    }

    /// <summary>
    /// IntProperty: numConsecutiveElectricMaggots
    /// </summary>
    public unsafe int numConsecutiveElectricMaggots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7752); }
    }

    /// <summary>
    /// IntProperty: numConsecutiveElectricStomps
    /// </summary>
    public unsafe int numConsecutiveElectricStomps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7756); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: crushDPS
    /// </summary>
    public InlineArray<float> crushDPS => new(3, Ptr + 7760, 4, this);

    /// <summary>
    /// FloatProperty: crushDPS
    /// </summary>
    public unsafe float crushDPS_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7760); }
    }
    /// <summary>
    /// FloatProperty: crushDPS
    /// </summary>
    public unsafe float crushDPS_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7764); }
    }
    /// <summary>
    /// FloatProperty: crushDPS
    /// </summary>
    public unsafe float crushDPS_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7768); }
    }

    /// <summary>
    /// ObjectProperty: openGrundysHandMoveInstance
    /// </summary>
    public unsafe BmSDK.BmScript.RSpecialMoveInstance_OpenGrundysHand openGrundysHandMoveInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSpecialMoveInstance_OpenGrundysHand>(Ptr + 7772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7772); }
    }

    /// <summary>
    /// FloatProperty: crushScoreSpamInterval
    /// </summary>
    public unsafe float crushScoreSpamInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7776); }
    }

    /// <summary>
    /// FloatProperty: lastCrushScoreSpamTime
    /// </summary>
    public unsafe float lastCrushScoreSpamTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7780); }
    }

    /// <summary>
    /// FloatProperty: nextCrushOverlayTriggerTime
    /// </summary>
    public unsafe float nextCrushOverlayTriggerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7784); }
    }

    /// <summary>
    /// FloatProperty: accumulatedCrushDamage
    /// </summary>
    public unsafe float accumulatedCrushDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7788); }
    }

    /// <summary>
    /// FloatProperty: StruggleSpeedDecay
    /// </summary>
    public unsafe float StruggleSpeedDecay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7792); }
    }

    /// <summary>
    /// FloatProperty: MinStruggleSpeed
    /// </summary>
    public unsafe float MinStruggleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7796); }
    }

    /// <summary>
    /// FloatProperty: MaxStruggleSpeed
    /// </summary>
    public unsafe float MaxStruggleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7800); }
    }

    /// <summary>
    /// FloatProperty: StruggleButtonBonus
    /// </summary>
    public unsafe float StruggleButtonBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7804); }
    }

    /// <summary>
    /// FloatProperty: StruggleScore
    /// </summary>
    public unsafe float StruggleScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7808); }
    }

    /// <summary>
    /// FloatProperty: StruggleSpeed
    /// </summary>
    public unsafe float StruggleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7812); }
    }

    /// <summary>
    /// FloatProperty: electricSmashMaxDevAngle
    /// </summary>
    public unsafe float electricSmashMaxDevAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7816); }
    }

    /// <summary>
    /// FloatProperty: quickGelHelpTextDelay
    /// </summary>
    public unsafe float quickGelHelpTextDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7820); }
    }

    /// <summary>
    /// FloatProperty: detectiveHelpTextDelay
    /// </summary>
    public unsafe float detectiveHelpTextDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7824); }
    }

    /// <summary>
    /// FloatProperty: spellItOutHelpTextDelay
    /// </summary>
    public unsafe float spellItOutHelpTextDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7828); }
    }

    /// <summary>
    /// FloatProperty: timeTillGelHelpText
    /// </summary>
    public unsafe float timeTillGelHelpText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7832); }
    }

    /// <summary>
    /// FloatProperty: timeTillDetectiveModeHelpText
    /// </summary>
    public unsafe float timeTillDetectiveModeHelpText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7836); }
    }

    /// <summary>
    /// FloatProperty: timeTillSpellItOutHelpText
    /// </summary>
    public unsafe float timeTillSpellItOutHelpText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7840); }
    }

    /// <summary>
    /// FloatProperty: heartFXScaleModifier
    /// </summary>
    public unsafe float heartFXScaleModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7844); }
    }

    /// <summary>
    /// IntProperty: smashAngleMax_AcrossBody
    /// </summary>
    public unsafe int smashAngleMax_AcrossBody
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7848); }
    }

    /// <summary>
    /// IntProperty: smashAngleMax_OutFromBody
    /// </summary>
    public unsafe int smashAngleMax_OutFromBody
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7852); }
    }

    /// <summary>
    /// StructProperty: smashWeightReturnOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 smashWeightReturnOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7856);

    /// <summary>
    /// IntProperty: smashStartYaw
    /// </summary>
    public unsafe int smashStartYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7868); }
    }

    /// <summary>
    /// FloatProperty: smashAnimStartTime
    /// </summary>
    public unsafe float smashAnimStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7872); }
    }

    /// <summary>
    /// FloatProperty: smashBeginExtendTime
    /// </summary>
    public unsafe float smashBeginExtendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7876); }
    }

    /// <summary>
    /// FloatProperty: smashEndExtendTime
    /// </summary>
    public unsafe float smashEndExtendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7880); }
    }

    /// <summary>
    /// FloatProperty: smashExtendDuration
    /// </summary>
    public unsafe float smashExtendDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7884); }
    }

    /// <summary>
    /// FloatProperty: smashBeginRetractTime
    /// </summary>
    public unsafe float smashBeginRetractTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7888); }
    }

    /// <summary>
    /// FloatProperty: smashEndRetractTime
    /// </summary>
    public unsafe float smashEndRetractTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7892); }
    }

    /// <summary>
    /// FloatProperty: smashRetractDuration
    /// </summary>
    public unsafe float smashRetractDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7896); }
    }

    /// <summary>
    /// ObjectProperty: BlockingVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RDynamicBlockingVolume BlockingVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDynamicBlockingVolume>(Ptr + 7900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7900); }
    }

    /// <summary>
    /// ArrayProperty: fakeDeathBlockingVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDynamicBlockingVolume> fakeDeathBlockingVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDynamicBlockingVolume>>(Ptr + 7904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7904); }
    }

    /// <summary>
    /// FloatProperty: lastMusicMarkerTime
    /// </summary>
    public unsafe float lastMusicMarkerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7916); }
    }

    /// <summary>
    /// FloatProperty: fCheckCameraCollisionFromProportion
    /// </summary>
    public unsafe float fCheckCameraCollisionFromProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7920); }
    }

    /// <summary>
    /// FloatProperty: fCheckCameraCollisionToProportion
    /// </summary>
    public unsafe float fCheckCameraCollisionToProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7924); }
    }

    /// <summary>
    /// FloatProperty: swingAnimOriginalDuration
    /// </summary>
    public unsafe float swingAnimOriginalDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7928); }
    }

    /// <summary>
    /// FloatProperty: swingDistSpeedModifier
    /// </summary>
    public unsafe float swingDistSpeedModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7932); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: swingSpeedPadModifier
    /// </summary>
    public InlineArray<float> swingSpeedPadModifier => new(3, Ptr + 7936, 4, this);

    /// <summary>
    /// FloatProperty: swingSpeedPadModifier
    /// </summary>
    public unsafe float swingSpeedPadModifier_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7936); }
    }
    /// <summary>
    /// FloatProperty: swingSpeedPadModifier
    /// </summary>
    public unsafe float swingSpeedPadModifier_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7940); }
    }
    /// <summary>
    /// FloatProperty: swingSpeedPadModifier
    /// </summary>
    public unsafe float swingSpeedPadModifier_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7944); }
    }

    /// <summary>
    /// FloatProperty: swingSpeedModifierMax
    /// </summary>
    public unsafe float swingSpeedModifierMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7948); }
    }

    /// <summary>
    /// FloatProperty: swingSpeedMaxDist
    /// </summary>
    public unsafe float swingSpeedMaxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7952); }
    }

    /// <summary>
    /// FloatProperty: swingSpeedMinDist
    /// </summary>
    public unsafe float swingSpeedMinDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7956); }
    }

    /// <summary>
    /// FloatProperty: healthDegenRate
    /// </summary>
    public unsafe float healthDegenRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7960); }
    }

    /// <summary>
    /// FloatProperty: healthDegenRateNoPads
    /// </summary>
    public unsafe float healthDegenRateNoPads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7964); }
    }

    /// <summary>
    /// FloatProperty: healthRechargeRate
    /// </summary>
    public unsafe float healthRechargeRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7968); }
    }

    /// <summary>
    /// FloatProperty: rechargeThreshold
    /// </summary>
    public unsafe float rechargeThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7972); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: electricPillars
    /// </summary>
    public InlineArray<BmSDK.BmScript.RPawnBossGrundy.FElectricPillarPFX> electricPillars => new(3, Ptr + 7976, 52, this);

    /// <summary>
    /// StructProperty: electricPillars
    /// </summary>
    public unsafe ref BmSDK.BmScript.RPawnBossGrundy.FElectricPillarPFX electricPillars_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RPawnBossGrundy.FElectricPillarPFX>(Ptr + 7976);
    /// <summary>
    /// StructProperty: electricPillars
    /// </summary>
    public unsafe ref BmSDK.BmScript.RPawnBossGrundy.FElectricPillarPFX electricPillars_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RPawnBossGrundy.FElectricPillarPFX>(Ptr + 8028);
    /// <summary>
    /// StructProperty: electricPillars
    /// </summary>
    public unsafe ref BmSDK.BmScript.RPawnBossGrundy.FElectricPillarPFX electricPillars_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RPawnBossGrundy.FElectricPillarPFX>(Ptr + 8080);

    /// <summary>
    /// FloatProperty: electricPillarHeight
    /// </summary>
    public unsafe float electricPillarHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8132); }
    }

    /// <summary>
    /// FloatProperty: verticalPillarFXBaseSize
    /// </summary>
    public unsafe float verticalPillarFXBaseSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8136); }
    }

    /// <summary>
    /// FloatProperty: horizontalPillarFXBaseSize
    /// </summary>
    public unsafe float horizontalPillarFXBaseSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8140); }
    }

    /// <summary>
    /// FloatProperty: beamEndFXScale
    /// </summary>
    public unsafe float beamEndFXScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8144); }
    }

    /// <summary>
    /// FloatProperty: beamEndFXOffsetToCam
    /// </summary>
    public unsafe float beamEndFXOffsetToCam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8148); }
    }

    /// <summary>
    /// FloatProperty: highSwingStandardHeight
    /// </summary>
    public unsafe float highSwingStandardHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8152); }
    }

    /// <summary>
    /// FloatProperty: highSwingExtraHeight
    /// </summary>
    public unsafe float highSwingExtraHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8156); }
    }

    /// <summary>
    /// ComponentProperty: StunnedFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent StunnedFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8160); }
    }

    /// <summary>
    /// ComponentProperty: HitFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent HitFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8164); }
    }

    /// <summary>
    /// FloatProperty: minDistForMelee
    /// </summary>
    public unsafe float minDistForMelee
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8168); }
    }

    /// <summary>
    /// IntProperty: currentRibsDamageState
    /// </summary>
    public unsafe int currentRibsDamageState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8172); }
    }

    /// <summary>
    /// ArrayProperty: RotatingConductors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RPawnBossGrundy.FRotatingConductor> RotatingConductors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RPawnBossGrundy.FRotatingConductor>>(Ptr + 8176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8176); }
    }

    /// <summary>
    /// FloatProperty: conductorMaxRotationRate
    /// </summary>
    public unsafe float conductorMaxRotationRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8188); }
    }

    /// <summary>
    /// FloatProperty: conductorTimeToReachMaxRotationRate
    /// </summary>
    public unsafe float conductorTimeToReachMaxRotationRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8192); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: conductorCurrentRotationRate
    /// </summary>
    public InlineArray<float> conductorCurrentRotationRate => new(3, Ptr + 8196, 4, this);

    /// <summary>
    /// FloatProperty: conductorCurrentRotationRate
    /// </summary>
    public unsafe float conductorCurrentRotationRate_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8196); }
    }
    /// <summary>
    /// FloatProperty: conductorCurrentRotationRate
    /// </summary>
    public unsafe float conductorCurrentRotationRate_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8200); }
    }
    /// <summary>
    /// FloatProperty: conductorCurrentRotationRate
    /// </summary>
    public unsafe float conductorCurrentRotationRate_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8204); }
    }

    /// <summary>
    /// ComponentProperty: brokenRibDustPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent brokenRibDustPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8208); }
    }

    /// <summary>
    /// FloatProperty: fireMaggotLifeTime
    /// </summary>
    public unsafe float fireMaggotLifeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8212); }
    }

    /// <summary>
    /// FloatProperty: fireMaggotMaxSpeed
    /// </summary>
    public unsafe float fireMaggotMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8216); }
    }

    /// <summary>
    /// FloatProperty: electricMaggotLifeTime
    /// </summary>
    public unsafe float electricMaggotLifeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8220); }
    }

    /// <summary>
    /// FloatProperty: electricMaggotMaxSpeed
    /// </summary>
    public unsafe float electricMaggotMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8224); }
    }

    /// <summary>
    /// FloatProperty: veinGlowMultiplier
    /// </summary>
    public unsafe float veinGlowMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8228); }
    }

    /// <summary>
    /// FloatProperty: stage3PillarOnTime
    /// </summary>
    public unsafe float stage3PillarOnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8232); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: stage3PillarOffTime
    /// </summary>
    public InlineArray<float> stage3PillarOffTime => new(3, Ptr + 8236, 4, this);

    /// <summary>
    /// FloatProperty: stage3PillarOffTime
    /// </summary>
    public unsafe float stage3PillarOffTime_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8236); }
    }
    /// <summary>
    /// FloatProperty: stage3PillarOffTime
    /// </summary>
    public unsafe float stage3PillarOffTime_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8240); }
    }
    /// <summary>
    /// FloatProperty: stage3PillarOffTime
    /// </summary>
    public unsafe float stage3PillarOffTime_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8244); }
    }

    /// <summary>
    /// FloatProperty: timeTillBeamDisable
    /// </summary>
    public unsafe float timeTillBeamDisable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8248); }
    }

    /// <summary>
    /// ObjectProperty: levelBlockingVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RBlockingVolume levelBlockingVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBlockingVolume>(Ptr + 8252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8252); }
    }

    /// <summary>
    /// ArrayProperty: extraMeshesSavedXrayMats
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RPawnBossGrundy.FmeshSavedXrayMats> extraMeshesSavedXrayMats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RPawnBossGrundy.FmeshSavedXrayMats>>(Ptr + 8256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8256); }
    }

    /// <summary>
    /// FloatProperty: BeforeBeatErrorMargin
    /// </summary>
    public unsafe float BeforeBeatErrorMargin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8268); }
    }

    /// <summary>
    /// FloatProperty: AfterBeatErrorMargin
    /// </summary>
    public unsafe float AfterBeatErrorMargin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8272); }
    }

    /// <summary>
    /// IntProperty: timesRecharged
    /// </summary>
    public unsafe int timesRecharged
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8276); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: bPadCogsOn
    /// </summary>
    public InlineArray<int> bPadCogsOn => new(3, Ptr + 8280, 4, this);

    /// <summary>
    /// IntProperty: bPadCogsOn
    /// </summary>
    public unsafe int bPadCogsOn_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8280); }
    }
    /// <summary>
    /// IntProperty: bPadCogsOn
    /// </summary>
    public unsafe int bPadCogsOn_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8284); }
    }
    /// <summary>
    /// IntProperty: bPadCogsOn
    /// </summary>
    public unsafe int bPadCogsOn_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8288); }
    }

    /// <summary>
    /// FloatProperty: cogAcceleration
    /// </summary>
    public unsafe float cogAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8292); }
    }

    /// <summary>
    /// ObjectProperty: chainXrayMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant chainXrayMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 8296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8296); }
    }

    /// <summary>
    /// ObjectProperty: RocketRevealRefPoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor RocketRevealRefPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 8300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8300); }
    }

    /// <summary>
    /// ComponentProperty: BallDragFX_Elec
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BallDragFX_Elec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8304); }
    }

    /// <summary>
    /// ComponentProperty: DamagedGeneratorPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent DamagedGeneratorPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8308); }
    }

    /// <summary>
    /// FloatProperty: veinColourTarget
    /// </summary>
    public unsafe float veinColourTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8312); }
    }

    /// <summary>
    /// FloatProperty: veinColourCurrentVal
    /// </summary>
    public unsafe float veinColourCurrentVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8316); }
    }

    /// <summary>
    /// FloatProperty: veinColourTransitionPeriod
    /// </summary>
    public unsafe float veinColourTransitionPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8320); }
    }

    /// <summary>
    /// FloatProperty: veinSecondaryPulseTimer
    /// </summary>
    public unsafe float veinSecondaryPulseTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8324); }
    }

    /// <summary>
    /// FloatProperty: veinSecondaryPulseCurrentVal
    /// </summary>
    public unsafe float veinSecondaryPulseCurrentVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8328); }
    }

    /// <summary>
    /// FloatProperty: veinSecondaryPulsePeriod
    /// </summary>
    public unsafe float veinSecondaryPulsePeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8332); }
    }

    /// <summary>
    /// FloatProperty: veinSecondaryPulseMax
    /// </summary>
    public unsafe float veinSecondaryPulseMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8336); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: OverloadExplodeFX
    /// </summary>
    public InlineArray<BmSDK.Engine.Emitter> OverloadExplodeFX => new(3, Ptr + 8340, 4, this);

    /// <summary>
    /// ObjectProperty: OverloadExplodeFX
    /// </summary>
    public unsafe BmSDK.Engine.Emitter OverloadExplodeFX_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 8340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8340); }
    }
    /// <summary>
    /// ObjectProperty: OverloadExplodeFX
    /// </summary>
    public unsafe BmSDK.Engine.Emitter OverloadExplodeFX_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 8344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8344); }
    }
    /// <summary>
    /// ObjectProperty: OverloadExplodeFX
    /// </summary>
    public unsafe BmSDK.Engine.Emitter OverloadExplodeFX_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 8348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8348); }
    }

    /// <summary>
    /// ArrayProperty: GeneratorSmokeEmitters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Emitter> GeneratorSmokeEmitters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Emitter>>(Ptr + 8352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8352); }
    }

    /// <summary>
    /// ArrayProperty: GeneratorKickStartEmitters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Emitter> GeneratorKickStartEmitters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Emitter>>(Ptr + 8364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8364); }
    }

    /// <summary>
    /// FloatProperty: roomShutdownDuration
    /// </summary>
    public unsafe float roomShutdownDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8376); }
    }

    /// <summary>
    /// FloatProperty: roomHitReactDuration
    /// </summary>
    public unsafe float roomHitReactDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8380); }
    }

    /// <summary>
    /// FloatProperty: roomHitReactFlashPeriod
    /// </summary>
    public unsafe float roomHitReactFlashPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8384); }
    }

    /// <summary>
    /// FloatProperty: beamHitReactEndTime
    /// </summary>
    public unsafe float beamHitReactEndTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8388); }
    }

    /// <summary>
    /// ObjectProperty: PData
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData PData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData>(Ptr + 8392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8392); }
    }

    /// <summary>
    /// FloatProperty: colourThreshLower
    /// </summary>
    public unsafe float colourThreshLower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8396); }
    }

    /// <summary>
    /// FloatProperty: colourThreshUpper
    /// </summary>
    public unsafe float colourThreshUpper
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8400); }
    }

    /// <summary>
    /// FloatProperty: colourValAtLowerThresh
    /// </summary>
    public unsafe float colourValAtLowerThresh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8404); }
    }

    /// <summary>
    /// FloatProperty: colourValAtUpperThresh
    /// </summary>
    public unsafe float colourValAtUpperThresh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8408); }
    }

    /// <summary>
    /// FloatProperty: grundyComboDuration
    /// </summary>
    public unsafe float grundyComboDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8412); }
    }

    /// <summary>
    /// ComponentProperty: HeartTrailPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent HeartTrailPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8416); }
    }

    /// <summary>
    /// FloatProperty: CrucifiedHeartGlowVal
    /// </summary>
    public unsafe float CrucifiedHeartGlowVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8420); }
    }

    /// <summary>
    /// ArrayProperty: OverchargeExplosions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Emitter> OverchargeExplosions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Emitter>>(Ptr + 8424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8424); }
    }

    /// <summary>
    /// FloatProperty: smashHitZOffset
    /// </summary>
    public unsafe float smashHitZOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8436); }
    }

    /// <summary>
    /// FloatProperty: pillarDamageRadius
    /// </summary>
    public unsafe float pillarDamageRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8440); }
    }

    /// <summary>
    /// FloatProperty: grundySwingSlideRate
    /// </summary>
    public unsafe float grundySwingSlideRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8444); }
    }

    /// <summary>
    /// IntProperty: dbgNumSwing
    /// </summary>
    public unsafe int dbgNumSwing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8448); }
    }

    /// <summary>
    /// IntProperty: dbgNumSmash
    /// </summary>
    public unsafe int dbgNumSmash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8452); }
    }

    /// <summary>
    /// IntProperty: dbgnumMelee
    /// </summary>
    public unsafe int dbgnumMelee
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8456); }
    }

    /// <summary>
    /// IntProperty: dbgnumPickNextAttack
    /// </summary>
    public unsafe int dbgnumPickNextAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8460); }
    }

    /// <summary>
    /// IntProperty: dbgNumTooCloseForMelee
    /// </summary>
    public unsafe int dbgNumTooCloseForMelee
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8464); }
    }

    /// <summary>
    /// ObjectProperty: bmPrevCombatMove
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatMove bmPrevCombatMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatMove>(Ptr + 8468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8468); }
    }

    /// <summary>
    /// ComponentProperty: floorRingAkComp
    /// </summary>
    public unsafe BmSDK.Engine.AkComponent floorRingAkComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkComponent>(Ptr + 8472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8472); }
    }

    /// <summary>
    /// ComponentProperty: beamAkComp
    /// </summary>
    public unsafe BmSDK.Engine.AkComponent beamAkComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkComponent>(Ptr + 8476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8476); }
    }

    /// <summary>
    /// ComponentProperty: ballsAkComp
    /// </summary>
    public unsafe BmSDK.Engine.AkComponent ballsAkComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkComponent>(Ptr + 8480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8480); }
    }

    /// <summary>
    /// ObjectProperty: beamChargeSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent beamChargeSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8484); }
    }

    /// <summary>
    /// ObjectProperty: beamFiringSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent beamFiringSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8488); }
    }

    /// <summary>
    /// FloatProperty: crushRumbleIntervalMin
    /// </summary>
    public unsafe float crushRumbleIntervalMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8492); }
    }

    /// <summary>
    /// FloatProperty: crushRumbleIntervalMax
    /// </summary>
    public unsafe float crushRumbleIntervalMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8496); }
    }

    /// <summary>
    /// FloatProperty: nextCrushRumbleTime
    /// </summary>
    public unsafe float nextCrushRumbleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8500); }
    }

    /// <summary>
    /// ObjectProperty: boss_hud
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionBossHud boss_hud
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionBossHud>(Ptr + 8504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8504); }
    }

    /// <summary>
    /// FloatProperty: grundySafeDistFromPad
    /// </summary>
    public unsafe float grundySafeDistFromPad
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8508); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: deathVolOffsets
    /// </summary>
    public InlineArray<System.Numerics.Vector3> deathVolOffsets => new(4, Ptr + 8512, 12, this);

    /// <summary>
    /// StructProperty: deathVolOffsets
    /// </summary>
    public unsafe ref System.Numerics.Vector3 deathVolOffsets_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 8512);
    /// <summary>
    /// StructProperty: deathVolOffsets
    /// </summary>
    public unsafe ref System.Numerics.Vector3 deathVolOffsets_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 8524);
    /// <summary>
    /// StructProperty: deathVolOffsets
    /// </summary>
    public unsafe ref System.Numerics.Vector3 deathVolOffsets_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 8536);
    /// <summary>
    /// StructProperty: deathVolOffsets
    /// </summary>
    public unsafe ref System.Numerics.Vector3 deathVolOffsets_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 8548);

    /// <summary>
    /// InlineArray{StructProperty}: deathVolOffsetRots
    /// </summary>
    public InlineArray<BmSDK.Rotator> deathVolOffsetRots => new(4, Ptr + 8560, 12, this);

    /// <summary>
    /// StructProperty: deathVolOffsetRots
    /// </summary>
    public unsafe ref BmSDK.Rotator deathVolOffsetRots_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 8560);
    /// <summary>
    /// StructProperty: deathVolOffsetRots
    /// </summary>
    public unsafe ref BmSDK.Rotator deathVolOffsetRots_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 8572);
    /// <summary>
    /// StructProperty: deathVolOffsetRots
    /// </summary>
    public unsafe ref BmSDK.Rotator deathVolOffsetRots_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 8584);
    /// <summary>
    /// StructProperty: deathVolOffsetRots
    /// </summary>
    public unsafe ref BmSDK.Rotator deathVolOffsetRots_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 8596);

    /// <summary>
    /// FloatProperty: PadScaleAmount
    /// </summary>
    public unsafe float PadScaleAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8608); }
    }

    /// <summary>
    /// FloatProperty: BMKnockBackDist
    /// </summary>
    public unsafe float BMKnockBackDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8612); }
    }

    /// <summary>
    /// ComponentProperty: LeftArmFirePFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent LeftArmFirePFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8616); }
    }

    /// <summary>
    /// ComponentProperty: RightArmFirePFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent RightArmFirePFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8620); }
    }

    /// <summary>
    /// ObjectProperty: ExtraBeamsRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform ExtraBeamsRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 8624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8624); }
    }

    /// <summary>
    /// ObjectProperty: MachineDisableRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform MachineDisableRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 8628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8628); }
    }

    /// <summary>
    /// FloatProperty: swingWeakRumbleRange
    /// </summary>
    public unsafe float swingWeakRumbleRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8632); }
    }

    /// <summary>
    /// FloatProperty: swingStrongRumbleRange
    /// </summary>
    public unsafe float swingStrongRumbleRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8636); }
    }

    /// <summary>
    /// ObjectProperty: GrundySwingRumbleWeak
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform GrundySwingRumbleWeak
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 8640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8640); }
    }

    /// <summary>
    /// ObjectProperty: GrundySwingRumbleStrong
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform GrundySwingRumbleStrong
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 8644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8644); }
    }

    /// <summary>
    /// ObjectProperty: GrundySwingRumbleEnd
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform GrundySwingRumbleEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 8648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8648); }
    }

    /// <summary>
    /// ObjectProperty: riblessSkel
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh riblessSkel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 8652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8652); }
    }

    /// <summary>
    /// ObjectProperty: withRibsSkel
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh withRibsSkel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 8656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8656); }
    }

    /// <summary>
    /// ObjectProperty: GrundyOnFireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GrundyOnFireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8660); }
    }

    /// <summary>
    /// StructProperty: GrundyOnFireSoundHandle
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle GrundyOnFireSoundHandle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 8664);

    /// <summary>
    /// StructProperty: swingDirFlat
    /// </summary>
    public unsafe ref System.Numerics.Vector3 swingDirFlat
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 8676);

    /// <summary>
    /// FloatProperty: swingImpactRagdollImpulse
    /// </summary>
    public unsafe float swingImpactRagdollImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8688); }
    }

    /// <summary>
    /// FloatProperty: ChainGrowRateModifier
    /// </summary>
    public unsafe float ChainGrowRateModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8692); }
    }

    /// <summary>
    /// FloatProperty: midDistMin
    /// </summary>
    public unsafe float midDistMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8696); }
    }

    /// <summary>
    /// FloatProperty: midDistMax
    /// </summary>
    public unsafe float midDistMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8700); }
    }

    /// <summary>
    /// FloatProperty: fakeDeathBlockingCylinderGrowRate
    /// </summary>
    public unsafe float fakeDeathBlockingCylinderGrowRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8704); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: hardCodedSmashReturnOffsets
    /// </summary>
    public InlineArray<System.Numerics.Vector3> hardCodedSmashReturnOffsets => new(2, Ptr + 8708, 12, this);

    /// <summary>
    /// StructProperty: hardCodedSmashReturnOffsets
    /// </summary>
    public unsafe ref System.Numerics.Vector3 hardCodedSmashReturnOffsets_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 8708);
    /// <summary>
    /// StructProperty: hardCodedSmashReturnOffsets
    /// </summary>
    public unsafe ref System.Numerics.Vector3 hardCodedSmashReturnOffsets_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 8720);

    /// <summary>
    /// FloatProperty: firePatchBaseLength
    /// </summary>
    public unsafe float firePatchBaseLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8732); }
    }

    /// <summary>
    /// Enum: eGrundyMeshGlowiness
    /// </summary>
    public enum eGrundyMeshGlowiness : byte
    {
        eGMG_Opaque = 0,
        eGMG_EmissiveOnly = 1,
        eGMG_MAX = 2,
    }
}
