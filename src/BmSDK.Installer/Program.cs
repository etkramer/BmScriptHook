using System.Reflection;

namespace BmSDK.Installer;

internal static class Program
{
    /// <summary>
    /// The BmSDK version bundled with this installer.
    /// </summary>
    public static string Version { get; } = Assembly.GetExecutingAssembly()
        .GetCustomAttribute<AssemblyInformationalVersionAttribute>()!.InformationalVersion.Split('+')[0];

    [STAThread]
    private static void Main(string[] args)
    {
        // Set when relaunching elevated, so the second process can resume where the first stopped
        var target = GetOption(args, "--target");
        var autoInstall = args.Contains("--auto");

        ApplicationConfiguration.Initialize();
        Application.Run(new InstallerForm(target, autoInstall));
    }

    private static string? GetOption(string[] args, string name)
    {
        var index = Array.IndexOf(args, name);
        return index >= 0 && index + 1 < args.Length ? args[index + 1] : null;
    }
}
