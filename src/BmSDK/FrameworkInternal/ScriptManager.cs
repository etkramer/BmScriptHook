using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;
using System.Text;
using BmSDK.Framework.Redirection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Text;
using ReferenceAssemblies = Basic.Reference.Assemblies;

namespace BmSDK.Framework;

/// <summary>
/// Provides the plugin loading system--compilation and instantiation of user scripts,
/// organized as individual mods with per-mod hot reload.
/// </summary>
internal static class ScriptManager
{
    public const LanguageVersion LangVer = LanguageVersion.CSharp14;
    public static readonly CSharpParseOptions ParseOptions = CSharpParseOptions
        .Default.WithLanguageVersion(LangVer)
        .WithPreprocessorSymbols("BATMAN2");
    public static readonly ImmutableArray<PortableExecutableReference> DotNetAssemblies =
        ReferenceAssemblies.Net100.References.All;
    public static readonly ImmutableList<MetadataReference> MetadataReferences =
    [
        .. DotNetAssemblies,
        // MoreLINQ.dll
        MetadataReference.CreateFromFile(typeof(MoreLinq.MoreEnumerable).Assembly.Location),
        // BmSDK.dll
        MetadataReference.CreateFromFile(typeof(GameObject).Assembly.Location),
        // Tomlyn.dll
        MetadataReference.CreateFromFile(typeof(Tomlyn.TomlSerializer).Assembly.Location),
    ];
    public const string GlobalUsings = """
        global using global::System;
        global using global::System.Collections.Generic;
        global using global::System.IO;
        global using global::System.Linq;
        global using global::System.Net.Http;
        global using global::System.Threading;
        global using global::System.Threading.Tasks;

        global using global::BmSDK.Framework;
        global using global::Tomlyn.Model;
        """;
    public const string GlobalUsingsPath = "Scripts.GlobalUsings.g.cs";
    public static readonly SyntaxTree GlobalUsingsTree = CSharpSyntaxTree.ParseText(
        SourceText.From(GlobalUsings, Encoding.UTF8),
        ParseOptions,
        GlobalUsingsPath
    );
    public static readonly CSharpCompilationOptions CompilerOptions = new(
        OutputKind.DynamicallyLinkedLibrary,
        platform: Platform.X86,
        allowUnsafe: true
    );

    private record LoadedMod(Mod Mod, AssemblyLoadContext Alc, List<Script> Scripts);

    private sealed class ScriptLoadContext(string name)
        : AssemblyLoadContext(name, isCollectible: true)
    {
        private static readonly AssemblyLoadContext s_hostAlc = GetLoadContext(
            typeof(GameObject).Assembly
        )!;

        protected override Assembly? Load(AssemblyName assemblyName)
        {
            return s_hostAlc.Assemblies.FirstOrDefault(asm =>
                asm.GetName().Name == assemblyName.Name
            );
        }
    }

    private static readonly Dictionary<string, LoadedMod> s_loadedMods = [];
    private static readonly Dictionary<string, Timer> s_debounceTimers = [];
    private static readonly Lock s_lockObj = new();

    private const int DebounceMillis = 500;

    public static IEnumerable<Script> Scripts => s_loadedMods.Values.SelectMany(m => m.Scripts);

    public static IEnumerable<Mod> Mods => s_loadedMods.Values.Select(m => m.Mod);

    private static bool s_isInitialized = false;

    /// <summary>
    /// Initializes the script system and begins monitoring for script changes.
    /// </summary>
    public static void Init()
    {
        if (s_isInitialized)
        {
            return;
        }

        PrepareCompilation();
        LoadAllMods();
        WatchForChanges();
        s_isInitialized = true;
    }

    private static void PrepareCompilation()
    {
        AppDomain.CurrentDomain.AssemblyResolve += (sender, e) =>
            AppDomain
                .CurrentDomain.GetAssemblies()
                .ToList()
                .FirstOrDefault(asm => asm.GetName().ToString() == e.Name);
    }

