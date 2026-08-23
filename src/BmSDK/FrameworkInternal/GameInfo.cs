namespace BmSDK.Framework;

internal static class GameInfo
{
    public static class GlobalOffsets
    {
        public const IntPtr GNames = 0x11EC5E8;
        public const IntPtr GObjObjects = 0x122E900;
        public const IntPtr GError = 0x117BF48;
    }

    public static class FuncOffsets
    {
        // app (global)
        public const IntPtr AppRealloc = 0x1EC10;
        public const IntPtr AppFree = 0x1EC30;
        public const IntPtr EngineTick = 0x7D8980;

        // UObject (static)
        public const IntPtr StaticFindObject = 0x8ED20;
        public const IntPtr StaticConstructObject = 0x98BE0;
        public const IntPtr LoadPackage = 0x9FCA0;
        public const IntPtr CollectGarbage = 0xAF0C0;

        // UObject (local)
        public const IntPtr ProcessEvent = 0x46A60;
        public const IntPtr ProcessInternal = 0x468A0;
        public const IntPtr CallFunction = 0x4F8A0;
        public const IntPtr AddObject = 0x8E0A0;
        public const IntPtr ConditionalDestroy = 0x8C6C0;
        public const IntPtr FindFunction = 0x8A980;
        public const IntPtr ConditionalPostLoad = 0x9A110;

        // UClass (local)
        public const IntPtr GetDefaultObject = 0x4C8E0;

        // UWorld (local)
        public const IntPtr SpawnActor = 0x321A20;

        // FWindowsViewport (local)
        public const IntPtr ProcessDeferredMessage = 0x7A41F0;

        // FName (local)
        public const IntPtr NameInit = 0x7E990;

        // FString (local)
        public const IntPtr StringCtor = 0x4650;
    }

    public static class MemberOffsets
    {
        public const IntPtr Object__ObjectInternalInteger = 4;
        public const IntPtr Object__Outer = 24;
        public const IntPtr Object__Name = 28;
        public const IntPtr Object__Class = 36;
        public const IntPtr Struct__SuperStruct = 56;
        public const IntPtr Class__ClassFlags = 180;
    }
}
