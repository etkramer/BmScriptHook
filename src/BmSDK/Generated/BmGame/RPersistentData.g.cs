#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPersistentData<br/>
/// (size = 1400)
/// (flags = 134217874)
/// </summary>
public partial class RPersistentData : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPersistentData", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPersistentData.
    /// </summary>
    public static RPersistentData DefaultObject => (RPersistentData)StaticClass().DefaultObject;

    internal RPersistentData() { }

    /// <summary>
    /// Constructs a new RPersistentData
    /// </summary>
    public RPersistentData(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPersistentData Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPersistentData(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPersistentData>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentData>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPersistentData>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentData>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentData>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentData>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPersistentData>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentData>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: GetSideStoryCharacterProgressStatus
    /// </summary>
    public unsafe virtual int GetSideStoryCharacterProgressStatus(BmSDK.BmGame.RPersistentData.EProgressCharacter Who)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetSideStoryCharacterProgressStatus", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Who, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetSideStoryCharacterProgressStatus
    /// </summary>
    public unsafe virtual void SetSideStoryCharacterProgressStatus(BmSDK.BmGame.RPersistentData.EProgressCharacter Who, int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetSideStoryCharacterProgressStatus", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Who, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncreaseCatwomanJewellery
    /// </summary>
    public unsafe virtual bool IncreaseCatwomanJewellery(BmSDK.BmGame.RPlayerController RPC, int JewelleryValue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncreaseCatwomanJewellery", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JewelleryValue, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: FinishedCatwomanJewellery
    /// </summary>
    public unsafe virtual bool FinishedCatwomanJewellery()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.FinishedCatwomanJewellery", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ShowRaftCancelTutorial
    /// </summary>
    public unsafe virtual bool ShowRaftCancelTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowRaftCancelTutorial", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IncrementRaftCancelTutorial
    /// </summary>
    public unsafe virtual void IncrementRaftCancelTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementRaftCancelTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartRaftCancelTutorial
    /// </summary>
    public unsafe virtual void StartRaftCancelTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartRaftCancelTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartGrappleBoostTutorial
    /// </summary>
    public unsafe virtual void StartGrappleBoostTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartGrappleBoostTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncrementGrappleBoostTutorial
    /// </summary>
    public unsafe virtual void IncrementGrappleBoostTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementGrappleBoostTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowGrappleBoostTutorial
    /// </summary>
    public unsafe virtual bool ShowGrappleBoostTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowGrappleBoostTutorial", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StartStealthMoveTutorial
    /// </summary>
    public unsafe virtual void StartStealthMoveTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartStealthMoveTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncrementStealthMoveTutorialTimer
    /// </summary>
    public unsafe virtual void IncrementStealthMoveTutorialTimer(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementStealthMoveTutorialTimer", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowStealthMoveTutorial
    /// </summary>
    public unsafe virtual bool ShowStealthMoveTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowStealthMoveTutorial", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StartGrapplingTutorial
    /// </summary>
    public unsafe virtual void StartGrapplingTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartGrapplingTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncrementGrappleTutorial
    /// </summary>
    public unsafe virtual void IncrementGrappleTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementGrappleTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowGrappleTutorial
    /// </summary>
    public unsafe virtual bool ShowGrappleTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowGrappleTutorial", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StartGlideBoostTutorial
    /// </summary>
    public unsafe virtual void StartGlideBoostTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartGlideBoostTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartGlidingTutorial
    /// </summary>
    public unsafe virtual void StartGlidingTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartGlidingTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowAnyGlideTutorials
    /// </summary>
    public unsafe virtual bool ShowAnyGlideTutorials()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowAnyGlideTutorials", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IncrementPullUpFromDivePrompt
    /// </summary>
    public unsafe virtual void IncrementPullUpFromDivePrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementPullUpFromDivePrompt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowPullUpFromDivePrompt
    /// </summary>
    public unsafe virtual bool ShowPullUpFromDivePrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowPullUpFromDivePrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IncrementGlideDivePrompt
    /// </summary>
    public unsafe virtual void IncrementGlideDivePrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementGlideDivePrompt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncrementGlideSteerPromptUD
    /// </summary>
    public unsafe virtual void IncrementGlideSteerPromptUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementGlideSteerPromptUD", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowGlideSteerPromptUD
    /// </summary>
    public unsafe virtual bool ShowGlideSteerPromptUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowGlideSteerPromptUD", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IncrementGlideSteerPromptLR
    /// </summary>
    public unsafe virtual void IncrementGlideSteerPromptLR()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementGlideSteerPromptLR", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncrementGlideTimer
    /// </summary>
    public unsafe virtual void IncrementGlideTimer(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementGlideTimer", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowGlidePrompt
    /// </summary>
    public unsafe virtual bool ShowGlidePrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowGlidePrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ClearMapObjectivePanList
    /// </summary>
    public unsafe virtual void ClearMapObjectivePanList()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ClearMapObjectivePanList", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveDynamicMapItemsByChapter
    /// </summary>
    public unsafe virtual void RemoveDynamicMapItemsByChapter(BmSDK.FString ChapterPrefix)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.RemoveDynamicMapItemsByChapter", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChapterPrefix, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveDynamicMapItem
    /// </summary>
    public unsafe virtual void RemoveDynamicMapItem(BmSDK.FString ItemName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.RemoveDynamicMapItem", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddDynamicMapItem
    /// </summary>
    public unsafe virtual void AddDynamicMapItem(BmSDK.FString ItemName, BmSDK.FString ItemType, BmSDK.FString PMap, int X, int Y)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.AddDynamicMapItem", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PMap, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveTrail
    /// </summary>
    public unsafe virtual void RemoveTrail(BmSDK.FString TrailName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.RemoveTrail", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TrailName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddTrailItem
    /// </summary>
    public unsafe virtual void AddTrailItem(BmSDK.FString TrailName, BmSDK.FString PMap, int X, int Y)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.AddTrailItem", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TrailName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PMap, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemapCharacter_Progress2Bio
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPersistentData.EBioCharacter RemapCharacter_Progress2Bio(BmSDK.BmGame.RPersistentData.EProgressCharacter inProgress)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.RemapCharacter_Progress2Bio", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inProgress, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.EBioCharacter>(paramsPtr + 1);
    }

    /// <summary>
    /// Function: SetObjectiveLocation
    /// </summary>
    public unsafe virtual void SetObjectiveLocation(System.Numerics.Vector3 the_location)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetObjectiveLocation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_location, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsObjectiveTrackingActive
    /// </summary>
    public unsafe virtual bool IsObjectiveTrackingActive()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IsObjectiveTrackingActive", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetObjectiveTrackingActive
    /// </summary>
    public unsafe virtual void SetObjectiveTrackingActive(bool is_active)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetObjectiveTrackingActive", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateRadioStation
    /// </summary>
    public unsafe virtual int CreateRadioStation(BmSDK.FString StationName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.CreateRadioStation", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StationName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: SetRadioStationFlag
    /// </summary>
    public unsafe virtual void SetRadioStationFlag(int station_index, byte attribute_flag, bool value_truefalse)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetRadioStationFlag", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(station_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(attribute_flag, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(value_truefalse, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckRadioStationFlag
    /// </summary>
    public unsafe virtual bool CheckRadioStationFlag(int station_index, byte attribute_flag)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.CheckRadioStationFlag", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(station_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(attribute_flag, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetRadioStationIndex
    /// </summary>
    public unsafe virtual int GetRadioStationIndex(BmSDK.FString StationName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetRadioStationIndex", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StationName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: UpdateButtonBashDDA
    /// </summary>
    public unsafe virtual void UpdateButtonBashDDA(ref float TimeAtMinSpeed, ref float TimeAtMaxSpeed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.UpdateButtonBashDDA", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeAtMinSpeed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeAtMaxSpeed, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TimeAtMinSpeed = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
        TimeAtMaxSpeed = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: SixaxisTeethPrompt
    /// </summary>
    public unsafe virtual bool SixaxisTeethPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SixaxisTeethPrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SixaxisTeethPerformed
    /// </summary>
    public unsafe virtual void SixaxisTeethPerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SixaxisTeethPerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SixaxisBatarangPrompt
    /// </summary>
    public unsafe virtual bool SixaxisBatarangPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SixaxisBatarangPrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SixaxisBatarangPerformed
    /// </summary>
    public unsafe virtual void SixaxisBatarangPerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SixaxisBatarangPerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SixaxisGlidePrompt
    /// </summary>
    public unsafe virtual bool SixaxisGlidePrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SixaxisGlidePrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SixaxisGlidePerformed
    /// </summary>
    public unsafe virtual void SixaxisGlidePerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SixaxisGlidePerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HangModeDropPrompt
    /// </summary>
    public unsafe virtual bool HangModeDropPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.HangModeDropPrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HangModeDropPerformed
    /// </summary>
    public unsafe virtual void HangModeDropPerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.HangModeDropPerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DropOffGrapplePerformed
    /// </summary>
    public unsafe virtual void DropOffGrapplePerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.DropOffGrapplePerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GlideOffWallPrompt
    /// </summary>
    public unsafe virtual bool GlideOffWallPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GlideOffWallPrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GlideOffWallPerformed
    /// </summary>
    public unsafe virtual void GlideOffWallPerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GlideOffWallPerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LineLaunchDropPrompt
    /// </summary>
    public unsafe virtual bool LineLaunchDropPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.LineLaunchDropPrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: LineLaunchDropPerformed
    /// </summary>
    public unsafe virtual void LineLaunchDropPerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.LineLaunchDropPerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearAutomaticCombatTutorials
    /// </summary>
    public unsafe virtual void ClearAutomaticCombatTutorials()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ClearAutomaticCombatTutorials", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TutorialActionAchieved
    /// </summary>
    public unsafe virtual void TutorialActionAchieved(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.TutorialActionAchieved", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetNumActivationsForAction
    /// </summary>
    public unsafe virtual int GetNumActivationsForAction(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetNumActivationsForAction", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ShouldShowTutorial
    /// </summary>
    public unsafe virtual int ShouldShowTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShouldShowTutorial", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ResetTutorialProgress
    /// </summary>
    public unsafe virtual void ResetTutorialProgress(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ResetTutorialProgress", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DesignDeactivateTutorial
    /// </summary>
    public unsafe virtual void DesignDeactivateTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.DesignDeactivateTutorial", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DesignActivateTutorial
    /// </summary>
    public unsafe virtual void DesignActivateTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.DesignActivateTutorial", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayerStopTutorial
    /// </summary>
    public unsafe virtual void PlayerStopTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.PlayerStopTutorial", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayerStartTutorial
    /// </summary>
    public unsafe virtual void PlayerStartTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.PlayerStartTutorial", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsTutorialPlayerActive
    /// </summary>
    public unsafe virtual bool IsTutorialPlayerActive(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IsTutorialPlayerActive", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: AutoDeactivateTutorial
    /// </summary>
    public unsafe virtual void AutoDeactivateTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.AutoDeactivateTutorial", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AutoActivateTutorial
    /// </summary>
    public unsafe virtual void AutoActivateTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.AutoActivateTutorial", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PadStr
    /// </summary>
    public unsafe virtual BmSDK.FString PadStr(BmSDK.FString InStr, int DesiredLen)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.PadStr", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InStr, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredLen, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: Dump
    /// </summary>
    public unsafe virtual void Dump()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.Dump", true);
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ToTimeStr
    /// </summary>
    public unsafe virtual BmSDK.FString ToTimeStr(float inTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ToTimeStr", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ClearActiveMapTrail
    /// </summary>
    public unsafe virtual void ClearActiveMapTrail()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ClearActiveMapTrail", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPersistentLevelIndexByName
    /// </summary>
    public unsafe virtual int GetPersistentLevelIndexByName(BmSDK.FName MapName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetPersistentLevelIndexByName", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: IncreaseCharacterTapesCollected
    /// </summary>
    public unsafe virtual int IncreaseCharacterTapesCollected(BmSDK.BmGame.RPersistentData.ETapeCharacter CharacterName, BmSDK.BmGame.RPersistentData.ERiddlerLocationName Zone)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncreaseCharacterTapesCollected", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetPlayableCharacter
    /// </summary>
    public unsafe virtual void SetPlayableCharacter(BmSDK.FName NewCharacterName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetPlayableCharacter", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCharacterName, paramsPtr + 0);
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
    /// Struct: FTutorialInfoNew
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FTutorialInfoNew
    {
        /// <summary>
        /// ByteProperty: bPlayerActivated
        /// </summary>
        public unsafe byte bPlayerActivated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: bAutoActivated
        /// </summary>
        public unsafe byte bAutoActivated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// ByteProperty: bDesignActivated
        /// </summary>
        public unsafe byte bDesignActivated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2); }; }
        }

        /// <summary>
        /// IntProperty: ActionsRequired
        /// </summary>
        public unsafe int ActionsRequired
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: TotalAchieved
        /// </summary>
        public unsafe int TotalAchieved
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: Progress
        /// </summary>
        public unsafe int Progress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FTutorialInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FTutorialInfo
    {
        /// <summary>
        /// ByteProperty: bPlayerActivated
        /// </summary>
        public unsafe byte bPlayerActivated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: bAutoActivated
        /// </summary>
        public unsafe byte bAutoActivated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// IntProperty: ActionsRequired
        /// </summary>
        public unsafe int ActionsRequired
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: TotalAchieved
        /// </summary>
        public unsafe int TotalAchieved
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: Progress
        /// </summary>
        public unsafe int Progress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: ETutorialType
    /// </summary>
    public enum ETutorialType : byte
    {
        TUT_None = 0,
        TUT_Combat_Strike = 1,
        TUT_Combat_Counter = 2,
        TUT_Combat_BladeComboCounter = 3,
        TUT_Combat_SuperBladeComboCounter = 4,
        TUT_Combat_Beatdown = 5,
        TUT_Combat_AerialAttack = 6,
        TUT_Combat_DirectedAerialAttack = 7,
        TUT_Combat_Rhythm = 8,
        TUT_Combat_Takedown = 9,
        TUT_Combat_DisarmAndDestroy = 10,
        TUT_Combat_GroupStun = 11,
        TUT_Combat_GroupGroundKO = 12,
        TUT_Combat_GroupTrip = 13,
        TUT_Combat_GroupAttack = 14,
        TUT_Combat_SuperStun = 15,
        TUT_Combat_ComboGroundKO = 16,
        TUT_Combat_BatclawSlam = 17,
        TUT_Thug_Knife = 18,
        TUT_Thug_StunStick = 19,
        TUT_Thug_Armoured = 20,
        TUT_Thug_Shield = 21,
        TUT_Thug_Titan = 22,
        TUT_Combat_GroundTakedown = 23,
        TUT_Predator_GroundTakedown = 24,
        TUT_Lunatic_GroundTakedown = 25,
        TUT_MAX = 26,
    }

    /// <summary>
    /// IntProperty: Version
    /// </summary>
    public unsafe int Version
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// IntProperty: SaveCount
    /// </summary>
    public unsafe int SaveCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// StructProperty: PlayerLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PlayerLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 52);

    /// <summary>
    /// StructProperty: PlayerRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator PlayerRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 64);

    /// <summary>
    /// StructProperty: LastDoorData
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastDoorData
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 76);

    /// <summary>
    /// IntProperty: LastDoorRotation
    /// </summary>
    public unsafe int LastDoorRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// StrProperty: LastDoorRoom
    /// </summary>
    public unsafe BmSDK.FString LastDoorRoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: LevelsLoaded
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LevelsLoaded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ArrayProperty: LevelsLoadedNotVisible
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LevelsLoadedNotVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: SeekFreePackagesToLoad
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> SeekFreePackagesToLoad
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// StrProperty: PersistentLevel
    /// </summary>
    public unsafe BmSDK.FString PersistentLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// StrProperty: CurrentLevel
    /// </summary>
    public unsafe BmSDK.FString CurrentLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// StrProperty: NextLevel
    /// </summary>
    public unsafe BmSDK.FString NextLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ArrayProperty: StreamingLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> StreamingLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// ArrayProperty: StreamingLevelsLODs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> StreamingLevelsLODs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ArrayProperty: FlagNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> FlagNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// IntProperty: StoryDLCImageId
    /// </summary>
    public unsafe int StoryDLCImageId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// IntProperty: SaveGameChapter
    /// </summary>
    public unsafe int SaveGameChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// IntProperty: SaveGameIndex
    /// </summary>
    public unsafe int SaveGameIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ByteProperty: IsSaveGameStartPoint
    /// </summary>
    public unsafe byte IsSaveGameStartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// ByteProperty: StorySynopsisState
    /// </summary>
    public unsafe byte StorySynopsisState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 225); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 225); }
    }

    /// <summary>
    /// ByteProperty: DetectiveModeJammed
    /// </summary>
    public unsafe byte DetectiveModeJammed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 226); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 226); }
    }

    /// <summary>
    /// ByteProperty: ARTraining_RaceWins
    /// </summary>
    public unsafe byte ARTraining_RaceWins
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 227); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 227); }
    }

    /// <summary>
    /// ByteProperty: BruceWayneLegChainsBroken
    /// </summary>
    public unsafe byte BruceWayneLegChainsBroken
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ByteProperty: HelpPrompt_GlideTutorialStage
    /// </summary>
    public unsafe byte HelpPrompt_GlideTutorialStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 229); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 229); }
    }

    /// <summary>
    /// ByteProperty: CurrentChapter
    /// </summary>
    public unsafe byte CurrentChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 230); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 230); }
    }

    /// <summary>
    /// ByteProperty: CurrentSubChapter
    /// </summary>
    public unsafe byte CurrentSubChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 231); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 231); }
    }

    /// <summary>
    /// InlineArray{ByteProperty}: CurrentSideChapter
    /// </summary>
    public InlineArray<byte> CurrentSideChapter => new(26, Ptr + 232, 1, this);

    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 233); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 233); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 234); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 234); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 235); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 235); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 237); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 237); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 238); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 238); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 239); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 239); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 241); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 241); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 242); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 242); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 243); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 243); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 245); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 245); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 246); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 246); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 247); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 247); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 249); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 249); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 250); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 250); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 251); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 251); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 253); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 253); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 254); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 254); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 255); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 255); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 257); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 257); }
    }

    /// <summary>
    /// InlineArray{ByteProperty}: CurrentSideSubChapter
    /// </summary>
    public InlineArray<byte> CurrentSideSubChapter => new(26, Ptr + 258, 1, this);

    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 258); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 258); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 259); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 259); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 261); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 261); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 262); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 262); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 263); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 263); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 265); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 265); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 266); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 266); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 267); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 267); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 269); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 269); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 270); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 270); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 271); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 271); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 273); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 273); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 274); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 274); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 275); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 275); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 277); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 277); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 278); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 278); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 279); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 279); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 281); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 281); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 282); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 282); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 283); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 283); }
    }

    /// <summary>
    /// ByteProperty: ProgressLastStatusUpdated
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.EProgressCharacter ProgressLastStatusUpdated
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.EProgressCharacter>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ByteProperty: Map_CriminalDBIndex
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.EProgressCharacter Map_CriminalDBIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.EProgressCharacter>(Ptr + 285); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 285); }
    }

    /// <summary>
    /// ByteProperty: Bio_LocIndex
    /// </summary>
    public unsafe byte Bio_LocIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 286); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 286); }
    }

    /// <summary>
    /// ByteProperty: Bio_PageIndex
    /// </summary>
    public unsafe byte Bio_PageIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 287); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 287); }
    }

    /// <summary>
    /// ByteProperty: Bio_TapeIndex
    /// </summary>
    public unsafe byte Bio_TapeIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// ByteProperty: Progress_Index
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.EProgressCharacter Progress_Index
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.EProgressCharacter>(Ptr + 289); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 289); }
    }

    /// <summary>
    /// ByteProperty: Upgrade_CategoryIndex
    /// </summary>
    public unsafe byte Upgrade_CategoryIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 290); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 290); }
    }

    /// <summary>
    /// ByteProperty: Upgrade_ItemIndex
    /// </summary>
    public unsafe byte Upgrade_ItemIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 291); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 291); }
    }

    /// <summary>
    /// ByteProperty: Riddler_LocIndex
    /// </summary>
    public unsafe byte Riddler_LocIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// ByteProperty: Riddler_IndexX
    /// </summary>
    public unsafe byte Riddler_IndexX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 293); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 293); }
    }

    /// <summary>
    /// ByteProperty: Riddler_IndexY
    /// </summary>
    public unsafe byte Riddler_IndexY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 294); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 294); }
    }

    /// <summary>
    /// ByteProperty: Enygma_IndexLeft
    /// </summary>
    public unsafe byte Enygma_IndexLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 295); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 295); }
    }

    /// <summary>
    /// ByteProperty: Enygma_IndexRight
    /// </summary>
    public unsafe byte Enygma_IndexRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// ByteProperty: ChallengeUnlockIndex
    /// </summary>
    public unsafe byte ChallengeUnlockIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 297); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 297); }
    }

    /// <summary>
    /// ByteProperty: bObjectiveTrackerActive
    /// </summary>
    public unsafe byte bObjectiveTrackerActive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 298); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 298); }
    }

    /// <summary>
    /// ByteProperty: CustomWaypoint_Type
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.ECustomWayPointType CustomWaypoint_Type
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.ECustomWayPointType>(Ptr + 299); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 299); }
    }

    /// <summary>
    /// ByteProperty: CustomWaypoint_Character
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.EProgressCharacter CustomWaypoint_Character
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.EProgressCharacter>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// ByteProperty: CustomWaypoint_NotReached
    /// </summary>
    public unsafe byte CustomWaypoint_NotReached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 301); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 301); }
    }

    /// <summary>
    /// ByteProperty: PoisonLevel
    /// </summary>
    public unsafe byte PoisonLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 302); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 302); }
    }

    /// <summary>
    /// ByteProperty: CheckForRiddlerUnlocks
    /// </summary>
    public unsafe byte CheckForRiddlerUnlocks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 303); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 303); }
    }

    /// <summary>
    /// ByteProperty: Zsasz_DoneRace0Taunt
    /// </summary>
    public unsafe byte Zsasz_DoneRace0Taunt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// ByteProperty: Zsasz_NewRingingPhone
    /// </summary>
    public unsafe byte Zsasz_NewRingingPhone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 305); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 305); }
    }

    /// <summary>
    /// ByteProperty: Zsasz_DoneRace1Intro
    /// </summary>
    public unsafe byte Zsasz_DoneRace1Intro
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 306); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 306); }
    }

    /// <summary>
    /// ByteProperty: ExplainedBatarangRules
    /// </summary>
    public unsafe byte ExplainedBatarangRules
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 307); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 307); }
    }

    /// <summary>
    /// ByteProperty: bPlayedFreezeBlastHint
    /// </summary>
    public unsafe byte bPlayedFreezeBlastHint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ByteProperty: GrundyQuickGelHappened
    /// </summary>
    public unsafe byte GrundyQuickGelHappened
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 309); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 309); }
    }

    /// <summary>
    /// ByteProperty: GrundyQuickDetonateHappened
    /// </summary>
    public unsafe byte GrundyQuickDetonateHappened
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 310); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 310); }
    }

    /// <summary>
    /// ByteProperty: bFakeZsaszPhoneForMap
    /// </summary>
    public unsafe byte bFakeZsaszPhoneForMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 311); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 311); }
    }

    /// <summary>
    /// StrProperty: Description
    /// </summary>
    public unsafe BmSDK.FString Description
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// StrProperty: SideObjective
    /// </summary>
    public unsafe BmSDK.FString SideObjective
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// StrProperty: PrimaryObjective
    /// </summary>
    public unsafe BmSDK.FString PrimaryObjective
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// ArrayProperty: ObjectivesIncomplete
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ObjectivesIncomplete
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// ArrayProperty: ObjectivesMapObj
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ObjectivesMapObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ArrayProperty: ObjectivesNewMapObj
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ObjectivesNewMapObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// IntProperty: ShowRiddlerFlag
    /// </summary>
    public unsafe int ShowRiddlerFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// IntProperty: ShowBioFlag
    /// </summary>
    public unsafe int ShowBioFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// NameProperty: CurrentGadgetName
    /// </summary>
    public unsafe BmSDK.FName CurrentGadgetName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// StrProperty: LastScannedLocMap
    /// </summary>
    public unsafe BmSDK.FString LastScannedLocMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// StructProperty: LastScannedLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastScannedLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 412);

    /// <summary>
    /// StrProperty: LastAmbientSoundCue
    /// </summary>
    public unsafe BmSDK.FString LastAmbientSoundCue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// StrProperty: LastRoomMixBin
    /// </summary>
    public unsafe BmSDK.FString LastRoomMixBin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// IntProperty: PlayerHealth
    /// </summary>
    public unsafe int PlayerHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// IntProperty: BallisticArmour
    /// </summary>
    public unsafe int BallisticArmour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// IntProperty: MeleeArmour
    /// </summary>
    public unsafe int MeleeArmour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// IntProperty: CWBallisticArmour
    /// </summary>
    public unsafe int CWBallisticArmour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// IntProperty: CWMeleeArmour
    /// </summary>
    public unsafe int CWMeleeArmour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// FloatProperty: ButtonBashDDA
    /// </summary>
    public unsafe float ButtonBashDDA
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_Strike
    /// </summary>
    public unsafe int HelpPromptCount_Strike
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_Counter
    /// </summary>
    public unsafe int HelpPromptCount_Counter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_Throw
    /// </summary>
    public unsafe int HelpPromptCount_Throw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_Takedown
    /// </summary>
    public unsafe int HelpPromptCount_Takedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_GroundTakedown
    /// </summary>
    public unsafe int HelpPromptCount_GroundTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_LunaticGroundTakedown
    /// </summary>
    public unsafe int HelpPromptCount_LunaticGroundTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_PredatorGroundTakedown
    /// </summary>
    public unsafe int HelpPromptCount_PredatorGroundTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_ComboBatarang
    /// </summary>
    public unsafe int HelpPromptCount_ComboBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_LineLauncherDrop
    /// </summary>
    public unsafe int HelpPromptCount_LineLauncherDrop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_HangModeDrop
    /// </summary>
    public unsafe int HelpPromptCount_HangModeDrop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_DropOffGrapple
    /// </summary>
    public unsafe int HelpPromptCount_DropOffGrapple
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_GlideOffWall
    /// </summary>
    public unsafe int HelpPromptCount_GlideOffWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_SixaxisGlide
    /// </summary>
    public unsafe int HelpPromptCount_SixaxisGlide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_SixaxisBatarang
    /// </summary>
    public unsafe int HelpPromptCount_SixaxisBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_SixaxisTeeth
    /// </summary>
    public unsafe int HelpPromptCount_SixaxisTeeth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// FloatProperty: HelpPrompt_TimeGliding
    /// </summary>
    public unsafe float HelpPrompt_TimeGliding
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_GlideSteerLR
    /// </summary>
    public unsafe int HelpPromptCount_GlideSteerLR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_GlideSteerUD
    /// </summary>
    public unsafe int HelpPromptCount_GlideSteerUD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_PullUpFromDive
    /// </summary>
    public unsafe int HelpPromptCount_PullUpFromDive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_Dive
    /// </summary>
    public unsafe int HelpPromptCount_Dive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_GrappleInOW
    /// </summary>
    public unsafe int HelpPromptCount_GrappleInOW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_SlideUnderBarrier
    /// </summary>
    public unsafe int HelpPromptCount_SlideUnderBarrier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_GrappleBoost
    /// </summary>
    public unsafe int HelpPromptCount_GrappleBoost
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_RaftCancel
    /// </summary>
    public unsafe int HelpPromptCount_RaftCancel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// FloatProperty: HelpPromptTimer_SteathMove
    /// </summary>
    public unsafe float HelpPromptTimer_SteathMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// IntProperty: NumTimesEscapeHelpDisplayed
    /// </summary>
    public unsafe int NumTimesEscapeHelpDisplayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// IntProperty: NumTimesGrateHelpDisplayed
    /// </summary>
    public unsafe int NumTimesGrateHelpDisplayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// IntProperty: NumTimesGroundTakedownHelpDisplayed
    /// </summary>
    public unsafe int NumTimesGroundTakedownHelpDisplayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// FloatProperty: TotalTimePlayed
    /// </summary>
    public unsafe float TotalTimePlayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// IntProperty: StoryPercentage
    /// </summary>
    public unsafe int StoryPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// IntProperty: UpgradesIndex
    /// </summary>
    public unsafe int UpgradesIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// ArrayProperty: InterrogationIndexes
    /// </summary>
    public unsafe BmSDK.TArray<int> InterrogationIndexes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ArrayProperty: MapTapeCharactersToBioCharacters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.EBioCharacter> MapTapeCharactersToBioCharacters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.EBioCharacter>>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ArrayProperty: MapBioToProgressCharacters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.EProgressCharacter> MapBioToProgressCharacters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.EProgressCharacter>>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// IntProperty: RadioStationIndexMostRecentlyFound
    /// </summary>
    public unsafe int RadioStationIndexMostRecentlyFound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RadioStationNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationCurrentSequences
    /// </summary>
    public unsafe BmSDK.TArray<byte> RadioStationCurrentSequences
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationBitFields
    /// </summary>
    public unsafe BmSDK.TArray<byte> RadioStationBitFields
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationTransmissionStrengths
    /// </summary>
    public unsafe BmSDK.TArray<int> RadioStationTransmissionStrengths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationFrequenciesX
    /// </summary>
    public unsafe BmSDK.TArray<float> RadioStationFrequenciesX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationFrequenciesY
    /// </summary>
    public unsafe BmSDK.TArray<float> RadioStationFrequenciesY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationDetailsTransmitter
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RadioStationDetailsTransmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationDetailsEncryptionType
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RadioStationDetailsEncryptionType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationDetailsEncryptionStrength
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RadioStationDetailsEncryptionStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationAudioStateBaseParent
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RadioStationAudioStateBaseParent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationAudioStateBase
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RadioStationAudioStateBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationAudioStateCurrentSequenceParent
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RadioStationAudioStateCurrentSequenceParent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationAudioStateCurrentSequence
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RadioStationAudioStateCurrentSequence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationOneShotOverride
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RadioStationOneShotOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// ArrayProperty: ProgressCharacterLocation
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ProgressCharacterLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ArrayProperty: ProgressCharacterStatus
    /// </summary>
    public unsafe BmSDK.TArray<int> ProgressCharacterStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ArrayProperty: ProgressCharacterSynopsisTextId
    /// </summary>
    public unsafe BmSDK.TArray<int> ProgressCharacterSynopsisTextId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ArrayProperty: ProgressCharacterProgressTextId
    /// </summary>
    public unsafe BmSDK.TArray<int> ProgressCharacterProgressTextId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// ArrayProperty: ProgressCharacterPercentage
    /// </summary>
    public unsafe BmSDK.TArray<int> ProgressCharacterPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ArrayProperty: ProgressCharacterIdentityUnknown
    /// </summary>
    public unsafe BmSDK.TArray<int> ProgressCharacterIdentityUnknown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// ArrayProperty: ProgressCharacterLocked
    /// </summary>
    public unsafe BmSDK.TArray<int> ProgressCharacterLocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ArrayProperty: Bio_LocIndexs
    /// </summary>
    public unsafe BmSDK.TArray<int> Bio_LocIndexs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// FloatProperty: Enygma_CooldownTimer
    /// </summary>
    public unsafe float Enygma_CooldownTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// StructProperty: vObjectiveLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 vObjectiveLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 904);

    /// <summary>
    /// ArrayProperty: CustomWaypoint
    /// </summary>
    public unsafe BmSDK.TArray<float> CustomWaypoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// StrProperty: CustomWaypointName
    /// </summary>
    public unsafe BmSDK.FString CustomWaypointName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// StrProperty: CustomWaypointTypeName
    /// </summary>
    public unsafe BmSDK.FString CustomWaypointTypeName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// StrProperty: RealWaypointName
    /// </summary>
    public unsafe BmSDK.FString RealWaypointName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// StrProperty: CustomWaypoint_VisibleFlag
    /// </summary>
    public unsafe BmSDK.FString CustomWaypoint_VisibleFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// StrProperty: CustomWaypoint_DoneFlag
    /// </summary>
    public unsafe BmSDK.FString CustomWaypoint_DoneFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// ArrayProperty: CustomWaypoint_StatesVisible
    /// </summary>
    public unsafe BmSDK.TArray<byte> CustomWaypoint_StatesVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: FacePoisonLevel
    /// </summary>
    public unsafe float FacePoisonLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// NameProperty: PlayableCharacter
    /// </summary>
    public unsafe BmSDK.FName PlayableCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// IntProperty: Zsasz_RingingPhoneIndex
    /// </summary>
    public unsafe int Zsasz_RingingPhoneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// IntProperty: Zsasz_NumRacesUnlocked
    /// </summary>
    public unsafe int Zsasz_NumRacesUnlocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// ArrayProperty: Zsasz_RaceCompleted
    /// </summary>
    public unsafe BmSDK.TArray<byte> Zsasz_RaceCompleted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// ArrayProperty: BullyEncounters_Active
    /// </summary>
    public unsafe BmSDK.TArray<byte> BullyEncounters_Active
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// ArrayProperty: BullyEncounters_Completed
    /// </summary>
    public unsafe BmSDK.TArray<byte> BullyEncounters_Completed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ArrayProperty: BullyEncounters_JackRyder_Active
    /// </summary>
    public unsafe BmSDK.TArray<byte> BullyEncounters_JackRyder_Active
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// ArrayProperty: BullyEncounters_JackRyder_Completed
    /// </summary>
    public unsafe BmSDK.TArray<byte> BullyEncounters_JackRyder_Completed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// ArrayProperty: EvidenceTrails_Name
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> EvidenceTrails_Name
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ArrayProperty: EvidenceTrails_Map
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> EvidenceTrails_Map
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ArrayProperty: EvidenceTrails_X
    /// </summary>
    public unsafe BmSDK.TArray<int> EvidenceTrails_X
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ArrayProperty: EvidenceTrails_Y
    /// </summary>
    public unsafe BmSDK.TArray<int> EvidenceTrails_Y
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// ArrayProperty: DynamicIcons_Name
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DynamicIcons_Name
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ArrayProperty: DynamicIcons_Type
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DynamicIcons_Type
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// ArrayProperty: DynamicIcons_Map
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DynamicIcons_Map
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ArrayProperty: DynamicIcons_X
    /// </summary>
    public unsafe BmSDK.TArray<int> DynamicIcons_X
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// ArrayProperty: DynamicIcons_Y
    /// </summary>
    public unsafe BmSDK.TArray<int> DynamicIcons_Y
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// ArrayProperty: Music_Names
    /// </summary>
    public unsafe BmSDK.TArray<int> Music_Names
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// ArrayProperty: Music_States
    /// </summary>
    public unsafe BmSDK.TArray<int> Music_States
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// ArrayProperty: Music_ParamNames
    /// </summary>
    public unsafe BmSDK.TArray<int> Music_ParamNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// ArrayProperty: Music_ParamValues
    /// </summary>
    public unsafe BmSDK.TArray<float> Music_ParamValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// IntProperty: RiddlerResonatorAfterCh3Count
    /// </summary>
    public unsafe int RiddlerResonatorAfterCh3Count
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// IntProperty: RiddlerResonatorBeforeCh3Count
    /// </summary>
    public unsafe int RiddlerResonatorBeforeCh3Count
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// IntProperty: NumVanillaGlidesAfterDiveTutorial
    /// </summary>
    public unsafe int NumVanillaGlidesAfterDiveTutorial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// IntProperty: FakeZsaszPhoneForMapIndex
    /// </summary>
    public unsafe int FakeZsaszPhoneForMapIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// IntProperty: NumJewelleryFound
    /// </summary>
    public unsafe int NumJewelleryFound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// ArrayProperty: TutInfoOld
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.FTutorialInfo> TutInfoOld
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.FTutorialInfo>>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// ArrayProperty: TutInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.FTutorialInfoNew> TutInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.FTutorialInfoNew>>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// ArrayProperty: AutomaticCombatTutorials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.ETutorialType> AutomaticCombatTutorials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.ETutorialType>>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// IntProperty: NumKnockoutSmashInstructions
    /// </summary>
    public unsafe int NumKnockoutSmashInstructions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// IntProperty: NumGrappleBoostFailHints
    /// </summary>
    public unsafe int NumGrappleBoostFailHints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// ArrayProperty: informantPriorities__OW_A
    /// </summary>
    public unsafe BmSDK.TArray<int> informantPriorities__OW_A
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// ArrayProperty: informantPriorities__OW_C
    /// </summary>
    public unsafe BmSDK.TArray<int> informantPriorities__OW_C
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// ArrayProperty: informantPriorities__OW_E
    /// </summary>
    public unsafe BmSDK.TArray<int> informantPriorities__OW_E
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// ArrayProperty: informantMaintainPriority__OW_A
    /// </summary>
    public unsafe BmSDK.TArray<int> informantMaintainPriority__OW_A
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// ArrayProperty: informantMaintainPriority__OW_C
    /// </summary>
    public unsafe BmSDK.TArray<int> informantMaintainPriority__OW_C
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// ArrayProperty: informantMaintainPriority__OW_E
    /// </summary>
    public unsafe BmSDK.TArray<int> informantMaintainPriority__OW_E
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// IntProperty: ForensicsFilterTally
    /// </summary>
    public unsafe int ForensicsFilterTally
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// IntProperty: lastChapterSeenByInformantManager
    /// </summary>
    public unsafe int lastChapterSeenByInformantManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// IntProperty: numMaggotsBataranged
    /// </summary>
    public unsafe int numMaggotsBataranged
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// IntProperty: CWEpisodeReplayState
    /// </summary>
    public unsafe int CWEpisodeReplayState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// ArrayProperty: PersistentLevelNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> PersistentLevelNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// Enum: EBatmanChallenge
    /// </summary>
    public enum EBatmanChallenge : byte
    {
        EBatChal_None = 0,
        EBatChal_1 = 1,
        EBatChal_2 = 2,
        EBatChal_3 = 3,
        EBatChal_4 = 4,
        EBatChal_5 = 5,
        EBatChal_6 = 6,
        EBatChal_7 = 7,
        EBatChal_8 = 8,
        EBatChal_9 = 9,
        EBatChal_10 = 10,
        EBatChal_11 = 11,
        EBatChal_12 = 12,
        EBatChal_13 = 13,
        EBatChal_14 = 14,
        EBatChal_15 = 15,
        EBatChal_16 = 16,
        EBatChal_17 = 17,
        EBatChal_18 = 18,
        EBatChal_19 = 19,
        EBatChal_20 = 20,
        EBatChal_21 = 21,
        EBatChal_22 = 22,
        EBatChal_23 = 23,
        EBatChal_24 = 24,
        EBatChal_25 = 25,
        EBatChal_26 = 26,
        EBatChal_27 = 27,
        EBatChal_28 = 28,
        EBatChal_29 = 29,
        EBatChal_30 = 30,
        EBatChal_31 = 31,
        EBatChal_32 = 32,
        EBatChal_33 = 33,
        EBatChal_34 = 34,
        EBatChal_35 = 35,
        EBatChal_36 = 36,
        EBatChal_37 = 37,
        EBatChal_38 = 38,
        EBatChal_39 = 39,
        EBatChal_40 = 40,
        EBatChal_41 = 41,
        EBatChal_42 = 42,
        EBatChal_43 = 43,
        EBatChal_44 = 44,
        EBatChal_45 = 45,
        EBatChal_MAX = 46,
    }

    /// <summary>
    /// Enum: ERiddlerLocationName
    /// </summary>
    public enum ERiddlerLocationName : byte
    {
        RiddlerLoc_OWA = 0,
        RiddlerLoc_OWB = 1,
        RiddlerLoc_OWC = 2,
        RiddlerLoc_OWD = 3,
        RiddlerLoc_OWE = 4,
        RiddlerLoc_Steel = 5,
        RiddlerLoc_Museum = 6,
        RiddlerLoc_Underworld = 7,
        RiddlerLoc_Batman = 8,
        RiddlerLoc_MAX = 9,
    }

    /// <summary>
    /// Enum: EPMapNames
    /// </summary>
    public enum EPMapNames : byte
    {
        PMAP_None = 0,
        PMAP_Overworld = 1,
        PMAP_Court = 2,
        PMAP_Steel = 3,
        PMAP_Church = 4,
        PMAP_Museum = 5,
        PMAP_Under = 6,
        PMAP_GCPD = 7,
        PMAP_MAX = 8,
    }

    /// <summary>
    /// Enum: ECharacterViewer
    /// </summary>
    public enum ECharacterViewer : byte
    {
        EViewer_None = 0,
        EViewer_Batman = 1,
        EViewer_Azrael = 2,
        EViewer_BatmanRabbithead = 3,
        EViewer_Robin = 4,
        EViewer_Bruce_Wayne = 5,
        EViewer_Catwoman = 6,
        EViewer_Gordon = 7,
        EViewer_Mr_Freeze = 8,
        EViewer_ArmouredFreeze = 9,
        EViewer_Bane = 10,
        EViewer_Black_Mask = 11,
        EViewer_Clayface = 12,
        EViewer_DeadShot = 13,
        EViewer_Calendar_Man = 14,
        EViewer_Harley_Quinn = 15,
        EViewer_Hush = 16,
        EViewer_ClayfaceJoker = 17,
        EViewer_SickJoker = 18,
        EViewer_Croc = 19,
        EViewer_Mad_Hatter = 20,
        EViewer_Zsasz = 21,
        EViewer_Penguin = 22,
        EViewer_Ivy = 23,
        EViewer_Ras_Ghul = 24,
        EViewer_Riddler = 25,
        EViewer_Solomon_Grundy = 26,
        EViewer_TwoFace = 27,
        EViewer_Hugo_Strange = 28,
        EViewer_Talia_Ghul = 29,
        EViewer_ArkhamGuards = 30,
        EViewer_Doctors = 31,
        EViewer_Hobos = 32,
        EViewer_Kidnappeddoctor = 33,
        EViewer_UndercoverCops = 34,
        EViewer_Jack_Ryder = 35,
        EViewer_Vicki_Vale = 36,
        EViewer_Batwing = 37,
        EViewer_Quincy_Sharp = 38,
        EViewer_JokerThugs = 39,
        EViewer_PenguinThugs = 40,
        EViewer_TwoFaceThugs = 41,
        EViewer_Lieutenants = 42,
        EViewer_Lunatics = 43,
        EViewer_Ninjas = 44,
        EViewer_TygerGuards = 45,
        EViewer_PenguinTitanThug = 46,
        EViewer_JokerTitanThug = 47,
        EViewer_JokerPenguinThugs = 48,
        EViewer_TwoFacePenguinThugs = 49,
        EViewer_JokerfiedOutcasts = 50,
        EViewer_DLC_ASBatman = 51,
        EViewer_DLC_Batman70s = 52,
        EViewer_DLC_BMYearOne = 53,
        EViewer_DLC_BMEarthOne = 54,
        EViewer_DLC_DarkKnight = 55,
        EViewer_DLC_BMBeyond = 56,
        EViewer_DLC_BatmanInc = 57,
        EViewer_DLC_BatmanCorps = 58,
        EViewer_DLC_ASCatwoman = 59,
        EViewer_DLC_CatwomanHalloween = 60,
        EViewer_DLC_ASRobin = 61,
        EViewer_DLC_RedRobin = 62,
        EViewer_DLC_Nightwing = 63,
        EViewer_DLC_ASNightwing = 64,
        EViewer_DLC_GrievingHarley = 65,
        EViewer_DLC_HarleyThugs = 66,
        EViewer_DLC_Char1 = 67,
        EViewer_DLC_Char2 = 68,
        EViewer_DLC_Char3 = 69,
        EViewer_DLC_Char4 = 70,
        EViewer_DLC_Char5 = 71,
        EViewer_DLC_Char6 = 72,
        EViewer_MAX = 73,
    }

    /// <summary>
    /// Enum: EProgressLocations
    /// </summary>
    public enum EProgressLocations : byte
    {
        EPL_Unknown = 0,
        EPL_GCPD = 1,
        EPL_Museum = 2,
        EPL_WonderTower = 3,
        EPL_Processing = 4,
        EPL_SteelWorks = 5,
        EPL_PrisonerEntrance = 6,
        EPL_Hotel = 7,
        EPL_Courthouse = 8,
        EPL_WonderCity = 9,
        EPL_Theatre = 10,
        EPL_IcebergLounge = 11,
        EPL_Warehouse = 12,
        EPL_Sewers = 13,
        EPL_Church = 14,
        EPL_ParkRow = 15,
        EPL_CrimeAlley = 16,
        EPL_ClockTower = 17,
        EPL_BatCave = 18,
        EPL_GothamCity = 19,
        EPL_ZsaszWarehouse = 20,
        EPL_MAX = 21,
    }

    /// <summary>
    /// Enum: ECustomWayPointType
    /// </summary>
    public enum ECustomWayPointType : byte
    {
        CustomWayType_Proximity = 0,
        CustomWayType_MapObj = 1,
        CustomWayType_Riddler = 2,
        CustomWayType_SideStory = 3,
        CustomWayType_MAX = 4,
    }

    /// <summary>
    /// Enum: EProgressCharacter
    /// </summary>
    public enum EProgressCharacter : byte
    {
        ProgressCharacter_Azrael = 0,
        ProgressCharacter_Bane = 1,
        ProgressCharacter_ARTraining = 2,
        ProgressCharacter_DeadShot = 3,
        ProgressCharacter_Hush = 4,
        ProgressCharacter_IceBergCops = 5,
        ProgressCharacter_Mad_Hatter = 6,
        ProgressCharacter_Nora = 7,
        ProgressCharacter_FreezeCluster = 8,
        ProgressCharacter_Riddler = 9,
        ProgressCharacter_Zsasz = 10,
        ProgressCharacter_Bullies = 11,
        ProgressCharacter_MAX = 12,
    }

    /// <summary>
    /// Enum: EConceptArt
    /// </summary>
    public enum EConceptArt : byte
    {
        ConceptArt_None = 0,
        ConceptArt_Renders_Catwoman = 1,
        ConceptArt_Renders_Harley = 2,
        ConceptArt_Renders_Joker = 3,
        ConceptArt_Renders_Penguin = 4,
        ConceptArt_Renders_Riddler = 5,
        ConceptArt_Renders_Batman = 6,
        ConceptArt_Renders_CatAndBat = 7,
        ConceptArt_Robin = 8,
        ConceptArt_Two_Face_Scene = 9,
        ConceptArt_Catwoman_Resque = 10,
        ConceptArt_Tyger_Guard = 11,
        ConceptArt_Penguin_Thugs = 12,
        ConceptArt_Ras_Al_Ghul = 13,
        ConceptArt_Grundy = 14,
        ConceptArt_Joker_Thugs_old = 15,
        ConceptArt_Freeze_Gun = 16,
        ConceptArt_Random_Characters = 17,
        ConceptArt_Calender_Man = 18,
        ConceptArt_Joker_Titan = 19,
        ConceptArt_Hammer_Sickle = 20,
        ConceptArt_Joker_Thugs = 21,
        ConceptArt_Ninjas = 22,
        ConceptArt_Harleyquin_tin_model = 23,
        ConceptArt_Batwing = 24,
        ConceptArt_Jokers_Bed = 25,
        ConceptArt_Helicopter = 26,
        ConceptArt_Jokers_Death = 27,
        ConceptArt_Mad_Hatter_Batman_Rabbit_head = 28,
        ConceptArt_Mad_Hatter_Dreamscape = 29,
        ConceptArt_Tea_Party = 30,
        ConceptArt_Riddler_trophy = 31,
        ConceptArt_Enigma_Puzzle_Box = 32,
        ConceptArt_Entrance = 33,
        ConceptArt_Ace_Chemicals_exterior = 34,
        ConceptArt_Downshot_Streets = 35,
        ConceptArt_Exterior_morgan_movie_theater = 36,
        ConceptArt_Gotham_Rooftop = 37,
        ConceptArt_Gotham_streets = 38,
        ConceptArt_Rooftop = 39,
        ConceptArt_Gotham_cityscape = 40,
        ConceptArt_Streets_B = 41,
        ConceptArt_Steel_works_shipping_dock = 42,
        ConceptArt_Ground_Level = 43,
        ConceptArt_Skyline = 44,
        ConceptArt_Streets_test = 45,
        ConceptArt_Head_Sculpts = 46,
        ConceptArt_Gotham_Monorail_carridge = 47,
        ConceptArt_Gotham_subway_entrance = 48,
        ConceptArt_Station = 49,
        ConceptArt_Train_Battle = 50,
        ConceptArt_Grand_Station = 51,
        ConceptArt_Broken_streets = 52,
        ConceptArt_Chimneys = 53,
        ConceptArt_Steelmill_production_line = 54,
        ConceptArt_Steel_Plant_Hall = 55,
        ConceptArt_Steel_Plant_Main_Hall = 56,
        ConceptArt_Steel_Plant_ToyRoom = 57,
        ConceptArt_Steel_Plant = 58,
        ConceptArt_Steelmill_Hall_of_mirrors = 59,
        ConceptArt_Gotham_Destruction = 60,
        ConceptArt_GCPD_Ext = 61,
        ConceptArt_GCPD = 62,
        ConceptArt_Museum_Exteror = 63,
        ConceptArt_Museum = 64,
        ConceptArt_Window_Cell = 65,
        ConceptArt_Museum_Corridor = 66,
        ConceptArt_Iceberg_Lounge = 67,
        ConceptArt_Main_Hall = 68,
        ConceptArt_Courthouse_Exterior = 69,
        ConceptArt_Courthouse = 70,
        ConceptArt_Church_EXT_Design = 71,
        ConceptArt_Church = 72,
        ConceptArt_Underground_Alley = 73,
        ConceptArt_Wondercity_reveal = 74,
        ConceptArt_Mechanical_Guardian_poster = 75,
        ConceptArt_Wondercity_robot = 76,
        ConceptArt_Lazarus_pit_1 = 77,
        ConceptArt_Desert = 78,
        ConceptArt_H_Strange_tower = 79,
        ConceptArt_Theater = 80,
        ConceptArt_MAX = 81,
    }

    /// <summary>
    /// Enum: EBioCharacter
    /// </summary>
    public enum EBioCharacter : byte
    {
        BioCharacter_Batman = 0,
        BioCharacter_Bruce_Wayne = 1,
        BioCharacter_Alfred = 2,
        BioCharacter_Oracle = 3,
        BioCharacter_Robin = 4,
        BioCharacter_Gordon = 5,
        BioCharacter_Dr_Freeze = 6,
        BioCharacter_Penguin = 7,
        BioCharacter_Hugo_Strange = 8,
        BioCharacter_Harley_Quinn = 9,
        BioCharacter_Joker = 10,
        BioCharacter_Quincy_Sharp = 11,
        BioCharacter_Vicki_Vale = 12,
        BioCharacter_Two_Face = 13,
        BioCharacter_Ras_Ghul = 14,
        BioCharacter_Talia_Ghul = 15,
        BioCharacter_Clayface = 16,
        BioCharacter_Riddler = 17,
        BioCharacter_Solomon_Grundy = 18,
        BioCharacter_Catwoman = 19,
        BioCharacter_Nora = 20,
        BioCharacter_Zsasz = 21,
        BioCharacter_DeadShot = 22,
        BioCharacter_Azrael = 23,
        BioCharacter_Mad_Hatter = 24,
        BioCharacter_Hush = 25,
        BioCharacter_Black_Mask = 26,
        BioCharacter_Jack_Ryder = 27,
        BioCharacter_Poison_Ivy = 28,
        BioCharacter_Killer_Croc = 29,
        BioCharacter_Bane = 30,
        BioCharacter_Calendar_Man = 31,
        BioCharacter_MAX = 32,
    }

    /// <summary>
    /// Enum: ETapeCharacter
    /// </summary>
    public enum ETapeCharacter : byte
    {
        Tape_None = 0,
        Tape_Catwoman = 1,
        Tape_Quincy_Sharp = 2,
        Tape_Dr_Freeze = 3,
        Tape_Joker = 4,
        Tape_Mad_Hatter = 5,
        Tape_Penguin = 6,
        Tape_Riddler = 7,
        Tape_Two_Face = 8,
        Tape_Hugo_Strange = 9,
        Tape_Zsasz = 10,
        Tape_MAX = 11,
    }

    /// <summary>
    /// Enum: ECM_MedalType
    /// </summary>
    public enum ECM_MedalType : byte
    {
        ECM_Medal_None = 0,
        ECM_Medal_Bronze = 1,
        ECM_Medal_Silver = 2,
        ECM_Medal_Gold = 3,
        ECM_Medal_MAX = 4,
    }

    /// <summary>
    /// Enum: PDVersion
    /// </summary>
    public enum PDVersion : byte
    {
        PDVer_Initial = 0,
        PDVer_XPLevel = 1,
        PDVer_PercentageCompleted = 2,
        PDVer_StoryPercentage = 3,
        PDVer_UpgradesBought = 4,
        PDVer_ExtraProfileStrings = 5,
        PDVer_LevelsLoadedNotVisible = 6,
        PDVer_NextLevel = 7,
        PDVer_StoreButtonBashMod = 8,
        PDVer_MovedChallengeDataToOptions = 9,
        PDVer_CharacterViewer = 10,
        PDVer_MapKeyFlags = 11,
        PDVer_RemovedChallengeArrays = 12,
        PDVer_MovedNewArrays = 13,
        PDVer_CombatMovePrompts = 14,
        PDVer_UpgradesNew = 15,
        PDVer_LunaticGroundPrompt = 16,
        PDVer_ComboBatarangPrompt = 17,
        PDVer_LineLaunchPrompt = 18,
        PDVer_MovedExtraStrings = 19,
        PDVer_NewObjectivesList = 20,
        PDVer_PredatorGroundPrompt = 21,
        PDVer_UpgradesIndex = 22,
        PDVer_GrateTutorial = 23,
        PDVer_HangDropTutorial = 24,
        PDVer_TapesCollected = 25,
        PDVer_RemoveRiddlerSecretsTotal = 26,
        PDVer_LastDoorVector = 27,
        PDVer_MoveBiosAgain = 28,
        PDVer_SavedRoom = 29,
        PDVer_SixaxisTutorial = 30,
        PDVer_Mixbin = 31,
        PDVer_DetectiveJamming = 32,
        PDVer_InterrogationArrays = 33,
        PDVer_RadioStations = 34,
        PDVer_StreamingLevels = 35,
        PDVer_PickupCount = 36,
        PDVer_ObjectiveTracking = 37,
        PDVer_AddedPlayableChar = 38,
        PDVer_AddedRadioAudioStates = 39,
        PDVer_AddedCharacterProgress = 40,
        PDVer_RiddlerData = 41,
        PDVer_CustomWaypoint = 42,
        PDVer_GalleryUnlocks = 43,
        PDVer_BackScreen = 44,
        PDVer_DroneTrails = 45,
        PDVer_PoisonedHealthBar = 46,
        PDVer_ProgressNameUnknown = 47,
        PDVer_ProgressPercentage = 48,
        PDVer_ProgressTextIds = 49,
        PDVer_ZsaszPhones = 50,
        PDVer_RiddlerData2 = 51,
        PDVer_PlayOnceRadioStations = 52,
        PDVer_AddedTrailItems = 53,
        PDVer_OWTutorials = 54,
        PDVer_GrappleBoostTutorial = 55,
        PDVer_PickupReveals = 56,
        PDVer_Zsasz_NewRingingPhone = 57,
        PDVer_Tutorial = 58,
        PDVer_WaypointNames = 59,
        PDVer_TrackingCams = 60,
        PDVer_UpgradeVars = 61,
        PDVer_CatwomanJewellery = 62,
        PDVer_PoisonFaceLevel = 63,
        PDVer_Music = 64,
        PDVer_EnygmaData = 65,
        PDVer_DynamicMapIcons1 = 66,
        PDVer_Armour = 67,
        PDVer_StorySynopsisState = 68,
        PDVer_CatwomanEpisodes = 69,
        PDVer_BullyEncounters = 70,
        PDVer_ReplayInfo = 71,
        PDVer_MovedStuff1 = 72,
        PDVer_BruceWayneLegChains = 73,
        PDVer_ZsaszPhones2 = 74,
        PDVer_StealthTutorial = 75,
        PDVer_MusicParams = 76,
        PDVer_Chapter = 77,
        PDVer_JokerBalloons = 78,
        PDVer_ExplainedBatarangRules = 79,
        PDVer_DropOffGrapplePrompt = 80,
        PDVer_SeekFreePackages = 81,
        PDVer_BreakablePenguins = 82,
        PDVer_RiddlerData3 = 83,
        PDVer_RiddlerData4 = 84,
        PDVer_GroundTakedownTutorial = 85,
        PDVer_CityStories = 86,
        PDVer_ChallengeUnlockIndex = 87,
        PDVer_CantThrowFromFreezePlatform = 88,
        PDVer_MovedCityStories = 89,
        PDVer_ARTraining_RaceWins = 90,
        PDVer_CW_UpgradesBought = 91,
        PDVer_BullyEncounters_JackRyder = 92,
        PDVer_EnygmaData1 = 93,
        PDVer_PickupReveals2 = 94,
        PDVer_RiddlerResonator = 95,
        PDVer_KOSmashInstructions = 96,
        PDVer_GlideOffWallPrompt = 97,
        PDVer_MapUserMarkerExtension = 98,
        PDVer_GrappleBoostHints = 99,
        PDVer_WaypointTypeName = 100,
        PDVer_InformantManager = 101,
        PDVer_BrokenHarleyHeadTally = 102,
        PDVer_BatChallengeData = 103,
        PDVer_BrokenCameras = 104,
        PDVer_CheckForRiddlerUnlocks = 105,
        PDVer_GrundyHelpText = 106,
        PDVer_RadioStationOverrides = 107,
        PDVer_BrokenDemonSealTally = 108,
        PDVer_SideObjective = 109,
        PDVer_CWPicks = 110,
        PDVer_CWArmour = 111,
        PDVer_RemoveDroneTrails = 112,
        PDVer_SecuROMCheckData = 113,
        PDVer_GrundyMaggots = 114,
        PDVer_RiddlerRows = 115,
        PDVer_BioIndexChange = 116,
        PDVer_RaftCancel = 117,
        PDVer_TrackNumVanillaGlides = 118,
        PDVer_EliminatedReplayVars = 119,
        PDVer_FakeZsaszPhoneForMap = 120,
        PDVer_DesignTriggeredTutorials = 121,
        PDVer_InterrogationTutorial = 122,
        PDVer_ZsaszFakeMapPhone2 = 123,
        PDVer_MovedStuffForNGPShare = 124,
        PDVer_MovedStuffForNGPShare2 = 125,
        PDVer_StoryDLC = 126,
        PDVer_CustomReached = 127,
        PDVer_ProgressLastStatusUpdated = 128,
        PDVer_CWEpisodeReplay = 129,
        PDVer_MAX = 130,
    }
}