    private static void LoadAllMods()
    {
        var modsDir = FileUtils.GetModsPath();
        var scriptsDir = FileUtils.GetScriptsPath();

        // Load implicit "Scripts" mod from BmGame/Scripts/
        if (Directory.Exists(scriptsDir))
        {
            try
            {
                var defaultMod = Mod.CreateDefault(scriptsDir);
                LoadMod(defaultMod, scriptsDir);
            }
            catch (Exception e)
            {
                Debug.LogError($"Failed to load loose scripts: {e.Message}");
            }
        }

        // Load explicit mods from BmGame/Mods/*/
        if (Directory.Exists(modsDir))
        {
            foreach (var modDir in Directory.EnumerateDirectories(modsDir))
            {
                var tomlPath = Path.Combine(modDir, "mod.toml");
                if (!File.Exists(tomlPath))
                {
                    continue;
                }

                try
                {
                    var mod = Mod.FromDirectory(modDir);
                    var modScriptsDir = Path.Combine(modDir, "scripts");
                    LoadMod(mod, modScriptsDir);
                }
                catch (Exception e)
                {
                    Debug.LogError(
                        $"Failed to load mod at {Path.GetFileName(modDir)}: {e.Message}"
                    );
                }
            }
        }
    }

    /// <summary>
    /// Compiles and loads a single mod.
    /// </summary>
    private static bool LoadMod(Mod mod, string scriptsDir)
    {
        var (peStream, pdbStream) = CompileMod(mod, scriptsDir);
        if (peStream == null)
        {
            return false;
        }

        var targetName = $"{mod.Name}.dll";
        var modAlc = new ScriptLoadContext(targetName);
        var asm = modAlc.LoadFromStream(peStream, pdbStream);

        EngineSynchronizationContext.Instance.Post(
            _ =>
            {
                // If reloading, unload old version first
                if (s_loadedMods.TryGetValue(mod.DirectoryPath, out var oldMod))
                {
                    UnloadMod(oldMod);
                }

                var scripts = CreateScriptInstances(asm, mod);
                var loaded = new LoadedMod(mod, modAlc, scripts);
                s_loadedMods[mod.DirectoryPath] = loaded;

                RedirectManager.Global.RegisterRedirectors(asm);
                ScriptComponentManager.RegisterTypes(asm);

                if (s_isInitialized)
                {
                    RedirectManager.ConfigureAllRedirectedFunctions();
                    ScriptComponentManager.AutoAttachTypesToExistingObjs();

                    foreach (var script in scripts)
                    {
                        script.OnLoad();
                    }
                }
            },
            state: null
        );

        return true;
    }

    /// <summary>
    /// Unloads a single mod, removing its scripts, components, and redirectors.
    /// </summary>
    private static void UnloadMod(LoadedMod loaded)
    {
        var asm = loaded.Alc.Assemblies.FirstOrDefault();

        // Call OnUnload on this mod's scripts
        foreach (var script in loaded.Scripts)
        {
            script.OnUnload();
        }

        if (asm != null)
        {
            // Detach components and clear registrations for this mod's assembly
            ScriptComponentManager.UnregisterTypes(asm);
            RedirectManager.Global.UnregisterRedirectors(asm);
            RedirectManager.Local.ClearCacheForAssembly(asm);
        }

        // Unload the assembly context
        loaded.Alc.Unload();
        s_loadedMods.Remove(loaded.Mod.DirectoryPath);
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }

    /// <summary>
    /// Reloads a single mod by its directory path.
    /// </summary>
    private static void ReloadMod(string modDirPath)
    {
        lock (s_lockObj)
        {
            ErrorOverlay.Clear();

            try
            {
                var scriptsDir = FileUtils.GetScriptsPath();

                if (modDirPath == scriptsDir)
                {
                    // Reload implicit Scripts mod
                    var mod = Mod.CreateDefault(scriptsDir);
                    LoadMod(mod, scriptsDir);
                }
                else
                {
                    // Reload explicit mod
                    var tomlPath = Path.Combine(modDirPath, "mod.toml");
                    if (!File.Exists(tomlPath))
                    {
                        // mod.toml was deleted — unload if loaded
                        if (s_loadedMods.TryGetValue(modDirPath, out var oldMod))
                        {
                            EngineSynchronizationContext.Instance.Post(
                                _ => UnloadMod(oldMod),
                                state: null
                            );
                        }

                        return;
                    }

                    var mod = Mod.FromDirectory(modDirPath);
                    var modScriptsDir = Path.Combine(modDirPath, "scripts");
                    LoadMod(mod, modScriptsDir);
                }
            }
            catch (Exception e)
            {
                Debug.LogError($"Failed to reload mod: {e.Message}");
            }
        }
    }

