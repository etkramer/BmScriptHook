namespace BmSDK.Framework;

public static class FileUtils
{
    /// <summary>
    /// Returns the full path to the game directory (./).
    /// </summary>
    public static string GetBasePath() =>
        Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Environment.ProcessPath)!, "..", ".."));

    /// <summary>
    /// Returns the full path to the binaries directory (./Binaries/Win32/).
    /// </summary>
    public static string GetBinariesPath() => Path.Combine(GetBasePath(), "Binaries", "Win32");

    /// <summary>
    /// Returns the full path to the game directory (./BmGame/).
    /// </summary>
    public static string GetGamePath() => Path.Combine(GetBasePath(), "BmGame");

    /// <summary>
    /// Returns the full path to the scripts directory (./BmGame/Scripts/).
    /// </summary>
    public static string GetScriptsPath() => Path.Combine(GetBasePath(), "BmGame", "Scripts");

    /// <summary>
    /// Returns the full path to the mods directory (./BmGame/Mods/).
    /// </summary>
    public static string GetModsPath() => Path.Combine(GetBasePath(), "BmGame", "Mods");
}
