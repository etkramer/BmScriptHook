//
// A script demonstrating the basic workflow with scripts and common BmSDK APIs.
//

using BmSDK;
using BmSDK.BmGame;
using BmSDK.BmScript;
using BmSDK.Engine;

[Script]
public class DemoScript : Script
{
    /// <summary>
    /// Called called once when the engine first becomes ready.
    /// Do basic set up here.
    /// </summary>
    public override void Main()
    {
        // Boost snow intensity on CDO (template object)
        var defaultRainComponent = RRainComponent.DefaultObject;
        defaultRainComponent?.ParticleCount *= 5;

        // Set max players (default and current/frontend)
        foreach (var gameInfo in Game.FindObjects<RGameInfo>())
        {
            gameInfo.MaxPlayers = 4;
        }
    }

    /// <summary>
    /// Called when you enter the main menu
    /// (game start up or when exiting session).
    /// </summary>
    public override void OnEnterMenu()
    {
        // Enable info display
        Game.GetGameViewportClient().bShowSessionDebug = true;
    }

    /// <summary>
    /// Called when entering the game world.
    /// </summary>
    public override void OnEnterGame()
    {
        // Enable 1-hit counters
        foreach (var counterMove in Game.FindObjects<RCombatMove_BatmanCounter>())
        {
            counterMove.bShouldKill = true;
        }
    }

    /// <summary>
    /// Called when a key is pressed during gameplay
    /// (not in pause screen).
    /// </summary>
    public override void OnKeyDown(Keys key)
    {
        // Debug actions based on key press.
        switch (key)
        {
            case Keys.Enter:
                DebugLoadGame();
                break;
            case Keys.T:
                DebugAddSplitScreenPlayer();
                break;
            case Keys.V:
                DebugToggleGhost();
                break;
            case Keys.R:
                TestSpawnActor();
                break;
        }
    }

    static void TestSpawnActor()
    {
        var playerPawn = Game.GetPlayerPawn();

        // Load package we need for RCharacter_Joker
        Game.LoadPackage("FunFair");

        // Create location 1m behind player
        var playerDir = playerPawn.Rotation.ToDirection() with { Z = 0 };
        var charoffset = playerDir * (-1) * 100;

        // Spawn in a pawn
        var newCharacter = new RPawnVillainThug(playerPawn.Location, playerPawn.Rotation);
        newCharacter.InitCharacter(RCharacter_Joker.StaticClass());

        // Move new pawn behind player
        newCharacter?.Move(charoffset);

        Debug.Log($"Spawned character {newCharacter?.ToString() ?? "NULL"}");
    }

    static void DebugLoadGame()
    {
        Debug.Log("Entering game");

        // Prevent corrupting current save slot
        var saveMan = Game.GetGameRI().SaveGameManager;
        saveMan.SetActiveStorySlotID(RSaveGameManager.StorySlots.StorySlot_Temp);

        // Enter demo world
        var console = Game.GetConsole();
        console.ConsoleCommand(
            "start batentry?Players=Playable_Batman?" +
            "Area=OW,OW_A9,OW_A6,OW_A7,OW_A8,OW_R1,OW_R2,OW_E3,OW_E4,OW_A1_Static_LOD,OW_A2,OW_A3_Static_LOD,OW_A4_Static_LOD,OW_A5_Static_LOD,OW_R3,OW_E2_Static_LOD,OW_E6_Static_LOD,OW_E5_Static_LOD,OW_RE1_Static_LOD?" +
            "Flags=Vertical_Slice,Demo_Riddler_Door_Switch,Map_TriggeredCityStories,Batman_ResonatorCodes,Teleport_Church_To_Museum,Demo_Ryder_Bully,Demo_Courthouse_Lock,Public_Demo?" +
            "Chapters=1,1b,2,2a,Z1,V1?" +
            "Start=BeginVS?"
        );
    }

    static void DebugToggleGhost()
    {
        Debug.Log("Toggling ghost");

        var cheatManager = Game.GetCheatManager();
        cheatManager.ToggleGhost();
    }

    static void DebugAddSplitScreenPlayer()
    {
        Debug.Log("Spawning P2");

        var gameViewport = Game.GetGameViewportClient();
        gameViewport.DesiredSplitscreenType = GameViewportClient.ESplitScreenType.eSST_2P_VERTICAL;
        FString error = default;
        gameViewport.CreatePlayer(1, ref error, true);
    }
}

[ScriptComponent(AutoAttach = true)]
public class MenuActorReplacerComponent : ScriptComponent<RCinematicCustomActor>
{
    [ComponentRedirect(nameof(RCinematicCustomActor.BeginAnimControl))]
    void BeginAnimControl(InterpGroup inInterpGroup)
    {
        Debug.Log("Hello from BeginAnimControl!");

        // Calling the base implementation is optional.
        Owner.BeginAnimControl(inInterpGroup);
    }

    [ComponentRedirect(nameof(RCinematicCustomActor.PostBeginPlay))]
    void PostBeginPlay()
    {
        // Load package with Robin's meshes
        Game.LoadPackage("Playable_Robin_Std_SF");

        // Replace cinematic Batman (head/body)
        if (Owner.SkeletalMeshComponent.SkeletalMesh.Name.ToString() == "Batman_Head_Skin")
        {
            var newHeadMesh = Game.FindObject<SkeletalMesh>("Robin.Mesh.Robin_Head_Skin");
            var newBodyMesh = Game.FindObject<SkeletalMesh>("Robin.Mesh.Robin_Staff_V2");
            Owner.SkeletalMeshComponent.SetSkeletalMesh(newHeadMesh);
            Owner.ExtraSkeletalMeshComponent1.SetSkeletalMesh(newBodyMesh);
            Debug.Log("Using Robin's head/body");
        }

        // Replace cinematic Batman (cape)
        if (Owner.SkeletalMeshComponent.SkeletalMesh?.Name.ToString() == "Cape_Mesh")
        {
            var newCapeMesh = Game.FindObject<SkeletalMesh>("Robin.Mesh.Robin_Cape_V2");
            Owner.SkeletalMeshComponent.SetSkeletalMesh(newCapeMesh);
            Debug.Log("Using Robin's cape");
        }

        // Calling the base implementation is optional.
        Owner.PostBeginPlay();
    }
}
