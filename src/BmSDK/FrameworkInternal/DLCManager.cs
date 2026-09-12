using BmSDK.BmGame;
using BmSDK.Engine;

namespace BmSDK.Framework;

/// <summary>
/// Scans the game's DLC directory and installs every bundle found there.
/// </summary>
internal static class DLCManager
{
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    private delegate void InstallBundleDelegate(
        IntPtr self,
        ref OnlineSubsystem.FOnlineContent dlcBundle
    );

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    private delegate void UpdateObjectListsDelegate(IntPtr self);

    public static unsafe void Run(bool rescan = true)
    {
        var engine = Game.GetEngine();

        var enumerator = engine.DLCEnumerator;
        if (enumerator is null)
        {
            enumerator = new DownloadableContentEnumerator(engine);
            engine.DLCEnumerator = enumerator;
        }

        // Native scan of DLCRootDir ("../../DLC/"), one bundle per subdirectory
        if (rescan)
        {
            enumerator.FindDLC();
        }

        var manager = engine.DLCManager;
        if (manager is null)
        {
            manager = new RDownloadableContentManager(engine);
            engine.DLCManager = manager;
        }

        // Grab native functions from vtable (slightly more portable than regular offsets)
        var vtable = *(IntPtr*)manager.Ptr;
        var installPackages = Marshal.GetDelegateForFunctionPointer<InstallBundleDelegate>(
            *(IntPtr*)(
                vtable + GameDefine.VTableOffsets.DownloadableContentManager__InstallPackages
            )
        );
        var installNonPackageFiles = Marshal.GetDelegateForFunctionPointer<InstallBundleDelegate>(
            *(IntPtr*)(
                vtable + GameDefine.VTableOffsets.DownloadableContentManager__InstallNonPackageFiles
            )
        );
        var updateObjectLists = Marshal.GetDelegateForFunctionPointer<UpdateObjectListsDelegate>(
            *(IntPtr*)(
                vtable + GameDefine.VTableOffsets.DownloadableContentManager__UpdateObjectLists
            )
        );

        var bundles = enumerator.DLCBundles.AsSpan();
        for (var i = 0; i < bundles.Length; i++)
        {
            var name = bundles[i].FriendlyName.ToString() ?? string.Empty;

            Debug.Log($"Installing DLC bundle '{name}'");
            installPackages(manager.Ptr, ref bundles[i]);
            installNonPackageFiles(manager.Ptr, ref bundles[i]);

            manager.InstalledDLC.Push(name);
        }

        // Reloads config on every object the merged .inis touched
        updateObjectLists(manager.Ptr);
    }
}