    /// <summary>
    /// Compiles all C# script files for a single mod into an in-memory assembly.
    /// </summary>
    private static (MemoryStream?, MemoryStream?) CompileMod(Mod mod, string scriptsDir)
    {
        var baseDir = FileUtils.GetBasePath();

        if (!Directory.Exists(scriptsDir))
        {
            return (null, null);
        }

        var sourceFilePaths = Directory
            .EnumerateFiles(scriptsDir, "*.cs", SearchOption.AllDirectories)
            .Where(filePath => !filePath.Replace("\\", "/").Contains("/obj/"))
            .ToList();

        if (sourceFilePaths.Count == 0)
        {
            Debug.LogWarning(
                $"[{mod.Name}] No script files found in .\\{Path.GetRelativePath(baseDir, scriptsDir)}"
            );
            return (null, null);
        }

        var syntaxTrees = sourceFilePaths
            .Select(filePath =>
            {
                using var stream = File.OpenRead(filePath);
                return CSharpSyntaxTree.ParseText(
                    SourceText.From(stream, Encoding.UTF8),
                    ParseOptions,
                    filePath
                );
            })
            .ToList();

        syntaxTrees.Insert(index: 0, GlobalUsingsTree);

        Debug.Log(
            $"[{mod.Name}] Compiling {sourceFilePaths.Count} {CommonUtils.FormatPlural(sourceFilePaths.Count, "script")}"
        );
        Debug.Log("(...)");

        var watch = Stopwatch.StartNew();

        var targetName = $"{mod.Name}.dll";
        var compilation = CSharpCompilation
            .Create(targetName)
            .WithOptions(CompilerOptions)
            .AddReferences(MetadataReferences)
            .AddSyntaxTrees(syntaxTrees);

        var peStream = new MemoryStream();
        var pdbStream = new MemoryStream();
        var emitResult = compilation.Emit(peStream, pdbStream);

        if (!emitResult.Success)
        {
            PrintErrors(emitResult, scriptsDir, mod.Name);
            return (null, null);
        }

        watch.Stop();
        Debug.Log(
            $"[{mod.Name}] Success! {sourceFilePaths.Count} {CommonUtils.FormatPlural(sourceFilePaths.Count, "script")} compiled in {watch.Elapsed.FormatDuration()}"
        );

        peStream.Position = 0;
        pdbStream.Position = 0;
        return (peStream, pdbStream);
    }

    private static void PrintErrors(EmitResult emitResult, string scriptsDir, string modName)
    {
        var errors = GetErrors(emitResult);
        var errorsByFilePath = errors
            .GroupBy(error => error.Location.SourceTree?.FilePath ?? "(no file)")
            .ToDictionary(group => group.Key, group => group.ToArray());

        foreach (var filePath in errorsByFilePath.Keys)
        {
            var shortPath = Path.GetRelativePath(scriptsDir, filePath);
            Debug.LogError(
                $"[{modName}] {shortPath}: {errorsByFilePath[filePath].Length} errors:",
                skipSender: true
            );

            foreach (var error in errorsByFilePath[filePath])
            {
                var lineSpan = error.Location.GetLineSpan();
                var mappedLineSpan = error.Location.GetMappedLineSpan();
                if (mappedLineSpan.HasMappedPath)
                {
                    lineSpan = mappedLineSpan;
                }

                var locationText = "";
                if (lineSpan.IsValid)
                {
                    var pos = lineSpan.StartLinePosition;
                    locationText = $"({pos.Line + 1}) ";
                }

                Debug.LogError(
                    $"  {locationText}{error.Id}: {error.GetMessage()}",
                    skipSender: true
                );
            }
        }

        Debug.LogError($"[{modName}] Compilation failed!");
    }

