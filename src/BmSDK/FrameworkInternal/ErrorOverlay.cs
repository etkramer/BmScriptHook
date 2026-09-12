using BmSDK.Engine;

namespace BmSDK.Framework;

/// <summary>
/// Draws error lines on top of the game viewport. Populated by <see cref="Debug.LogError"/>
/// and cleared on hot reload.
/// </summary>
internal static class ErrorOverlay
{
    private static readonly Lock s_lock = new();
    private static readonly List<string> s_lines = [];

    private const float MarginX = 16f;
    private const float MarginY = 16f;
    private const float LineHeight = 16f;

    public static void Add(string line)
    {
        lock (s_lock)
        {
            s_lines.Add(line);
        }
    }

    public static void Clear()
    {
        lock (s_lock)
        {
            s_lines.Clear();
        }
    }

    [Redirect(typeof(GameViewportClient), nameof(GameViewportClient.PostRender))]
    private static void PostRenderRedirect(GameViewportClient self, Canvas canvas)
    {
        // Let the engine do its normal HUD/console/transition rendering first so our
        // banner draws on top.
        self.PostRender(canvas);

        string[] snapshot;
        lock (s_lock)
        {
            if (s_lines.Count == 0)
            {
                return;
            }

            snapshot = [.. s_lines];
        }

        Draw(canvas, snapshot);
    }

    private static void Draw(Canvas canvas, string[] lines)
    {
        canvas.SetDrawColor(255, 64, 64, 255);

        var y = MarginY;
        foreach (var line in lines)
        {
            canvas.SetPos(MarginX, y, 0f);
            canvas.DrawText(line, CR: false, XScale: 1f, YScale: 1f);
            y += LineHeight;
        }
    }
}
