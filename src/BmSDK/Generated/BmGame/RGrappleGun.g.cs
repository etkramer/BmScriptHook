#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RGrappleGun<br/>
/// (size = 1728)
/// (flags = 142606515)
/// </summary>
public partial class RGrappleGun : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGrappleGun", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGrappleGun.
    /// </summary>
    public static RGrappleGun DefaultObject => (RGrappleGun)StaticClass().DefaultObject;

    internal RGrappleGun() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGrappleGun(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: UpdateGrappleGunTarget
    /// </summary>
    public unsafe virtual void UpdateGrappleGunTarget(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.UpdateGrappleGunTarget", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: CanAimGrapple
    /// </summary>
    public unsafe virtual bool CanAimGrapple()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.CanAimGrapple", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: LastHidePointTimeOut
    /// </summary>
    public unsafe virtual void LastHidePointTimeOut()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.LastHidePointTimeOut", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SucceedBoost
    /// </summary>
    public unsafe virtual void SucceedBoost()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.SucceedBoost", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FailedBoost
    /// </summary>
    public unsafe virtual void FailedBoost()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.FailedBoost", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckGrapplePointCollision
    /// </summary>
    public unsafe virtual bool CheckGrapplePointCollision(BmSDK.Engine.Actor GrapplePointToCheck, System.Numerics.Vector3 GrappleTargetPos)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.CheckGrapplePointCollision", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrapplePointToCheck, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrappleTargetPos, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: CheckCurrentGrapplePointCollision
    /// </summary>
    public unsafe virtual bool CheckCurrentGrapplePointCollision()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.CheckCurrentGrapplePointCollision", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetGrappleTargetPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGrappleTargetPosition()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.GetGrappleTargetPosition", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: InitialiseGrappleWayPoints
    /// </summary>
    public unsafe virtual void InitialiseGrappleWayPoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.InitialiseGrappleWayPoints", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: CalcGrappleLength
    /// </summary>
    public unsafe virtual void CalcGrappleLength()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.CalcGrappleLength", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: CheckForGrappleWaypoints
    /// </summary>
    public unsafe virtual void CheckForGrappleWaypoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.CheckForGrappleWaypoints", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: NoWaypointCheck
    /// </summary>
    public unsafe virtual void NoWaypointCheck()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.NoWaypointCheck", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReachedGrappleWayPoint
    /// </summary>
    public unsafe virtual void ReachedGrappleWayPoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.ReachedGrappleWayPoint", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QueueGrappleTimer
    /// </summary>
    public unsafe virtual void QueueGrappleTimer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.QueueGrappleTimer", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QueueGrapple
    /// </summary>
    public unsafe virtual void QueueGrapple(float QueueTime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.QueueGrapple", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueueTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateRange
    /// </summary>
    public unsafe virtual void UpdateRange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.UpdateRange", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.Destroyed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetNumAvailableGrapplePoints
    /// </summary>
    public unsafe virtual int GetNumAvailableGrapplePoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.GetNumAvailableGrapplePoints", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AttachToHand
    /// </summary>
    public unsafe override void AttachToHand(BmSDK.FName CustomBone = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.AttachToHand", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomBone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AttachToBelt
    /// </summary>
    public unsafe override void AttachToBelt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.AttachToBelt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopGrappleTrails
    /// </summary>
    public unsafe virtual void StopGrappleTrails()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.StopGrappleTrails", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartGrappleTrails
    /// </summary>
    public unsafe virtual void StartGrappleTrails()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.StartGrappleTrails", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOffProjectiles
    /// </summary>
    public unsafe override void TurnOffProjectiles()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.TurnOffProjectiles", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FireProjectile
    /// </summary>
    public unsafe override void FireProjectile(System.Numerics.Vector3 ProjectileTarget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.FireProjectile", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjectileTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe override void DrawHUD(BmSDK.Engine.HUD H)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.DrawHUD", true);
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CalculateOffScreenIconPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 CalculateOffScreenIconPosition(BmSDK.Engine.Canvas HudCanvas, System.Numerics.Vector3 TargetPosition)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.CalculateOffScreenIconPosition", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HudCanvas, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPosition, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: FindEscapeVantagePoint
    /// </summary>
    public unsafe virtual void FindEscapeVantagePoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.FindEscapeVantagePoint", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: FindBestVantagePoint
    /// </summary>
    public unsafe virtual float FindBestVantagePoint(System.Numerics.Vector3 CheckLocation, System.Numerics.Vector3 CheckDirection, float MaxHorizontalDistance, out BmSDK.BmGame.RGrappleGun.FAvailableVantagePoints VantagePointList, bool Zoomed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.FindBestVantagePoint", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckDirection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxHorizontalDistance, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zoomed, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        VantagePointList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrappleGun.FAvailableVantagePoints>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 48);
    }

    /// <summary>
    /// Function: ClearGrappleInfo
    /// </summary>
    public unsafe virtual void ClearGrappleInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.ClearGrappleInfo", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: DrawGrapplePointDebug
    /// </summary>
    public unsafe virtual void DrawGrapplePointDebug()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.DrawGrapplePointDebug", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: FindGrapplePointMultipleConesNative
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGrapplePoint FindGrapplePointMultipleConesNative(BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition> Cones, float MinAngle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.FindGrapplePointMultipleConesNative", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Cones, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinAngle, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: FindGrapplePointMultipleCones
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGrapplePoint FindGrapplePointMultipleCones(out BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition> Cones, float MinAngle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.FindGrapplePointMultipleCones", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinAngle, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Cones = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: FindGrapplePoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGrapplePoint FindGrapplePoint(float MinAngle, System.Numerics.Vector3 CameraLocation, BmSDK.Rotator CameraRotation, System.Numerics.Vector3 PlayerLocation, bool bZoomed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.FindGrapplePoint", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinAngle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraRotation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bZoomed, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(paramsPtr + 44);
    }

    /// <summary>
    /// Function: UpdateCheckFrame
    /// </summary>
    public unsafe virtual void UpdateCheckFrame()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.UpdateCheckFrame", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: FindBestCeilingClimbPoint
    /// </summary>
    public unsafe virtual bool FindBestCeilingClimbPoint(out BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint CeilingClimbPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.FindBestCeilingClimbPoint", true);
        byte* paramsPtr = stackalloc byte[116];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CeilingClimbPoint = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 112);
    }

    /// <summary>
    /// Function: ToggleGrappleTarget
    /// </summary>
    public unsafe virtual void ToggleGrappleTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.ToggleGrappleTarget", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetFailedGrappleTimer
    /// </summary>
    public unsafe virtual void SetFailedGrappleTimer(float FailTime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.SetFailedGrappleTimer", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Grapple
    /// </summary>
    public unsafe virtual bool Grapple(BmSDK.BmGame.RSpecialMoveConfig OverrideGrappleMove = default, bool bForceSucceed = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.Grapple", true);
        byte* paramsPtr = stackalloc byte[148];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideGrappleMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceSucceed, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: OnPlayerHasBeenMoved
    /// </summary>
    public unsafe virtual void OnPlayerHasBeenMoved()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.OnPlayerHasBeenMoved", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnRoomChange
    /// </summary>
    public unsafe override void OnRoomChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.OnRoomChange", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GivenTo
    /// </summary>
    public unsafe override void GivenTo(BmSDK.Engine.Pawn thisPawn, bool bDoNotActivate = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.GivenTo", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(thisPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoNotActivate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ScriptTick
    /// </summary>
    public unsafe virtual void ScriptTick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.ScriptTick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FGrappleConeDefinition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public partial record struct FGrappleConeDefinition
    {
        /// <summary>
        /// StructProperty: CheckLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 CheckLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: CheckRotation
        /// </summary>
        public unsafe BmSDK.Rotator CheckRotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: PlayerLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 PlayerLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bRunGrapple
        /// </summary>
        public unsafe bool bRunGrapple
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: bZoomed
        /// </summary>
        public unsafe bool bZoomed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: ScoreBonus
        /// </summary>
        public unsafe float ScoreBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: VantagePointBonus
        /// </summary>
        public unsafe float VantagePointBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: MaxDistance
        /// </summary>
        public unsafe float MaxDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: ConeAngle
        /// </summary>
        public unsafe float ConeAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// BoolProperty: bVantagePointsOnly
        /// </summary>
        public unsafe bool bVantagePointsOnly
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Struct: FGrapplePointContainer
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FGrapplePointContainer
    {
        /// <summary>
        /// StructProperty: GrapplePoint
        /// </summary>
        public unsafe System.IntPtr GrapplePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: TargetPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: GrappleCheckPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 GrappleCheckPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: Score
        /// </summary>
        public unsafe float Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: BonusScore
        /// </summary>
        public unsafe float BonusScore
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: GrappleClear
        /// </summary>
        public unsafe bool GrappleClear
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: GrappleChecked
        /// </summary>
        public unsafe bool GrappleChecked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Enum: EOffscreenGrappleIconState
    /// </summary>
    public enum EOffscreenGrappleIconState : byte
    {
        OGIS_NotDisplayed = 0,
        OGIS_Displayed = 1,
        OGIS_Travelling = 2,
        OGIS_MAX = 3,
    }

    /// <summary>
    /// Enum: EGrappleFailReason
    /// </summary>
    public enum EGrappleFailReason : byte
    {
        GFR_Success = 0,
        GFR_CollisionFail = 1,
        GFR_LowerThanTopScore = 2,
        GFR_FinalAngleFail = 3,
        GFR_LineOutsideAngleLimit = 4,
        GFR_BelowBatman = 5,
        GFR_OutsideRadiusCheck = 6,
        GFR_TooHighOrLow = 7,
        GFR_TooLow = 8,
        GFR_TooFarAway = 9,
        GFR_WrongSide = 10,
        GFR_EarlyRadiusCheck = 11,
        GFR_InvalidPoint = 12,
        GFR_MaxDrawColours = 13,
        GFR_MAX = 14,
    }

    /// <summary>
    /// Struct: FAvailableVantagePoints
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FAvailableVantagePoints
    {
        /// <summary>
        /// ArrayProperty: PotentialHidePoints
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FHidePointInfo> PotentialHidePoints
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FHidePointInfo>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: CurrentHidePointIter
        /// </summary>
        public unsafe int CurrentHidePointIter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FHidePointInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FHidePointInfo
    {
        /// <summary>
        /// ObjectProperty: HidePoint
        /// </summary>
        public unsafe BmSDK.BmGame.RHidePoint HidePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: HidePointAngle
        /// </summary>
        public unsafe float HidePointAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bHidePointBlocked
        /// </summary>
        public unsafe bool bHidePointBlocked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleHeight
    /// </summary>
    public unsafe float MaxGrappleHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// FloatProperty: MinGrappleHeight
    /// </summary>
    public unsafe float MinGrappleHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleHorizontalDistance
    /// </summary>
    public unsafe float MaxGrappleHorizontalDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleAngle
    /// </summary>
    public unsafe float MaxGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// FloatProperty: MaxHorizontalDistanceForAimedGrapple
    /// </summary>
    public unsafe float MaxHorizontalDistanceForAimedGrapple
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// FloatProperty: MaxAimedGrappleAngle
    /// </summary>
    public unsafe float MaxAimedGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: RunGrappleAngle
    /// </summary>
    public unsafe float RunGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// FloatProperty: WallStickGrappleAngle
    /// </summary>
    public unsafe float WallStickGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// FloatProperty: EscapeGrappleAngle
    /// </summary>
    public unsafe float EscapeGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// ObjectProperty: GrappleFireMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleFireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// ObjectProperty: GrappleFireGlideMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleFireGlideMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ObjectProperty: FailedGrappleFireMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FailedGrappleFireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ObjectProperty: VantagePointGrappleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig VantagePointGrappleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// ObjectProperty: RailingFireGrappleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingFireGrappleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// ObjectProperty: ShimmyFireGrappleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ShimmyFireGrappleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// FloatProperty: IconSize
    /// </summary>
    public unsafe float IconSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// IntProperty: MinGrapplePitch
    /// </summary>
    public unsafe int MinGrapplePitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// IntProperty: MinEdgeSwingPitch
    /// </summary>
    public unsafe int MinEdgeSwingPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// IntProperty: MinVantagePitch
    /// </summary>
    public unsafe int MinVantagePitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// FloatProperty: VantagePointGrappleAngle
    /// </summary>
    public unsafe float VantagePointGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndDangleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndDangleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndShimmyMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndShimmyMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// ObjectProperty: CustomGrappleEndDangleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CustomGrappleEndDangleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// NameProperty: CustomHangCamera
    /// </summary>
    public unsafe BmSDK.FName CustomHangCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bCantShimmyOnNextHang
    /// </summary>
    public unsafe bool bCantShimmyOnNextHang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bCantAutoPopUpOnNextHang
    /// </summary>
    public unsafe bool bCantAutoPopUpOnNextHang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bTargettingCeiling
    /// </summary>
    public unsafe bool bTargettingCeiling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bActive
    /// </summary>
    public unsafe bool bActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bPreFire
    /// </summary>
    public unsafe bool bPreFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bShowingGrappleIcon
    /// </summary>
    public unsafe bool bShowingGrappleIcon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bRenderGrappleDebug
    /// </summary>
    public unsafe bool bRenderGrappleDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bUseReverseCameraForSwinging
    /// </summary>
    public unsafe bool bUseReverseCameraForSwinging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bDoingGrappleSpaceTest
    /// </summary>
    public unsafe bool bDoingGrappleSpaceTest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bVantagePointCheckFrame
    /// </summary>
    public unsafe bool bVantagePointCheckFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bRunGrapple
    /// </summary>
    public unsafe bool bRunGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bEdgeSwingGrapple
    /// </summary>
    public unsafe bool bEdgeSwingGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bGrappleSelectionDebug
    /// </summary>
    public unsafe bool bGrappleSelectionDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bAllowAimingWhenFalling
    /// </summary>
    public unsafe bool bAllowAimingWhenFalling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bCatwomanGrappleGun
    /// </summary>
    public unsafe bool bCatwomanGrappleGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bUnusableGrappleTarget
    /// </summary>
    public unsafe bool bUnusableGrappleTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bDoingGlideStick
    /// </summary>
    public unsafe bool bDoingGlideStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bUseGrappleOctree
    /// </summary>
    public unsafe bool bUseGrappleOctree
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bDebugTreatAsOverworld
    /// </summary>
    public unsafe bool bDebugTreatAsOverworld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bOverrideGrappleRendering
    /// </summary>
    public unsafe bool bOverrideGrappleRendering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bWallStick
    /// </summary>
    public unsafe bool bWallStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bDebugGrappleChecks
    /// </summary>
    public unsafe bool bDebugGrappleChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bDebugCeilingClimbPoints
    /// </summary>
    public unsafe bool bDebugCeilingClimbPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: StateOverridesTick
    /// </summary>
    public unsafe bool StateOverridesTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndClimbFlat
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndClimbFlat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndClimbRailing
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndClimbRailing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndClimbOverWall
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndClimbOverWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndRunFlat
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndRunFlat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndRunFlatNoRoll
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndRunFlatNoRoll
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndRunRailing
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndRunRailing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndRunOverWall
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndRunOverWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndFly
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndFly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndFlyRail
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndFlyRail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndOnRailing
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndOnRailing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// FloatProperty: LookFarwardFallingTime
    /// </summary>
    public unsafe float LookFarwardFallingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// FloatProperty: MaxHorizontalRange
    /// </summary>
    public unsafe float MaxHorizontalRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// StructProperty: CurrentTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1120);

    /// <summary>
    /// FloatProperty: CurrentTargetRadius
    /// </summary>
    public unsafe float CurrentTargetRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// ObjectProperty: GrapplePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint GrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ObjectProperty: CurrentHidePoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// StructProperty: CeilingTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CeilingTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1144);

    /// <summary>
    /// StructProperty: CurrentTarget2
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentTarget2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1156);

    /// <summary>
    /// ObjectProperty: GrapplePoint2
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint GrapplePoint2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// StructProperty: HideLinkSwingTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HideLinkSwingTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1172);

    /// <summary>
    /// FloatProperty: GrappleLength
    /// </summary>
    public unsafe float GrappleLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// ObjectProperty: Projectile
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectileWithRope Projectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectileWithRope>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// ComponentProperty: MuzzleFlash
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// ComponentProperty: GrappleRope
    /// </summary>
    public unsafe BmSDK.BmGame.RSimpleRopeComponent GrappleRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSimpleRopeComponent>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// IntProperty: RopeInitTimer
    /// </summary>
    public unsafe int RopeInitTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// FloatProperty: VantagePointSwingRate
    /// </summary>
    public unsafe float VantagePointSwingRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// FloatProperty: StandingSwingRate
    /// </summary>
    public unsafe float StandingSwingRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// ArrayProperty: GrappleTrailBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> GrappleTrailBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// ArrayProperty: GrappleTrail
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ParticleSystemComponent> GrappleTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ParticleSystemComponent>>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// FloatProperty: DisplayFailedGrappleTime
    /// </summary>
    public unsafe float DisplayFailedGrappleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// FloatProperty: OriginalGrappleLength
    /// </summary>
    public unsafe float OriginalGrappleLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// FloatProperty: VantagePointBias
    /// </summary>
    public unsafe float VantagePointBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// NameProperty: PreGrappleDestState
    /// </summary>
    public unsafe BmSDK.FName PreGrappleDestState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// FloatProperty: GrappleAccelTime
    /// </summary>
    public unsafe float GrappleAccelTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// IntProperty: FlyingGrapplePitch
    /// </summary>
    public unsafe int FlyingGrapplePitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// StructProperty: AimedHidePoints
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGrappleGun.FAvailableVantagePoints AimedHidePoints
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGrappleGun.FAvailableVantagePoints>(Ptr + 1264);

    /// <summary>
    /// StructProperty: EscapeHidePoints
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGrappleGun.FAvailableVantagePoints EscapeHidePoints
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGrappleGun.FAvailableVantagePoints>(Ptr + 1280);

    /// <summary>
    /// IntProperty: CurrentGrapplePointToCheck
    /// </summary>
    public unsafe int CurrentGrapplePointToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// IntProperty: NumValidGrapplePoints
    /// </summary>
    public unsafe int NumValidGrapplePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// FloatProperty: HidePointDistWeight
    /// </summary>
    public unsafe float HidePointDistWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// FloatProperty: HidePointAngleWeight
    /// </summary>
    public unsafe float HidePointAngleWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// FloatProperty: HidePointAnglePower
    /// </summary>
    public unsafe float HidePointAnglePower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// FloatProperty: AngleToNormalWeight
    /// </summary>
    public unsafe float AngleToNormalWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// FloatProperty: RunningHidePointDistWeight
    /// </summary>
    public unsafe float RunningHidePointDistWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// FloatProperty: RunningHidePointAngleWeight
    /// </summary>
    public unsafe float RunningHidePointAngleWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// FloatProperty: RunningHidePointAnglePower
    /// </summary>
    public unsafe float RunningHidePointAnglePower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// FloatProperty: RunningAngleToNormalWeight
    /// </summary>
    public unsafe float RunningAngleToNormalWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// FloatProperty: RunningStickyWeight
    /// </summary>
    public unsafe float RunningStickyWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingDistWeight
    /// </summary>
    public unsafe float EdgeSwingDistWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingAngleWeight
    /// </summary>
    public unsafe float EdgeSwingAngleWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingAnglePower
    /// </summary>
    public unsafe float EdgeSwingAnglePower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingAngleToNormalWeight
    /// </summary>
    public unsafe float EdgeSwingAngleToNormalWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// FloatProperty: RunningGrappleAngleTan
    /// </summary>
    public unsafe float RunningGrappleAngleTan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// FloatProperty: OffScreenLRIconBias
    /// </summary>
    public unsafe float OffScreenLRIconBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// StructProperty: OffScreenArrowRot
    /// </summary>
    public unsafe ref BmSDK.Rotator OffScreenArrowRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1364);

    /// <summary>
    /// ByteProperty: GrapplePlayerId
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint.ELocalGrapplePlayer GrapplePlayerId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint.ELocalGrapplePlayer>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// ByteProperty: CurrentOffscreenIconState
    /// </summary>
    public unsafe BmSDK.BmGame.RGrappleGun.EOffscreenGrappleIconState CurrentOffscreenIconState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrappleGun.EOffscreenGrappleIconState>(Ptr + 1377); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1377); }
    }

    /// <summary>
    /// ByteProperty: LocalPlayerId
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint.ELocalGrapplePlayer LocalPlayerId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint.ELocalGrapplePlayer>(Ptr + 1378); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1378); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: DebugDrawColor
    /// </summary>
    public InlineArray<BmSDK.GameObject.FColor> DebugDrawColor => new(13, Ptr + 1380, 4, this);

    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor DebugDrawColor_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1380);
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor DebugDrawColor_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1384);
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor DebugDrawColor_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1388);
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor DebugDrawColor_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1392);
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor DebugDrawColor_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1396);
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor DebugDrawColor_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1400);
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor DebugDrawColor_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1404);
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor DebugDrawColor_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1408);
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor DebugDrawColor_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1412);
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor DebugDrawColor_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1416);
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor DebugDrawColor_10
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1420);
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor DebugDrawColor_11
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1424);
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor DebugDrawColor_12
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1428);

    /// <summary>
    /// StructProperty: DesiredGrappleIconPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DesiredGrappleIconPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1432);

    /// <summary>
    /// StructProperty: GrappleIconOriginalPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrappleIconOriginalPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1444);

    /// <summary>
    /// FloatProperty: TravelTimer
    /// </summary>
    public unsafe float TravelTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }

    /// <summary>
    /// FloatProperty: GrappleIconTravelTime
    /// </summary>
    public unsafe float GrappleIconTravelTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// FloatProperty: OldGrapplePointTime
    /// </summary>
    public unsafe float OldGrapplePointTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// FloatProperty: GrappleLagTime
    /// </summary>
    public unsafe float GrappleLagTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// ClassProperty: GrappleProjectileClass
    /// </summary>
    public unsafe BmSDK.Class GrappleProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// ObjectProperty: ImpactSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ImpactSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// ObjectProperty: FireGrappleSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireGrappleSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// ObjectProperty: GrappleLoopSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GrappleLoopSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// ObjectProperty: GrappleBoostSoundParam
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName GrappleBoostSoundParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// ObjectProperty: SucceedBoostSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SucceedBoostSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// ObjectProperty: FailedBoostSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FailedBoostSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// FloatProperty: AerialGrappleRange
    /// </summary>
    public unsafe float AerialGrappleRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// FloatProperty: NoAerialGrappelIfWillHitTime
    /// </summary>
    public unsafe float NoAerialGrappelIfWillHitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: GrappleWayPoints
    /// </summary>
    public InlineArray<System.Numerics.Vector3> GrappleWayPoints => new(8, Ptr + 1508, 12, this);

    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrappleWayPoints_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1508);
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrappleWayPoints_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1520);
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrappleWayPoints_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1532);
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrappleWayPoints_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1544);
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrappleWayPoints_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1556);
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrappleWayPoints_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1568);
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrappleWayPoints_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1580);
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrappleWayPoints_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1592);

    /// <summary>
    /// InlineArray{FloatProperty}: GrappleWayPointDistances
    /// </summary>
    public InlineArray<float> GrappleWayPointDistances => new(8, Ptr + 1604, 4, this);

    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1628); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }
    }

    /// <summary>
    /// IntProperty: CurrentGrappleWayPoint
    /// </summary>
    public unsafe int CurrentGrappleWayPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }

    /// <summary>
    /// StructProperty: LastClearGrapplePos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastClearGrapplePos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1640);

    /// <summary>
    /// IntProperty: NumGrapplePointsToCheckPerFrame
    /// </summary>
    public unsafe int NumGrapplePointsToCheckPerFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1652); }
    }

    /// <summary>
    /// ObjectProperty: PC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController PC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 1656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1656); }
    }

    /// <summary>
    /// ObjectProperty: LastGrapplePoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor LastGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1660); }
    }

    /// <summary>
    /// StructProperty: LastGrapplePointTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastGrapplePointTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1664);

    /// <summary>
    /// FloatProperty: LastGrapplePointTime
    /// </summary>
    public unsafe float LastGrapplePointTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// FloatProperty: GrapplePointThinkingTime
    /// </summary>
    public unsafe float GrapplePointThinkingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }
    }

    /// <summary>
    /// ObjectProperty: LastSwingPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LastSwingPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// ArrayProperty: CheckedGrapplePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrapplePointContainer> CheckedGrapplePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrapplePointContainer>>(Ptr + 1688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1688); }
    }

    /// <summary>
    /// StructProperty: CurrentOutwardNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentOutwardNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1700);

    /// <summary>
    /// FloatProperty: GlideStickForwardTilt
    /// </summary>
    public unsafe float GlideStickForwardTilt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }
    }

    /// <summary>
    /// FloatProperty: GlideStickCheckLocationShift
    /// </summary>
    public unsafe float GlideStickCheckLocationShift
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// IntProperty: GrappleFilter
    /// </summary>
    public unsafe int GrappleFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// IntProperty: HidePointFilter
    /// </summary>
    public unsafe int HidePointFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1724); }
    }
}
