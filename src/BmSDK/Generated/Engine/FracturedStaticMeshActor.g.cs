#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: FracturedStaticMeshActor<br/>
/// (size = 580)
/// (flags = 142606994)
/// </summary>
public partial class FracturedStaticMeshActor : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.FracturedStaticMeshActor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as FracturedStaticMeshActor.
    /// </summary>
    public static FracturedStaticMeshActor DefaultObject => (FracturedStaticMeshActor)StaticClass().DefaultObject;

    internal FracturedStaticMeshActor() { }

    /// <summary>
    /// Constructs a new FracturedStaticMeshActor
    /// </summary>
    public FracturedStaticMeshActor(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected FracturedStaticMeshActor(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<FracturedStaticMeshActor>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<FracturedStaticMeshActor>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<FracturedStaticMeshActor>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<FracturedStaticMeshActor>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<FracturedStaticMeshActor>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<FracturedStaticMeshActor>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<FracturedStaticMeshActor>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<FracturedStaticMeshActor>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: SetLoseChunkReplacementMaterial
    /// </summary>
    public unsafe virtual void SetLoseChunkReplacementMaterial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.SetLoseChunkReplacementMaterial", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideFragmentsToMaximizeMemoryUsage
    /// </summary>
    public unsafe virtual void HideFragmentsToMaximizeMemoryUsage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.HideFragmentsToMaximizeMemoryUsage", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideOneFragment
    /// </summary>
    public unsafe virtual void HideOneFragment()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.HideOneFragment", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetVisibility
    /// </summary>
    public unsafe virtual void ResetVisibility()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.ResetVisibility", true);
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
    /// Function: OrigBreakOffPartsInRadius
    /// </summary>
    public unsafe virtual void OrigBreakOffPartsInRadius(System.Numerics.Vector3 Origin, float Radius, float RBStrength, bool bWantPhysChunksAndParticles)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.OrigBreakOffPartsInRadius", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Origin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RBStrength, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWantPhysChunksAndParticles, paramsPtr + 20);
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
    /// Function: RepairAllParts
    /// </summary>
    public unsafe virtual void RepairAllParts()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.RepairAllParts", true);
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
    /// Function: BreakOffAllParts
    /// </summary>
    public unsafe virtual void BreakOffAllParts(System.Numerics.Vector3 ExplodeVelocity, bool bIncludeSupportChunks, bool bWantPhysChunksAndParticles, BmSDK.Engine.Actor BreakInstigator, int ChunkSize = default, bool bAllowDamagedEventFiring = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.BreakOffAllParts", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExplodeVelocity, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludeSupportChunks, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWantPhysChunksAndParticles, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BreakInstigator, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChunkSize, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowDamagedEventFiring, paramsPtr + 28);
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
    /// Function: BreakOffPartsInRadiusConstantVel
    /// </summary>
    public unsafe virtual void BreakOffPartsInRadiusConstantVel(System.Numerics.Vector3 Origin, float Radius, System.Numerics.Vector3 LinearVel, System.Numerics.Vector3 AngularVel, bool bWantPhysChunksAndParticles, BmSDK.Engine.Actor BreakInstigator, bool bAllowDamagedEventFiring = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.BreakOffPartsInRadiusConstantVel", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Origin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinearVel, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngularVel, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWantPhysChunksAndParticles, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BreakInstigator, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowDamagedEventFiring, paramsPtr + 48);
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
    /// Function: BreakOffPartsInRadius
    /// </summary>
    public unsafe virtual void BreakOffPartsInRadius(System.Numerics.Vector3 Origin, float Radius, float RBStrength, bool bWantPhysChunksAndParticles, BmSDK.Engine.Actor BreakInstigator, bool bAllowDamagedEventFiring = default, System.Numerics.Vector3 BlastOriginOffset = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.BreakOffPartsInRadius", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Origin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RBStrength, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWantPhysChunksAndParticles, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BreakInstigator, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowDamagedEventFiring, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlastOriginOffset, paramsPtr + 32);
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
    /// Function: BreakOffParts
    /// </summary>
    public unsafe virtual void BreakOffParts(BmSDK.TArray<int> PartIndices, bool bWantPhysChunksAndParticles, System.Numerics.Vector3 PartVel, System.Numerics.Vector3 PartAngVel, BmSDK.Engine.Actor BreakInstigator, int NumPartsSpawnedThisFrame = default, bool bAllowDamagedEventFiring = default, bool bSupressStateSaving = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.BreakOffParts", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartIndices, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWantPhysChunksAndParticles, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartVel, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartAngVel, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BreakInstigator, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumPartsSpawnedThisFrame, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowDamagedEventFiring, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSupressStateSaving, paramsPtr + 52);
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
    /// Function: BreakOffPart
    /// </summary>
    public unsafe virtual void BreakOffPart(int PartIndex, bool bWantPhysChunksAndParticles, System.Numerics.Vector3 PartVel, System.Numerics.Vector3 PartAngVel, BmSDK.Engine.Actor BreakInstigator, int NumPartsSpawnedThisFrame = default, bool bAllowDamagedEventFiring = default, bool bSupressStateSaving = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.BreakOffPart", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWantPhysChunksAndParticles, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartVel, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartAngVel, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BreakInstigator, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumPartsSpawnedThisFrame, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowDamagedEventFiring, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSupressStateSaving, paramsPtr + 44);
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
    /// Function: LocalBreakOffParts
    /// </summary>
    public unsafe virtual void LocalBreakOffParts(BmSDK.Engine.FracturedStaticMeshActor.FBreakOffPartsData BreakData, BmSDK.Engine.Actor BreakInstigator)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.LocalBreakOffParts", true);
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BreakData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BreakInstigator, paramsPtr + 84);
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
    /// Function: FindPartsInDirection
    /// </summary>
    public unsafe virtual void FindPartsInDirection(System.Numerics.Vector3 Direction, int NumParts, bool bOnlyDestroyableParts, ref BmSDK.TArray<int> OutPartIndices)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.FindPartsInDirection", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumParts, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyDestroyableParts, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutPartIndices, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutPartIndices = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 20);
        return;
    }

    /// <summary>
    /// Function: Explode
    /// </summary>
    public unsafe virtual void Explode(BmSDK.Engine.Actor BreakInstigator)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.Explode", true);
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BreakInstigator, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe override void TakeDamage(int Damage, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.TakeDamage", true);
        byte* paramsPtr = stackalloc byte[248];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveDecals
    /// </summary>
    public unsafe virtual void RemoveDecals(int IndexToRemoveDecalsFrom)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.RemoveDecals", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IndexToRemoveDecalsFrom, paramsPtr + 0);
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
    /// Function: FractureEffectIsRelevant
    /// </summary>
    public unsafe virtual bool FractureEffectIsRelevant(bool bForceDedicated, BmSDK.Engine.Pawn EffectInstigator, ref byte bWantPhysChunksAndParticles)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.FractureEffectIsRelevant", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDedicated, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EffectInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWantPhysChunksAndParticles, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        bWantPhysChunksAndParticles = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: OnDamaged
    /// </summary>
    public unsafe virtual void OnDamaged()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.OnDamaged", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsFracturedByDamageType
    /// </summary>
    public unsafe virtual bool IsFracturedByDamageType(BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.IsFracturedByDamageType", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SpawnDeferredParts
    /// </summary>
    public unsafe virtual bool SpawnDeferredParts()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.SpawnDeferredParts", true);
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
    /// Function: BreakOffIsolatedIslandsFromComponent
    /// </summary>
    public unsafe virtual void BreakOffIsolatedIslandsFromComponent(BmSDK.Engine.FracturedStaticMeshComponent Component, ref BmSDK.TArray<byte> FragmentVis, BmSDK.TArray<int> IgnoreFrags, System.Numerics.Vector3 ChunkDir, BmSDK.TArray<BmSDK.Engine.FracturedStaticMeshPart> DisableCollWithPart, bool bWantPhysChunks, bool bAllowDamagedEventFiring = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.BreakOffIsolatedIslandsFromComponent", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Component, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FragmentVis, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreFrags, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChunkDir, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisableCollWithPart, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWantPhysChunks, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowDamagedEventFiring, paramsPtr + 56);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FragmentVis = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: BreakOffIsolatedIslands
    /// </summary>
    public unsafe virtual void BreakOffIsolatedIslands(ref BmSDK.TArray<byte> FragmentVis, BmSDK.TArray<int> IgnoreFrags, System.Numerics.Vector3 ChunkDir, BmSDK.TArray<BmSDK.Engine.FracturedStaticMeshPart> DisableCollWithPart, bool bWantPhysChunks, bool bAllowDamagedEventFiring = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.BreakOffIsolatedIslands", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FragmentVis, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreFrags, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChunkDir, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisableCollWithPart, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWantPhysChunks, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowDamagedEventFiring, paramsPtr + 52);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FragmentVis = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: ResetHealth
    /// </summary>
    public unsafe virtual void ResetHealth()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.ResetHealth", true);
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
    /// Function: FindMeshFractureSounds
    /// </summary>
    public unsafe virtual void FindMeshFractureSounds(ref BmSDK.Engine.AkEvent ExpFracSound, ref BmSDK.Engine.AkEvent ChkFractureSound, ref int NumChunksForExp)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.FindMeshFractureSounds", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExpFracSound, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChkFractureSound, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumChunksForExp, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ExpFracSound = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
        ChkFractureSound = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 4);
        NumChunksForExp = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnPartMulti
    /// </summary>
    public unsafe virtual BmSDK.Engine.FracturedStaticMeshPart SpawnPartMulti(BmSDK.TArray<int> ChunkIndices, System.Numerics.Vector3 InitialVel, System.Numerics.Vector3 InitialAngVel, float RelativeScale, bool bExplosion)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.SpawnPartMulti", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChunkIndices, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialVel, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialAngVel, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelativeScale, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bExplosion, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FracturedStaticMeshPart>(paramsPtr + 44);
    }

    /// <summary>
    /// Function: SpawnPart
    /// </summary>
    public unsafe virtual BmSDK.Engine.FracturedStaticMeshPart SpawnPart(int ChunkIndex, System.Numerics.Vector3 InitialVel, System.Numerics.Vector3 InitialAngVel, float RelativeScale, bool bExplosion)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.FracturedStaticMeshActor.SpawnPart", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChunkIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialVel, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialAngVel, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelativeScale, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bExplosion, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FracturedStaticMeshPart>(paramsPtr + 36);
    }

    /// <summary>
    /// Struct: FBreakOffPartsData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 84)]
    public partial record struct FBreakOffPartsData
    {
        /// <summary>
        /// BoolProperty: bWantPhysChunksAndParticles
        /// </summary>
        public unsafe bool bWantPhysChunksAndParticles
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bAllowDamagedEventFiring
        /// </summary>
        public unsafe bool bAllowDamagedEventFiring
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: ExplosionType
        /// </summary>
        public unsafe BmSDK.Engine.FracturedStaticMeshActor.EFractureMeshExplosionType ExplosionType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FracturedStaticMeshActor.EFractureMeshExplosionType>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: ExplodePosition
        /// </summary>
        public unsafe System.Numerics.Vector3 ExplodePosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: ExplodeRadius
        /// </summary>
        public unsafe float ExplodeRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: PartIndex
        /// </summary>
        public unsafe int PartIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ByteProperty: BlastType
        /// </summary>
        public unsafe BmSDK.Engine.FracturedStaticMeshActor.EFractureMeshExplosionBlastType BlastType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FracturedStaticMeshActor.EFractureMeshExplosionBlastType>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: BlastOriginOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 BlastOriginOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: BlastOriginRadiusOverride
        /// </summary>
        public unsafe float BlastOriginRadiusOverride
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: ExplodeForce
        /// </summary>
        public unsafe float ExplodeForce
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StructProperty: ExplodeVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 ExplodeVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// StructProperty: ExplodeAngularVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 ExplodeAngularVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: bUseCoreBlastPositionIfPossible
        /// </summary>
        public unsafe bool bUseCoreBlastPositionIfPossible
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: bIncludeSupportChunks
        /// </summary>
        public unsafe bool bIncludeSupportChunks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: bSupressStateSaving
        /// </summary>
        public unsafe bool bSupressStateSaving
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// IntProperty: NumPartsPerChunk
        /// </summary>
        public unsafe int NumPartsPerChunk
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }
    }

    /// <summary>
    /// Enum: EFractureMeshExplosionBlastType
    /// </summary>
    public enum EFractureMeshExplosionBlastType : byte
    {
        FMEBT_Constant = 0,
        FMEBT_Radial = 1,
        FMEBT_Explode = 2,
        FMEBT_MAX = 3,
    }

    /// <summary>
    /// Enum: EFractureMeshExplosionType
    /// </summary>
    public enum EFractureMeshExplosionType : byte
    {
        FMET_SinglePart = 0,
        FMET_PartsInRadius = 1,
        FMET_AllParts = 2,
        FMET_MAX = 3,
    }

    /// <summary>
    /// Struct: FDeferredPartToSpawn
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FDeferredPartToSpawn
    {
        /// <summary>
        /// ArrayProperty: ChunkIndex
        /// </summary>
        public unsafe BmSDK.TArray<int> ChunkIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: InitialVel
        /// </summary>
        public unsafe System.Numerics.Vector3 InitialVel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: InitialAngVel
        /// </summary>
        public unsafe System.Numerics.Vector3 InitialAngVel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: RelativeScale
        /// </summary>
        public unsafe float RelativeScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: bExplosion
        /// </summary>
        public unsafe bool bExplosion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// IntProperty: MaxPartsToSpawnAtOnce
    /// </summary>
    public unsafe int MaxPartsToSpawnAtOnce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bShouldTakeDamageWhenPunched
    /// </summary>
    public unsafe bool bShouldTakeDamageWhenPunched
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 432); }
    }

    /// <summary>
    /// BoolProperty: UseLightingChannelFix
    /// </summary>
    public unsafe bool UseLightingChannelFix
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 432); }
    }

    /// <summary>
    /// BoolProperty: bHasShownMissingSoundWarning
    /// </summary>
    public unsafe bool bHasShownMissingSoundWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 432); }
    }

    /// <summary>
    /// BoolProperty: bBreakChunksOnActorTouch
    /// </summary>
    public unsafe bool bBreakChunksOnActorTouch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 432); }
    }

    /// <summary>
    /// BoolProperty: bAllowDisableTick
    /// </summary>
    public unsafe bool bAllowDisableTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 432); }
    }

    /// <summary>
    /// BoolProperty: bSpawnExplosionChunks
    /// </summary>
    public unsafe bool bSpawnExplosionChunks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 432); }
    }

    /// <summary>
    /// BoolProperty: bAllowFracturedPartCollisions
    /// </summary>
    public unsafe bool bAllowFracturedPartCollisions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 432); }
    }

    /// <summary>
    /// BoolProperty: bIsForceFullDestroyOnDamage
    /// </summary>
    public unsafe bool bIsForceFullDestroyOnDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 432); }
    }

    /// <summary>
    /// BoolProperty: IsForceFullDestroyOnDamageIncludesRootFragments
    /// </summary>
    public unsafe bool IsForceFullDestroyOnDamageIncludesRootFragments
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 432); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreBulletFracture
    /// </summary>
    public unsafe bool bIgnoreBulletFracture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 432); }
    }

    /// <summary>
    /// ComponentProperty: FracturedStaticMeshComponent
    /// </summary>
    public unsafe BmSDK.Engine.FracturedStaticMeshComponent FracturedStaticMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FracturedStaticMeshComponent>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// ComponentProperty: SkinnedComponent
    /// </summary>
    public unsafe BmSDK.Engine.FracturedSkinnedMeshComponent SkinnedComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FracturedSkinnedMeshComponent>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// ArrayProperty: ChunkHealth
    /// </summary>
    public unsafe BmSDK.TArray<int> ChunkHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ArrayProperty: FracturedByDamageType
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> FracturedByDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// FloatProperty: ChunkHealthScale
    /// </summary>
    public unsafe float ChunkHealthScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ArrayProperty: OverrideFragmentDestroyEffects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ParticleSystem> OverrideFragmentDestroyEffects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ParticleSystem>>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// FloatProperty: FractureCullMinDistance
    /// </summary>
    public unsafe float FractureCullMinDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// FloatProperty: FractureCullMaxDistance
    /// </summary>
    public unsafe float FractureCullMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// ByteProperty: FracturePartRBChannel
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel FracturePartRBChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// StructProperty: FracturePartRBPartCollideWithChannels
    /// </summary>
    public unsafe ref BmSDK.Engine.PrimitiveComponent.FRBCollisionChannelContainer FracturePartRBPartCollideWithChannels
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.PrimitiveComponent.FRBCollisionChannelContainer>(Ptr + 496);

    /// <summary>
    /// ArrayProperty: DeferredPartsToSpawn
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.FracturedStaticMeshActor.FDeferredPartToSpawn> DeferredPartsToSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.FracturedStaticMeshActor.FDeferredPartToSpawn>>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// StructProperty: InvestigateOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 InvestigateOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 512);

    /// <summary>
    /// StructProperty: PartImpactEffect
    /// </summary>
    public unsafe ref BmSDK.Engine.Actor.FPhysEffectInfo PartImpactEffect
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.Actor.FPhysEffectInfo>(Ptr + 524);

    /// <summary>
    /// ObjectProperty: ExplosionFractureSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ExplosionFractureSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// ObjectProperty: SingleChunkFractureSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SingleChunkFractureSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// IntProperty: NumChunksForExplosionSound
    /// </summary>
    public unsafe int NumChunksForExplosionSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// ObjectProperty: ExplosionFractureEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ExplosionFractureEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// ComponentProperty: FracturePartLightEnv
    /// </summary>
    public unsafe BmSDK.Engine.DynamicLightEnvironmentComponent FracturePartLightEnv
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DynamicLightEnvironmentComponent>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// StructProperty: FracturePartLightingChannels
    /// </summary>
    public unsafe ref BmSDK.Engine.LightComponent.FLightingChannelContainer FracturePartLightingChannels
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.LightComponent.FLightingChannelContainer>(Ptr + 568);

    /// <summary>
    /// ObjectProperty: MI_LoseChunkPreviousMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface MI_LoseChunkPreviousMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// ObjectProperty: LastBreakInstigator
    /// </summary>
    public unsafe BmSDK.Engine.Actor LastBreakInstigator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }
}
