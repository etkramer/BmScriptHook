#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AccessControl<br/>
/// (size = 640)
/// (flags = 8388662)
/// </summary>
public partial class AccessControl : BmSDK.Engine.Info, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AccessControl", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as AccessControl.
    /// </summary>
    public static AccessControl DefaultObject => (AccessControl)StaticClass().DefaultObject;

    internal AccessControl() { }

    /// <summary>
    /// Constructs a new AccessControl
    /// </summary>
    public AccessControl(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AccessControl(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AccessControl>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AccessControl>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AccessControl>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AccessControl>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AccessControl>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AccessControl>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AccessControl>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AccessControl>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: IsIDBanned
    /// </summary>
    public unsafe virtual bool IsIDBanned(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AccessControl.IsIDBanned", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: CheckIPPolicy
    /// </summary>
    public unsafe virtual bool CheckIPPolicy(BmSDK.FString Address)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AccessControl.CheckIPPolicy", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Address, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: ValidLogin
    /// </summary>
    public unsafe virtual bool ValidLogin(BmSDK.FString UserName, BmSDK.FString Password)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AccessControl.ValidLogin", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Password, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: ParseAdminOptions
    /// </summary>
    public unsafe virtual bool ParseAdminOptions(BmSDK.FString Options)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AccessControl.ParseAdminOptions", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: AdminExited
    /// </summary>
    public unsafe virtual void AdminExited(BmSDK.Engine.PlayerController P)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AccessControl.AdminExited", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AdminEntered
    /// </summary>
    public unsafe virtual void AdminEntered(BmSDK.Engine.PlayerController P)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AccessControl.AdminEntered", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AdminLogout
    /// </summary>
    public unsafe virtual bool AdminLogout(BmSDK.Engine.PlayerController P)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AccessControl.AdminLogout", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: AdminLogin
    /// </summary>
    public unsafe virtual bool AdminLogin(BmSDK.Engine.PlayerController P, BmSDK.FString Password)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AccessControl.AdminLogin", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Password, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: KickPlayer
    /// </summary>
    public unsafe virtual bool KickPlayer(BmSDK.Engine.PlayerController C, BmSDK.FString KickReason)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AccessControl.KickPlayer", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KickReason, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: ForceKickPlayer
    /// </summary>
    public unsafe virtual bool ForceKickPlayer(BmSDK.Engine.PlayerController C, BmSDK.FString KickReason)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AccessControl.ForceKickPlayer", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KickReason, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: KickBan
    /// </summary>
    public unsafe virtual void KickBan(BmSDK.FString Target)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AccessControl.KickBan", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Kick
    /// </summary>
    public unsafe virtual void Kick(BmSDK.FString Target)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AccessControl.Kick", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetControllerFromString
    /// </summary>
    public unsafe virtual BmSDK.Engine.Controller GetControllerFromString(BmSDK.FString Target)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AccessControl.GetControllerFromString", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Controller>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: IsAdmin
    /// </summary>
    public unsafe virtual bool IsAdmin(BmSDK.Engine.PlayerController P)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AccessControl.IsAdmin", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// ArrayProperty: IPPolicies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> IPPolicies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// ArrayProperty: BannedIDs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> BannedIDs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// StrProperty: IPBanned
    /// </summary>
    public unsafe BmSDK.FString IPBanned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// StrProperty: WrongPassword
    /// </summary>
    public unsafe BmSDK.FString WrongPassword
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// StrProperty: NeedPassword
    /// </summary>
    public unsafe BmSDK.FString NeedPassword
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// StrProperty: SessionBanned
    /// </summary>
    public unsafe BmSDK.FString SessionBanned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// StrProperty: KickedMsg
    /// </summary>
    public unsafe BmSDK.FString KickedMsg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// StrProperty: DefaultKickReason
    /// </summary>
    public unsafe BmSDK.FString DefaultKickReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// StrProperty: IdleKickReason
    /// </summary>
    public unsafe BmSDK.FString IdleKickReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// ClassProperty: AdminClass
    /// </summary>
    public unsafe BmSDK.Class AdminClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// StrProperty: AdminPassword
    /// </summary>
    public unsafe BmSDK.FString AdminPassword
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// StrProperty: GamePassword
    /// </summary>
    public unsafe BmSDK.FString GamePassword
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// InlineArray{StrProperty}: ACDisplayText
    /// </summary>
    public InlineArray<BmSDK.FString> ACDisplayText => new(3, Ptr + 564, 12, this);

    /// <summary>
    /// StrProperty: ACDisplayText
    /// </summary>
    public unsafe BmSDK.FString ACDisplayText_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }
    /// <summary>
    /// StrProperty: ACDisplayText
    /// </summary>
    public unsafe BmSDK.FString ACDisplayText_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }
    /// <summary>
    /// StrProperty: ACDisplayText
    /// </summary>
    public unsafe BmSDK.FString ACDisplayText_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// InlineArray{StrProperty}: ACDescText
    /// </summary>
    public InlineArray<BmSDK.FString> ACDescText => new(3, Ptr + 600, 12, this);

    /// <summary>
    /// StrProperty: ACDescText
    /// </summary>
    public unsafe BmSDK.FString ACDescText_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }
    /// <summary>
    /// StrProperty: ACDescText
    /// </summary>
    public unsafe BmSDK.FString ACDescText_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }
    /// <summary>
    /// StrProperty: ACDescText
    /// </summary>
    public unsafe BmSDK.FString ACDescText_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// BoolProperty: bDontAddDefaultAdmin
    /// </summary>
    public unsafe bool bDontAddDefaultAdmin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 636) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 636); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 636); }
    }
}
