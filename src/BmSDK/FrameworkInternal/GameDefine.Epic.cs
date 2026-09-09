namespace BmSDK.Framework;

internal sealed class GameDefineEpic : GameDefine
{
    public const uint TimeDateStamp = 0x5D9F84DF;

    public override string Name => "Epic";

    // Globals
    public override IntPtr GNames => 0x11EC5E8;
    public override IntPtr GObjObjects => 0x122E900;
    public override IntPtr GError => 0x117BF48;

    // app (global)
    public override IntPtr AppRealloc => 0x1EC10;
    public override IntPtr AppFree => 0x1EC30;
    public override IntPtr EngineTick => 0x7D8980;

    // UObject (static)
    public override IntPtr StaticFindObject => 0x8ED20;
    public override IntPtr StaticConstructObject => 0x98BE0;
    public override IntPtr LoadPackage => 0x9FCA0;
    public override IntPtr CollectGarbage => 0xAF0C0;

    // UObject (local)
    public override IntPtr ProcessEvent => 0x46A60;
    public override IntPtr ProcessInternal => 0x468A0;
    public override IntPtr CallFunction => 0x4F8A0;
    public override IntPtr AddObject => 0x8E0A0;
    public override IntPtr ConditionalDestroy => 0x8C6C0;
    public override IntPtr FindFunction => 0x8A980;
    public override IntPtr ConditionalPostLoad => 0x9A110;

    // UClass (local)
    public override IntPtr GetDefaultObject => 0x4C8E0;

    // UWorld (local)
    public override IntPtr SpawnActor => 0x321A20;

    // FWindowsViewport (local)
    public override IntPtr ProcessDeferredMessage => 0x7A41F0;

    // FName (local)
    public override IntPtr NameInit => 0x7E990;

    // FString (local)
    public override IntPtr StringCtor => 0x4650;
}
