#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: HUD<br/>
/// (size = 1076)
/// (flags = 142606494)
/// </summary>
public partial class HUD : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.HUD", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as HUD.
    /// </summary>
    public static HUD DefaultObject => (HUD)StaticClass().DefaultObject;

    internal HUD() { }

    /// <summary>
    /// Constructs a new HUD
    /// </summary>
    public HUD(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected HUD(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<HUD>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<HUD>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<HUD>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<HUD>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<HUD>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<HUD>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<HUD>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<HUD>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: PlayerOwnerDied
    /// </summary>
    public unsafe virtual void PlayerOwnerDied()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.PlayerOwnerDied", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetFontSizeIndex
    /// </summary>
    public unsafe static BmSDK.Engine.Font GetFontSizeIndex(int FontSize)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.GetFontSizeIndex", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FontSize, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Font>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: DrawText
    /// </summary>
    public unsafe virtual void DrawText(BmSDK.FString Text, System.Numerics.Vector2 Position, BmSDK.Engine.Font TextFont, System.Numerics.Vector2 FontScale, BmSDK.GameObject.FColor TextColor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.DrawText", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextFont, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FontScale, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextColor, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisplayKismetMessages
    /// </summary>
    public unsafe virtual void DisplayKismetMessages()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.DisplayKismetMessages", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisplayLocalMessages
    /// </summary>
    public unsafe virtual void DisplayLocalMessages()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.DisplayLocalMessages", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawMessageText
    /// </summary>
    public unsafe virtual void DrawMessageText(BmSDK.Engine.HUD.FHudLocalizedMessage LocalMessage, float ScreenX, float ScreenY)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.DrawMessageText", true);
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalMessage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScreenX, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScreenY, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawMessage
    /// </summary>
    public unsafe virtual void DrawMessage(int I, float PosY, ref float DX, ref float DY)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.DrawMessage", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(I, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PosY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DX, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DY, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DX = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
        DY = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: GetScreenCoords
    /// </summary>
    public unsafe virtual void GetScreenCoords(float PosY, ref float ScreenX, ref float ScreenY, ref BmSDK.Engine.HUD.FHudLocalizedMessage InMessage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.GetScreenCoords", true);
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PosY, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScreenX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScreenY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InMessage, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ScreenX = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        ScreenY = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
        InMessage = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.HUD.FHudLocalizedMessage>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: AddLocalizedMessage
    /// </summary>
    public unsafe virtual void AddLocalizedMessage(int Index, BmSDK.Class InMessageClass, BmSDK.FString CriticalString, int Switch, float Position, float Lifetime, int FontSize, BmSDK.GameObject.FColor DrawColor, int MessageCount = default, BmSDK.GameObject OptionalObject = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.AddLocalizedMessage", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InMessageClass, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CriticalString, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Switch, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Lifetime, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FontSize, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DrawColor, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageCount, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OptionalObject, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LocalizedMessage
    /// </summary>
    public unsafe virtual void LocalizedMessage(BmSDK.Class InMessageClass, BmSDK.Engine.PlayerReplicationInfo RelatedPRI_1, BmSDK.Engine.PlayerReplicationInfo RelatedPRI_2, BmSDK.FString CriticalString, int Switch, float Position, float Lifetime, int FontSize, BmSDK.GameObject.FColor DrawColor, BmSDK.GameObject OptionalObject = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.LocalizedMessage", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InMessageClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelatedPRI_1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelatedPRI_2, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CriticalString, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Switch, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Lifetime, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FontSize, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DrawColor, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OptionalObject, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddConsoleMessage
    /// </summary>
    public unsafe virtual void AddConsoleMessage(BmSDK.FString M, BmSDK.Class InMessageClass, BmSDK.Engine.PlayerReplicationInfo PRI, float Lifetime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.AddConsoleMessage", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(M, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InMessageClass, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PRI, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Lifetime, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisplayConsoleMessages
    /// </summary>
    public unsafe virtual void DisplayConsoleMessages()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.DisplayConsoleMessages", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Message
    /// </summary>
    public unsafe virtual void Message(BmSDK.Engine.PlayerReplicationInfo PRI, BmSDK.FString msg, BmSDK.FName MsgType, float Lifetime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.Message", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PRI, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(msg, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MsgType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Lifetime, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearMessage
    /// </summary>
    public unsafe virtual void ClearMessage(ref BmSDK.Engine.HUD.FHudLocalizedMessage M)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.ClearMessage", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(M, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        M = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.HUD.FHudLocalizedMessage>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: DisplayBadConnectionAlert
    /// </summary>
    public unsafe virtual void DisplayBadConnectionAlert()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.DisplayBadConnectionAlert", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe virtual void DrawHUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.DrawHUD", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostRender
    /// </summary>
    public unsafe virtual void PostRender()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.PostRender", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreCalcValues
    /// </summary>
    public unsafe virtual void PreCalcValues()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.PreCalcValues", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowDebugInfo
    /// </summary>
    public unsafe virtual void ShowDebugInfo(ref float out_YL, ref float out_YPos)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.ShowDebugInfo", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_YL, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_YPos, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_YL = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
        out_YPos = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: ShouldDisplayDebug
    /// </summary>
    public unsafe virtual bool ShouldDisplayDebug(BmSDK.FName DebugType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.ShouldDisplayDebug", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DebugType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: ShowDebug
    /// </summary>
    public unsafe virtual void ShowDebug(BmSDK.FName DebugType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.ShowDebug", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DebugType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetShowScores
    /// </summary>
    public unsafe virtual void SetShowScores(bool bNewValue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.SetShowScores", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowScores
    /// </summary>
    public unsafe virtual void ShowScores()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.ShowScores", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowHUD
    /// </summary>
    public unsafe virtual void ShowHUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.ShowHUD", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ToggleHUD
    /// </summary>
    public unsafe virtual void ToggleHUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.ToggleHUD", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawActorOverlays
    /// </summary>
    public unsafe virtual void DrawActorOverlays(System.Numerics.Vector3 ViewPoint, BmSDK.Rotator ViewRotation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.DrawActorOverlays", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewRotation, paramsPtr + 12);
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
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Draw2DLine
    /// </summary>
    public unsafe virtual void Draw2DLine(int X1, int Y1, int X2, int Y2, BmSDK.GameObject.FColor LineColor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.Draw2DLine", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X2, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y2, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineColor, paramsPtr + 16);
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
    /// Function: Draw3DLine
    /// </summary>
    public unsafe virtual void Draw3DLine(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, BmSDK.GameObject.FColor LineColor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HUD.Draw3DLine", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineColor, paramsPtr + 24);
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
    /// Struct: FKismetDrawTextInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FKismetDrawTextInfo
    {
        /// <summary>
        /// StrProperty: MessageText
        /// </summary>
        public unsafe BmSDK.FString MessageText
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: AppendedText
        /// </summary>
        public unsafe BmSDK.FString AppendedText
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: MessageFont
        /// </summary>
        public unsafe BmSDK.Engine.Font MessageFont
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Font>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: MessageFontScale
        /// </summary>
        public unsafe System.Numerics.Vector2 MessageFontScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: MessageOffset
        /// </summary>
        public unsafe System.Numerics.Vector2 MessageOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: MessageColor
        /// </summary>
        public unsafe BmSDK.GameObject.FColor MessageColor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: MessageEndTime
        /// </summary>
        public unsafe float MessageEndTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
    }

    /// <summary>
    /// Struct: FHudLocalizedMessage
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial record struct FHudLocalizedMessage
    {
        /// <summary>
        /// ClassProperty: Message
        /// </summary>
        public unsafe BmSDK.Class Message
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: StringMessage
        /// </summary>
        public unsafe BmSDK.FString StringMessage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: Switch
        /// </summary>
        public unsafe int Switch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: EndOfLife
        /// </summary>
        public unsafe float EndOfLife
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: Lifetime
        /// </summary>
        public unsafe float Lifetime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: PosY
        /// </summary>
        public unsafe float PosY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: DrawColor
        /// </summary>
        public unsafe BmSDK.GameObject.FColor DrawColor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: FontSize
        /// </summary>
        public unsafe int FontSize
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ObjectProperty: StringFont
        /// </summary>
        public unsafe BmSDK.Engine.Font StringFont
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Font>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: DX
        /// </summary>
        public unsafe float DX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: DY
        /// </summary>
        public unsafe float DY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// BoolProperty: Drawn
        /// </summary>
        public unsafe bool Drawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }; }
        }

        /// <summary>
        /// IntProperty: Count
        /// </summary>
        public unsafe int Count
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// ObjectProperty: OptionalObject
        /// </summary>
        public unsafe BmSDK.GameObject OptionalObject
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }
    }

    /// <summary>
    /// Struct: FConsoleMessage
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FConsoleMessage
    {
        /// <summary>
        /// StrProperty: Text
        /// </summary>
        public unsafe BmSDK.FString Text
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: TextColor
        /// </summary>
        public unsafe BmSDK.GameObject.FColor TextColor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: MessageLife
        /// </summary>
        public unsafe float MessageLife
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: PRI
        /// </summary>
        public unsafe BmSDK.Engine.PlayerReplicationInfo PRI
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerReplicationInfo>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// StructProperty: WhiteColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor WhiteColor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 428);

    /// <summary>
    /// StructProperty: GreenColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor GreenColor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 432);

    /// <summary>
    /// StructProperty: RedColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor RedColor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 436);

    /// <summary>
    /// ObjectProperty: PlayerOwner
    /// </summary>
    public unsafe BmSDK.Engine.PlayerController PlayerOwner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// BoolProperty: bLostFocusPaused
    /// </summary>
    public unsafe bool bLostFocusPaused
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bShowHUD
    /// </summary>
    public unsafe bool bShowHUD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bShowScores
    /// </summary>
    public unsafe bool bShowScores
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bShowDebugInfo
    /// </summary>
    public unsafe bool bShowDebugInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bShowBadConnectionAlert
    /// </summary>
    public unsafe bool bShowBadConnectionAlert
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bMessageBeep
    /// </summary>
    public unsafe bool bMessageBeep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bShowOverlays
    /// </summary>
    public unsafe bool bShowOverlays
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// FloatProperty: HudCanvasScale
    /// </summary>
    public unsafe float HudCanvasScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ArrayProperty: PostRenderedActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> PostRenderedActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ArrayProperty: ConsoleMessages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.HUD.FConsoleMessage> ConsoleMessages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.HUD.FConsoleMessage>>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// StructProperty: ConsoleColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor ConsoleColor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 476);

    /// <summary>
    /// IntProperty: ConsoleMessageCount
    /// </summary>
    public unsafe int ConsoleMessageCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// IntProperty: ConsoleFontSize
    /// </summary>
    public unsafe int ConsoleFontSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// IntProperty: MessageFontOffset
    /// </summary>
    public unsafe int MessageFontOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// IntProperty: MaxHUDAreaMessageCount
    /// </summary>
    public unsafe int MaxHUDAreaMessageCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: LocalMessages
    /// </summary>
    public InlineArray<BmSDK.Engine.HUD.FHudLocalizedMessage> LocalMessages => new(8, Ptr + 496, 64, this);

    /// <summary>
    /// StructProperty: LocalMessages
    /// </summary>
    public unsafe ref BmSDK.Engine.HUD.FHudLocalizedMessage LocalMessages_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.HUD.FHudLocalizedMessage>(Ptr + 496);
    /// <summary>
    /// StructProperty: LocalMessages
    /// </summary>
    public unsafe ref BmSDK.Engine.HUD.FHudLocalizedMessage LocalMessages_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.HUD.FHudLocalizedMessage>(Ptr + 560);
    /// <summary>
    /// StructProperty: LocalMessages
    /// </summary>
    public unsafe ref BmSDK.Engine.HUD.FHudLocalizedMessage LocalMessages_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.HUD.FHudLocalizedMessage>(Ptr + 624);
    /// <summary>
    /// StructProperty: LocalMessages
    /// </summary>
    public unsafe ref BmSDK.Engine.HUD.FHudLocalizedMessage LocalMessages_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.HUD.FHudLocalizedMessage>(Ptr + 688);
    /// <summary>
    /// StructProperty: LocalMessages
    /// </summary>
    public unsafe ref BmSDK.Engine.HUD.FHudLocalizedMessage LocalMessages_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.HUD.FHudLocalizedMessage>(Ptr + 752);
    /// <summary>
    /// StructProperty: LocalMessages
    /// </summary>
    public unsafe ref BmSDK.Engine.HUD.FHudLocalizedMessage LocalMessages_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.HUD.FHudLocalizedMessage>(Ptr + 816);
    /// <summary>
    /// StructProperty: LocalMessages
    /// </summary>
    public unsafe ref BmSDK.Engine.HUD.FHudLocalizedMessage LocalMessages_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.HUD.FHudLocalizedMessage>(Ptr + 880);
    /// <summary>
    /// StructProperty: LocalMessages
    /// </summary>
    public unsafe ref BmSDK.Engine.HUD.FHudLocalizedMessage LocalMessages_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.HUD.FHudLocalizedMessage>(Ptr + 944);

    /// <summary>
    /// FloatProperty: ConsoleMessagePosX
    /// </summary>
    public unsafe float ConsoleMessagePosX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// FloatProperty: ConsoleMessagePosY
    /// </summary>
    public unsafe float ConsoleMessagePosY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ObjectProperty: Canvas
    /// </summary>
    public unsafe BmSDK.Engine.Canvas Canvas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Canvas>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// FloatProperty: LastHUDRenderTime
    /// </summary>
    public unsafe float LastHUDRenderTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// FloatProperty: RenderDelta
    /// </summary>
    public unsafe float RenderDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// FloatProperty: SizeX
    /// </summary>
    public unsafe float SizeX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: SizeY
    /// </summary>
    public unsafe float SizeY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// FloatProperty: CenterX
    /// </summary>
    public unsafe float CenterX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: CenterY
    /// </summary>
    public unsafe float CenterY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// FloatProperty: RatioX
    /// </summary>
    public unsafe float RatioX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// FloatProperty: RatioY
    /// </summary>
    public unsafe float RatioY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// ArrayProperty: DebugDisplay
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> DebugDisplay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// ArrayProperty: KismetTextInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.HUD.FKismetDrawTextInfo> KismetTextInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.HUD.FKismetDrawTextInfo>>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }
}
