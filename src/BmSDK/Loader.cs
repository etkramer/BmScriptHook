global using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using BmSDK.Framework.Redirection;
using MoreLinq;

[assembly: SuppressMessage("Usage", "IDE1006:Naming rule violation")]
[assembly: SuppressMessage("Usage", "IDE0130:Namespace does not match folder structure")]

namespace BmSDK.Framework;

internal static class Loader
{
    private const string InitFuncName = "Engine.GameInfo:InitGame";
    private const string EnterMenuFuncName = "GFxUI.GFxMoviePlayer:Init";
    private const string EnterGameFuncName = "BmGame.RPlayerController:ClientReady";
    private const string TickFuncName = "BmGame.RGameInfo:Tick";

    private static GameFunctions.EngineTickDelegate? _EngineTickDetourBase = null;
    private static GameFunctions.ProcessInternalDelegate? _ProcessInternalDetourBase = null;
    private static GameFunctions.ProcessDeferredMessageDelegate? _ProcessDeferredMessageDetourBase = null;
    private static GameFunctions.AddObjectDelegate? _AddObjectDelegateDetourBase = null;
    private static GameFunctions.ConditionalPostLoadDelegate? _ConditionalPostLoadDetourBase = null;
    private static GameFunctions.ConditionalDestroyDelegate? _ConditionalDestroyDetourBase = null;

    /// <summary>
    /// Main .NET entry point, called from BmSDK.Host.
    /// This is done when FEngineLoop::PreInit() is executed.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void GuardedDllMain() => Debug.RunWithSender("Loader", DllMain);

    private static void DllMain()
    {
        try
        {
            DllMainImpl();
        }
        catch (Exception ex)
        {
            Abort(ex);
        }
    }

    private static void DllMainImpl()
    {
        EngineSynchronizationContext.InitOnThread();

        // Environment.CurrentDirectory gets unreliable once we start
        // running code in detours, so let's store it early.
        FileUtils.Init();

        // Perform static init (before engine load)
        StaticInit.StaticInitClasses();

        // Find/load scripts
        ScriptManager.Init();

        // Register BmSDK's internal redirectors.
        RedirectManager.Global.RegisterRedirectors(typeof(Loader).Assembly);

        // Create function detours
        _EngineTickDetourBase = DetourUtil.NewDetour<GameFunctions.EngineTickDelegate>(
            GameInfo.FuncOffsets.EngineTick,
            EngineTickDetour
        );

        _ProcessInternalDetourBase = DetourUtil.NewDetour<GameFunctions.ProcessInternalDelegate>(
            GameInfo.FuncOffsets.ProcessInternal,
            ProcessInternalDetour
        );

        _ProcessDeferredMessageDetourBase =
            DetourUtil.NewDetour<GameFunctions.ProcessDeferredMessageDelegate>(
                GameInfo.FuncOffsets.ProcessDeferredMessage,
                ProcessDeferredMessageDetour
            );

        _AddObjectDelegateDetourBase = DetourUtil.NewDetour<GameFunctions.AddObjectDelegate>(
            GameInfo.FuncOffsets.AddObject,
            AddObjectDetour
        );

        _ConditionalPostLoadDetourBase =
            DetourUtil.NewDetour<GameFunctions.ConditionalPostLoadDelegate>(
                GameInfo.FuncOffsets.ConditionalPostLoad,
                ConditionalPostLoadDetour
            );

        _ConditionalDestroyDetourBase =
            DetourUtil.NewDetour<GameFunctions.ConditionalDestroyDelegate>(
                GameInfo.FuncOffsets.ConditionalDestroy,
                ConditionalDestroyDetour
            );
    }

    private static IntPtr EngineTickDetour(IntPtr self)
    {
        // Run the scheduled callbacks
        EngineSynchronizationContext.Instance.ExecutePending();
        return _EngineTickDetourBase!.Invoke(self);
    }

    private static bool s_hasGameStarted = false;
    private static bool s_hasGameInited = false;

