using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BmSDK.Framework;

public static class Debug
{
    private static readonly Stack<string> s_senderStack = new();
    private static readonly ConsoleColor s_defaultColor = Console.ForegroundColor;

    /// <summary>
    /// Mirrors log output to BmSDK.log.
    /// </summary>
    internal static void InitFileLog()
    {
        var writer = new StreamWriter(Path.Combine(FileUtils.GetBinariesPath(), "BmSDK.log"))
        {
            AutoFlush = true,
        };

        Trace.Listeners.Add(new TextWriterTraceListener(writer));
    }

    public static void Log(
        object? msg,
        bool skipSender = false,
        [CallerFilePath] string? callerFilePath = null
    )
    {
        Trace.WriteLine(FormatLine(msg, skipSender, callerFilePath));
    }

    public static void LogWarning(
        object msg,
        bool skipSender = false,
        [CallerFilePath] string? callerFilePath = null
    )
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Log(msg, skipSender, callerFilePath);
        Console.ForegroundColor = s_defaultColor;
    }

    public static void LogError(
        object msg,
        bool skipSender = false,
        [CallerFilePath] string? callerFilePath = null
    )
    {
        var line = FormatLine(msg, skipSender, callerFilePath);
        ErrorOverlay.Add(line);

        Console.ForegroundColor = ConsoleColor.Red;
        Trace.WriteLine(line);
        Console.ForegroundColor = s_defaultColor;
    }

    private static string FormatLine(object? msg, bool skipSender, string? callerFilePath)
    {
        var msgText = msg?.ToString() ?? "null";
        if (skipSender)
        {
            return msgText;
        }

        // Get sender, else fall back to the source file name.
        if (!s_senderStack.TryPeek(out var sender))
        {
            sender = callerFilePath is null ? "UNKNOWN" : Path.GetFileName(callerFilePath);
        }

        return $"{sender}: {msgText}";
    }

    internal static void PushSender(string sender)
    {
        s_senderStack.Push(sender);
    }

    internal static void PopSender()
    {
        s_senderStack.Pop();
    }

    internal static void RunWithSender(string sender, Action action)
    {
        s_senderStack.Push(sender);
        try
        {
            action();
        }
        finally
        {
            s_senderStack.Pop();
        }
    }
}
