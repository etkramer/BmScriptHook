namespace BmSDK.Framework;

public sealed class GameDefineSteam : GameDefine
{
    public const uint TimeDateStamp = 0x520000F7;

    public override string Name => "Steam";

    // Globals
    public override IntPtr GNames => 0x12019C8;
    public override IntPtr GObjObjects => 0x1243CE0;
    public override IntPtr GError => 0x1191328;

    // app (global)
    public override IntPtr AppRealloc => 0x1FBE0;
    public override IntPtr AppFree => 0x1FC00;
    public override IntPtr EngineTick => 0x7E6A70;

    // UObject (static)
    public override IntPtr StaticFindObject => 0x8F3A0;
    public override IntPtr StaticConstructObject => 0x99700;
    public override IntPtr LoadPackage => 0xA06D0;
    public override IntPtr CollectGarbage => 0xAF980;

    // UObject (local)
    public override IntPtr ProcessEvent => 0x47800;
    public override IntPtr ProcessInternal => 0x47640;
    public override IntPtr CallFunction => 0x505B0;
    public override IntPtr AddObject => 0x8E720;
    public override IntPtr ConditionalDestroy => 0x8CD40;
    public override IntPtr FindFunction => 0x8B0C0;
    public override IntPtr ConditionalPostLoad => 0x9AB50;

    // UClass (local)
    public override IntPtr GetDefaultObject => 0x4D5F0;

    // UWorld (local)
    public override IntPtr SpawnActor => 0x321420;

    // FWindowsViewport (local)
    public override IntPtr ProcessDeferredMessage => 0x7B21B0;

    // FName (local)
    public override IntPtr NameInit => 0x7F1E0;

    // FString (local)
    public override IntPtr StringCtor => 0x4640;
}