    private static Diagnostic[] GetErrors(EmitResult emitResult)
    {
        var diags = emitResult.Diagnostics;
        return diags
            .Where(diag => diag.IsWarningAsError || diag.Severity == DiagnosticSeverity.Error)
            .ToArray();
    }

    private static List<Script> CreateScriptInstances(Assembly asm, Mod mod)
    {
        var scriptTypes = asm.GetTypes()
            .Where(t => !t.IsAbstract)
            .Where(t => t.GetCustomAttribute<ScriptAttribute>() != null)
            .Where(t => t.IsAssignableTo(typeof(Script)));

        var scripts = new List<Script>();
        foreach (var scriptType in scriptTypes)
        {
            var scriptAttribute = scriptType.GetCustomAttribute<ScriptAttribute>()!;
            var scriptName = scriptAttribute.Name ?? scriptType.Name;

            try
            {
                // Create script instance without running constructor
                var script = (Script)
                    Guard.NotNull(RuntimeHelpers.GetUninitializedObject(scriptType));
                // Set fields so they become available during initialization
                script.Name = scriptName;
                script.Mod = mod;
                // Initialize object
                scriptType.GetConstructor(Type.EmptyTypes)?.Invoke(script, null);

                scripts.Add(script);
            }
            catch (Exception e)
            {
                Debug.LogError(
                    $"[{mod.Name}] Failed to create instance of script {scriptName}: {e.Message}",
                    skipSender: true
                );

                continue;
            }
        }

        return scripts;
    }

    // --- File watching ---

    private static FileSystemWatcher? s_modsWatcher;
    private static FileSystemWatcher? s_scriptsWatcher;

    private static void WatchForChanges()
    {
        var modsDir = FileUtils.GetModsPath();
        var scriptsDir = FileUtils.GetScriptsPath();

        if (Directory.Exists(modsDir))
        {
            s_modsWatcher = new FileSystemWatcher(modsDir)
            {
                Filter = "*.cs",
                IncludeSubdirectories = true,
                NotifyFilter =
                    NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName,
            };

            s_modsWatcher.Changed += OnModsFileChanged;
            s_modsWatcher.Created += OnModsFileChanged;
            s_modsWatcher.Deleted += OnModsFileChanged;
            s_modsWatcher.Renamed += OnModsFileChanged;
            s_modsWatcher.EnableRaisingEvents = true;
        }

        if (Directory.Exists(scriptsDir))
        {
            s_scriptsWatcher = new FileSystemWatcher(scriptsDir)
            {
                Filter = "*.cs",
                IncludeSubdirectories = true,
                NotifyFilter =
                    NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName,
            };

            s_scriptsWatcher.Changed += OnScriptsFileChanged;
            s_scriptsWatcher.Created += OnScriptsFileChanged;
            s_scriptsWatcher.Deleted += OnScriptsFileChanged;
            s_scriptsWatcher.Renamed += OnScriptsFileChanged;
            s_scriptsWatcher.EnableRaisingEvents = true;
        }
    }

    private static void OnModsFileChanged(object sender, FileSystemEventArgs e)
    {
        var modDir = ResolveModDirectory(e.FullPath);
        if (modDir == null)
        {
            return;
        }

        ScheduleReload(modDir);
    }

    private static void OnScriptsFileChanged(object sender, FileSystemEventArgs e)
    {
        ScheduleReload(FileUtils.GetScriptsPath());
    }

    private static string? ResolveModDirectory(string changedFilePath)
    {
        var modsDir = FileUtils.GetModsPath();
        var relative = Path.GetRelativePath(modsDir, changedFilePath);
        var parts = relative.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);

        if (parts.Length < 2)
        {
            return null;
        }

        return Path.Combine(modsDir, parts[0]);
    }

    private static void ScheduleReload(string modDirPath)
    {
        if (!s_debounceTimers.TryGetValue(modDirPath, out var timer))
        {
            timer = new Timer(_ => ReloadMod(modDirPath));
            s_debounceTimers[modDirPath] = timer;
        }

        timer.Change(DebounceMillis, Timeout.Infinite);
    }
}
