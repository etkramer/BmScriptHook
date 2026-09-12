using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace BmSDK.Installer;

internal sealed record GameInstall(string Path, string Source);

/// <summary>
/// Locates Arkham City installations from the Steam and Epic Games launcher metadata.
/// </summary>
internal static partial class GameDetector
{
    private const string SteamAppId = "200260";

    // "Egret" is Epic's internal codename for Arkham City, matched alongside the catalog namespace
    private const string EpicAppName = "Egret";
    private const string EpicNamespace = "40c34bea9cd0460589c867f6a7246342";

    /// <summary>
    /// Returns every valid installation found, deduplicated by directory.
    /// </summary>
    public static List<GameInstall> DetectAll()
    {
        var results = new List<GameInstall>();
        var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (var install in DetectSteam().Concat(DetectEpic()))
        {
            var path = Normalize(install.Path);
            if (IsValidGameDir(path) && seen.Add(path))
            {
                results.Add(install with { Path = path });
            }
        }

        return results;
    }

    public static bool IsValidGameDir(string? path)
    {
        if (string.IsNullOrWhiteSpace(path))
        {
            return false;
        }

        try
        {
            return File.Exists(Path.Combine(path, "Binaries", "Win32", "BatmanAC.exe"))
                && Directory.Exists(Path.Combine(path, "BmGame"));
        }
        catch (ArgumentException)
        {
            return false;
        }
    }

    public static string? GetInstalledVersion(string gameDir)
    {
        var sdkPath = Path.Combine(gameDir, "Binaries", "Win32", "sdk", "BmSDK.dll");
        if (!File.Exists(sdkPath))
        {
            return null;
        }

        var version = System.Diagnostics.FileVersionInfo.GetVersionInfo(sdkPath).ProductVersion;
        return version?.Split('+')[0];
    }

    public static bool PathsEqual(string a, string b) =>
        string.Equals(Normalize(a), Normalize(b), StringComparison.OrdinalIgnoreCase);

    public static string Normalize(string path)
    {
        try
        {
            return Path.TrimEndingDirectorySeparator(Path.GetFullPath(path));
        }
        catch (ArgumentException)
        {
            return path;
        }
    }

    private static IEnumerable<GameInstall> DetectSteam()
    {
        var steamPath = GetSteamPath();
        if (steamPath is null)
        {
            yield break;
        }

        foreach (var library in GetSteamLibraries(steamPath))
        {
            var manifestPath = Path.Combine(library, "steamapps", $"appmanifest_{SteamAppId}.acf");
            var installDir = ReadValue(manifestPath, InstallDirRegex());
            if (installDir is not null)
            {
                yield return new GameInstall(
                    Path.Combine(library, "steamapps", "common", installDir),
                    "Steam"
                );
            }
        }
    }

    private static IEnumerable<GameInstall> DetectEpic()
    {
        var manifestDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
            "Epic", "EpicGamesLauncher", "Data", "Manifests"
        );

        if (!Directory.Exists(manifestDir))
        {
            yield break;
        }

        foreach (var manifestPath in Directory.EnumerateFiles(manifestDir, "*.item"))
        {
            string? location = null;

            try
            {
                using var stream = File.OpenRead(manifestPath);
                using var doc = JsonDocument.Parse(stream);
                var root = doc.RootElement;

                var isTargetApp =
                    GetString(root, "AppName") == EpicAppName
                    || GetString(root, "CatalogNamespace") == EpicNamespace;

                if (isTargetApp)
                {
                    location = GetString(root, "InstallLocation");
                }
            }
            catch (Exception e) when (e is JsonException or IOException or UnauthorizedAccessException)
            {
                continue;
            }

            if (!string.IsNullOrWhiteSpace(location))
            {
                yield return new GameInstall(location, "Epic Games");
            }
        }
    }

    private static string? GetSteamPath()
    {
        var machinePath = Registry.GetValue(
            @"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Valve\Steam", "InstallPath", null) as string;

        var userPath = Registry.GetValue(
            @"HKEY_CURRENT_USER\SOFTWARE\Valve\Steam", "SteamPath", null) as string;

        var steamPath = machinePath ?? userPath;
        return Directory.Exists(steamPath) ? steamPath : null;
    }

    private static IEnumerable<string> GetSteamLibraries(string steamPath)
    {
        var libraryFile = Path.Combine(steamPath, "steamapps", "libraryfolders.vdf");

        return ReadValues(libraryFile, LibraryPathRegex())
            .Prepend(steamPath)
            .DistinctBy(Normalize, StringComparer.OrdinalIgnoreCase);
    }

    private static string? ReadValue(string filePath, Regex regex) =>
        ReadValues(filePath, regex).FirstOrDefault();

    /// <summary>
    /// Returns the first capture group of every match, unescaping Steam's doubled backslashes.
    /// </summary>
    private static List<string> ReadValues(string filePath, Regex regex)
    {
        try
        {
            return regex.Matches(File.ReadAllText(filePath))
                .Select(x => x.Groups[1].Value.Replace(@"\\", @"\"))
                .ToList();
        }
        catch (Exception e) when (e is IOException or UnauthorizedAccessException or ArgumentException)
        {
            return [];
        }
    }

    private static string? GetString(JsonElement element, string name) =>
        element.TryGetProperty(name, out var value) && value.ValueKind == JsonValueKind.String
            ? value.GetString()
            : null;

    [GeneratedRegex("""^\s*"path"\s+"(.+?)"\s*$""", RegexOptions.Multiline)]
    private static partial Regex LibraryPathRegex();

    [GeneratedRegex("""^\s*"installdir"\s+"(.+?)"\s*$""", RegexOptions.Multiline)]
    private static partial Regex InstallDirRegex();
}
