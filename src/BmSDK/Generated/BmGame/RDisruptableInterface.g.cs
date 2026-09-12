#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RDisruptableInterface<br/>
/// (size = 44)
/// (flags = 16403)
/// </summary>
public partial interface RDisruptableInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: DisallowLongRangeResonator
    /// </summary>
    public unsafe bool DisallowLongRangeResonator();

    /// <summary>
    /// Function: GetNumFakePasswordsToUse
    /// </summary>
    public unsafe int GetNumFakePasswordsToUse();

    /// <summary>
    /// Function: GetFakePassword
    /// </summary>
    public unsafe BmSDK.FString GetFakePassword(int Index);

    /// <summary>
    /// Function: GetPassword
    /// </summary>
    public unsafe BmSDK.FString GetPassword(int Index);

    /// <summary>
    /// Function: GetFakePasswordArrayLength
    /// </summary>
    public unsafe int GetFakePasswordArrayLength();

    /// <summary>
    /// Function: GetPasswordArrayLength
    /// </summary>
    public unsafe int GetPasswordArrayLength();

    /// <summary>
    /// Function: GetResonatorMinigameStringReference
    /// </summary>
    public unsafe BmSDK.FString GetResonatorMinigameStringReference();

    /// <summary>
    /// Function: GetResonatorWinScreenStringReference
    /// </summary>
    public unsafe BmSDK.FString GetResonatorWinScreenStringReference();

    /// <summary>
    /// Function: GetRawDifficulty
    /// </summary>
    public unsafe int GetRawDifficulty();

    /// <summary>
    /// Function: GetHackingTargetType
    /// </summary>
    public unsafe BmSDK.BmGame.RDisruptableInterface.DisruptableObjectTargetType GetHackingTargetType();

    /// <summary>
    /// Function: GetHackingNetworkType
    /// </summary>
    public unsafe BmSDK.BmGame.RDisruptableInterface.DisruptableObjectNetworkType GetHackingNetworkType();

    /// <summary>
    /// Function: GetActiveFlag
    /// </summary>
    public unsafe BmSDK.FName GetActiveFlag();

    /// <summary>
    /// Function: GetNoCodesFailedDialogueLine
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine GetNoCodesFailedDialogueLine();

    /// <summary>
    /// Function: StopAlarmSound
    /// </summary>
    public unsafe void StopAlarmSound();

    /// <summary>
    /// Function: PlayAlarmSound
    /// </summary>
    public unsafe void PlayAlarmSound();

    /// <summary>
    /// Function: IsAlarmed
    /// </summary>
    public unsafe bool IsAlarmed();

    /// <summary>
    /// Function: RequiresHighSecurityResonator
    /// </summary>
    public unsafe bool RequiresHighSecurityResonator();

    /// <summary>
    /// Function: GetDifficultyLevel
    /// </summary>
    public unsafe int GetDifficultyLevel();

    /// <summary>
    /// Function: HasMultipleStages
    /// </summary>
    public unsafe bool HasMultipleStages();

    /// <summary>
    /// Function: StartResonatorMiniGame
    /// </summary>
    public unsafe void StartResonatorMiniGame();

    /// <summary>
    /// Function: FailedToDisrupt
    /// </summary>
    public unsafe void FailedToDisrupt();

    /// <summary>
    /// Function: WillExplode
    /// </summary>
    public unsafe bool WillExplode();

    /// <summary>
    /// Function: StillDisruptable
    /// </summary>
    public unsafe bool StillDisruptable();

    /// <summary>
    /// Function: GetIconLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetIconLocation();

    /// <summary>
    /// Function: SuccessfullyDisrupted
    /// </summary>
    public unsafe void SuccessfullyDisrupted();

    /// <summary>
    /// Function: GetDifficulty
    /// </summary>
    public unsafe void GetDifficulty(ref float Threshold, ref float BuildUpTime, ref float LeftMaxAngVelocity, ref float RightMaxAngVelocity, int DifficultyMod = default);

    /// <summary>
    /// Enum: DisruptableObjectTargetType
    /// </summary>
    public enum DisruptableObjectTargetType : byte
    {
        DOTT_AccessDoor = 0,
        DOTT_ElevatorControlCall = 1,
        DOTT_ElevatorControlLower = 2,
        DOTT_ElevatorControlRaise = 3,
        DOTT_ElectrifiedFenceDeactivate = 4,
        DOTT_ElectrifiedFenceActivate = 5,
        DOTT_SecurityDoor = 6,
        DOTT_DisplayCabinet = 7,
        DOTT_ControlBox = 8,
        DOTT_TunnelAccess = 9,
        DOTT_TowerMaintenanceHatch = 10,
        DOTT_MaintenanceAccess = 11,
        DOTT_AccessBridge = 12,
        DOTT_DeadshotPda = 13,
        DOTT_RiddlerBarrier = 14,
        DOTT_RiddlerElectricFloor = 15,
        DOTT_MAX = 16,
    }

    /// <summary>
    /// Enum: DisruptableObjectNetworkType
    /// </summary>
    public enum DisruptableObjectNetworkType : byte
    {
        DONT_GothamMunicipalNetwork = 0,
        DONT_TygerMcpMainframe = 1,
        DONT_RiddlerMatrix = 2,
        DONT_MobileElectronicDevice = 3,
        DONT_MAX = 4,
    }
}
