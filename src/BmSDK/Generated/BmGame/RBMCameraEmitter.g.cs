#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RBMCameraEmitter<br/>
/// (size = 456)
/// (flags = 142606483)
/// </summary>
public partial class RBMCameraEmitter : BmSDK.BmGame.REmitter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMCameraEmitter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMCameraEmitter.
    /// </summary>
    public static RBMCameraEmitter DefaultObject => (RBMCameraEmitter)StaticClass().DefaultObject;

    internal RBMCameraEmitter() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMCameraEmitter(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCameraEmitter>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCameraEmitter>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCameraEmitter>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCameraEmitter>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCameraEmitter>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCameraEmitter>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCameraEmitter>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCameraEmitter>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: UpdateLocation
    /// </summary>
    public unsafe virtual void UpdateLocation(System.Numerics.Vector3 CamLoc, BmSDK.Rotator CamRot, float CamFOVDeg)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMCameraEmitter.UpdateLocation", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamFOVDeg, paramsPtr + 24);
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
    /// Function: RegisterCamera
    /// </summary>
    public unsafe virtual void RegisterCamera(BmSDK.BmGame.R3rdPersonCamera inCam)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMCameraEmitter.RegisterCamera", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inCam, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMCameraEmitter.Destroyed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMCameraEmitter.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Cam
    /// </summary>
    public unsafe BmSDK.BmGame.R3rdPersonCamera Cam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.R3rdPersonCamera>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ObjectProperty: ParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// FloatProperty: DistFromCamera
    /// </summary>
    public unsafe float DistFromCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }
}
