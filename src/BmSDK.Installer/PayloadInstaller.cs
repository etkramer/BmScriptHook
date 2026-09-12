using System.ComponentModel;
using System.Diagnostics;
using System.IO.Compression;
using System.Reflection;

namespace BmSDK.Installer;

/// <summary>
/// Extracts the embedded release payload into a game directory.
/// </summary>
internal static class PayloadInstaller
{
    private const string ResourceName = "BmSDK.Installer.payload.zip";

    // Docs that only make sense inside the release ZIP, not loose in the game folder
    private static readonly string[] SkippedEntries = ["README.md", "LICENSE.md"];

    public static void Install(string gameDir, IProgress<int> progress)
    {
        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(ResourceName)
            ?? throw new InvalidOperationException(
                "This installer was built without a BmSDK payload. Please download an official release.");

        using var archive = new ZipArchive(stream, ZipArchiveMode.Read);

        var root = GameDetector.Normalize(gameDir) + Path.DirectorySeparatorChar;
        var entries = archive.Entries
            .Where(x => !x.FullName.EndsWith('/') && !SkippedEntries.Contains(x.FullName, StringComparer.OrdinalIgnoreCase))
            .ToList();

        for (var i = 0; i < entries.Count; i++)
        {
            var entry = entries[i];
            var destPath = Path.GetFullPath(Path.Combine(root, entry.FullName));
            if (!destPath.StartsWith(root, StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidDataException($"Payload entry escapes the target directory: {entry.FullName}");
            }

            Directory.CreateDirectory(Path.GetDirectoryName(destPath)!);
            entry.ExtractToFile(destPath, overwrite: true);

            progress.Report((i + 1) * 100 / entries.Count);
        }
    }

    public static bool IsWritable(string dir)
    {
        try
        {
            var probePath = Path.Combine(dir, $".bmsdk-{Guid.NewGuid():N}.tmp");
            using (File.Create(probePath, 1, FileOptions.DeleteOnClose)) { }
            return true;
        }
        catch (Exception e) when (e is IOException or UnauthorizedAccessException)
        {
            return false;
        }
    }

    /// <summary>
    /// Restarts the installer elevated. Returns false if the UAC prompt was declined.
    /// </summary>
    public static bool RelaunchElevated(string gameDir)
    {
        var startInfo = new ProcessStartInfo(Environment.ProcessPath!)
        {
            UseShellExecute = true,
            Verb = "runas",
            ArgumentList = { "--target", gameDir, "--auto" },
        };

        try
        {
            Process.Start(startInfo);
            return true;
        }
        catch (Win32Exception)
        {
            return false;
        }
    }
}