    // Detour for UObject::ProcessInternal()
    private static unsafe void ProcessInternalDetour(IntPtr self, IntPtr Stack, IntPtr Result)
    {
        try
        {
            IntPtr selfPtr = self;
            FFrame* stackPtr = (FFrame*)Stack.ToPointer();
            var selfObj = MarshalUtil.ToManaged<GameObject>(&selfPtr);
            var funcObj = MarshalUtil.ToManaged<Function>(&stackPtr->Node);
            var funcName = funcObj.GetPathName();

            // Notify scripts of game init
            if (!s_hasGameInited && funcName == InitFuncName)
            {
                // Preload packages and root keep-alive objects before any world loads
                PreloadManager.Run();

                foreach (var script in ScriptManager.Scripts)
                {
                    Debug.RunWithSender(script.Name, script.Main);
                }

                s_hasGameInited = true;
            }

            // Notify scripts of game start
            if (!s_hasGameStarted && funcName == EnterMenuFuncName)
            {
                foreach (var script in ScriptManager.Scripts)
                {
                    Debug.RunWithSender(script.Name, script.OnEnterMenu);
                }

                s_hasGameStarted = true;
            }

            // Notify scripts of game begin play
            if (funcName == EnterGameFuncName)
            {
                foreach (var script in ScriptManager.Scripts)
                {
                    Debug.RunWithSender(script.Name, script.OnEnterGame);
                }
            }

            // Notify scripts of game tick
            if (funcName == TickFuncName)
            {
                // Tick framework stuff
                InputManager.Tick();

                // Call OnTick() for scripts
                foreach (var script in ScriptManager.Scripts)
                {
                    Debug.RunWithSender(script.Name, script.OnTick);
                }

                // Call OnTick() for script components
                if (GameObject.AllScriptComponents.Count > 0)
                {
                    foreach (var scriptComponent in GameObject.AllScriptComponents.ToArray())
                    {
                        Debug.RunWithSender(scriptComponent.GetType().Name, scriptComponent.OnTick);
                    }
                }
            }

            // Run redirect and skip base implementation if applicable to this function
            if (RedirectManager.ExecuteRedirector(selfObj, funcObj, funcName, stackPtr, Result))
            {
                return;
            }

            // Call base impl. Redirected implementations are expected to reach this by calling "themselves" a second time.
            _ProcessInternalDetourBase!.Invoke(self, Stack, Result);
        }
        catch (Exception ex)
        {
            Abort(ex);
        }
    }

    // Detour for FWindowsViewport::ProcessDeferredMessage()
    private static void ProcessDeferredMessageDetour(IntPtr self, ref FDeferredMessage message)
    {
        var key = (Keys)(uint)message.WParam;

        switch (message.Message)
        {
            // WM_KEYDOWN
            case 0x100:
            // WM_SYSKEYDOWN
            case 0x104:
                InputManager.OnKeyDown(key);
                break;
            // WM_KEYUP
            case 0x101:
            // WM_SYSKEYUP
            case 0x105:
                InputManager.OnKeyUp(key);
                break;
        }

        // Call base impl
        _ProcessDeferredMessageDetourBase!.Invoke(self, ref message);
    }

    // Detour for UObject::AddObject()
    private static void AddObjectDetour(IntPtr self, int InIndex)
    {
        // Call base impl to instantiate UObject
        _AddObjectDelegateDetourBase!.Invoke(self, InIndex);

        try
        {
            var obj = MarshalUtil.GetOrCreateWrapper(self);

            // Auto-attach script components to non-serialized objs
            if (!obj.IsClassDefaultObject && ScriptComponentManager.HasAutoAttachTypes())
            {
                ScriptComponentManager.TryAutoAttachComponents(obj, objNotLoaded: true);
            }
        }
        catch (Exception ex)
        {
            Abort(ex);
        }
    }

    // Detour for UObject::ConditionalPostLoad()
    private static void ConditionalPostLoadDetour(IntPtr self)
    {
        // Call base impl to set default func flags first
        _ConditionalPostLoadDetourBase!.Invoke(self);

        // Configure redirected functions
        try
        {
            var obj = MarshalUtil.GetOrCreateWrapper(self);
            if (obj is Function func)
            {
                RedirectManager.TryConfigureFunction(func);
            }

            // Auto-attach script components to serialized objs
            if (!obj.IsClassDefaultObject && ScriptComponentManager.HasAutoAttachTypes())
            {
                ScriptComponentManager.TryAutoAttachComponents(obj, objNotLoaded: true);
            }
        }
        catch (Exception ex)
        {
            Abort(ex);
        }
    }

    // Detour for UObject::ConditionalDestroy()
    private static void ConditionalDestroyDetour(IntPtr self)
    {
        // Destroy this object's managed instance
        try
        {
            MarshalUtil.DestroyManagedWrapper(self);
        }
        catch (Exception ex)
        {
            Abort(ex);
        }

        // Call base impl
        _ConditionalDestroyDetourBase!.Invoke(self);
    }

    [DoesNotReturn]
    private static void Abort(Exception ex)
    {
        // Just abort, because otherwise UE3 will crash anyway but print
        // its more-or-less useless DBGHELP messages.
        Debug.LogError(ex.ToString());
        Environment.Exit(1);
    }
}
