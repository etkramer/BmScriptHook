using System.Numerics;
using BmSDK;
using BmSDK.BmGame;

[Script]
public class CameraScript : Script
{
    CameraController? _cameraController = null;

    public override void OnKeyDown(Keys key)
    {
        // Use 'Z' key to toggle camera
        if (key == Keys.Z)
        {
            // Spawn P2 manually if needed
            if (Game.GetGameRI().PlayerList.Count < 2)
            {
                var gameViewport = Game.GetGameViewportClient();
                FString error = default;
                gameViewport.CreatePlayer(1, ref error, true);
            }

            var controller0 = Game.GetPlayerController(0) as RPlayerControllerCombat;
            var controller1 = Game.GetPlayerController(1) as RPlayerControllerCombat;

            if (_cameraController == null)
            {
                // Spawn new CameraController
                _cameraController = new CameraController(controller0, controller1);
            }
            else
            {
                // Destroy current CameraController
                _cameraController.Dispose();
                _cameraController = null;
            }
        }
    }

    public override void OnTick()
    {
        _cameraController?.Tick();
    }
}

class CameraController(RPlayerControllerCombat controller0, RPlayerControllerCombat controller1)
    : IDisposable
{
    public const float CameraSpeed = 2.5f;

    public const float CameraHeightMin = 700;
    public const float CameraHeightMax = 2500;
    public const float CameraHeightCombat = 1800;

    public const float PlayerDistMin = 400;
    public const float PlayerDistMax = 2000;

    public RPlayerControllerCombat Controller0 { get; } = controller0;
    public RPlayerControllerCombat Controller1 { get; } = controller1;

    public void Tick()
    {
        if (!Controller0.IsValid || !Controller1.IsValid)
        {
            return;
        }

        // Make sure we're using the right view target
        Controller0.SetViewTarget(Controller0.MultiTargetCamera);

        // Compute new camera position
        var pos0 = Controller0.Pawn.Location;
        var pos1 = Controller1.Pawn.Location;
        var newPosFlat = Vector2.Lerp(pos0.GetXY(), pos1.GetXY(), 0.5f);
        var newPos = new Vector3(newPosFlat.X, newPosFlat.Y, 0);

        // Fixed height in combat
        if (Controller0.IsInCombat() || Controller1.IsInCombat())
        {
            newPos.Z = Math.Max(pos0.Z, pos1.Z) + CameraHeightCombat;
        }
        // Else choose height based on distance
        else
        {
            var playerDist = Vector2.Distance(pos0.GetXY(), pos1.GetXY());
            var adjustFactor = 0f;

            if (playerDist > PlayerDistMax)
            {
                // Teleport P2 to P1
                Controller1.Pawn.SetLocation(
                    Controller0.Pawn.Location with
                    {
                        Y = Controller0.Pawn.Location.Y + 200,
                    }
                );
            }
            else
            {
                adjustFactor = Math.Clamp(
                    (playerDist - PlayerDistMin) / (PlayerDistMax - PlayerDistMin),
                    0,
                    1
                );
            }

            newPos.Z =
                Math.Max(pos0.Z, pos1.Z)
                + float.Lerp(CameraHeightMin, CameraHeightMax, adjustFactor);
        }

        // Smoothly lerp camera position
        var oldPos = Controller0.MultiTargetCamera.Location;
        newPos = Vector3.Lerp(oldPos, newPos, CameraSpeed * Game.GetDeltaTime());

        // Hijhack MultiTargetCamera with custom values
        Controller0.MultiTargetCamera.SetLocation(newPos);
        Controller0.MultiTargetCamera.SetRotation(
            new()
            {
                Pitch = -90 * 180,
                Yaw = 0 * 180,
                Roll = 0 * 180,
            }
        );
    }

    public void Dispose()
    {
        // Reset view target
        Controller0.SetViewTarget(Controller0.Pawn);
    }
}

static class CameraScriptExtensions
{
    public static Vector2 GetXY(this Vector3 vec) => new(vec.X, vec.Y);
}
