> **Important note**: This is the *BmSDK for Arkham City* repository.
>
> The scripthook is also available for [Batman: Arkham Knight](https://github.com/Team-BmSDK/BmSDK-AK).

<br />

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://github.com/user-attachments/assets/ab0b54fe-b851-4021-aaf4-c8e0a834f051">
    <img alt="BmSDK" width="600" src="https://github.com/user-attachments/assets/d5446cc2-16c8-4dd0-98fa-7248708d6c46">
  </picture>
</p>

<br />

<p align="center">
A powerful, easy-to-use scripting platform for Batman: Arkham City that lets you integrate custom C# code for gameplay mods and more.
</p>

<br />

<p align="center">
  <a href="./LICENSE.md">
    <img alt="MIT license" src="https://img.shields.io/badge/license-MIT-green.svg?style=for-the-badge" />
  </a>
  <a href="../../releases/latest">
    <img alt="Latest release" src="https://img.shields.io/github/v/release/Team-BmSDK/BmSDK-AC?style=for-the-badge" />
  </a>
  <a href="../../releases/latest">
    <img alt="Downloads" src="https://img.shields.io/github/downloads/Team-BmSDK/BmSDK-AC/total?style=for-the-badge" />
  </a>
  <a href="https://dotnet.microsoft.com/en-us/download/dotnet/10.0">
    <img alt=".NET 10" src="https://img.shields.io/badge/.NET-10.0-512bd4?style=for-the-badge" />
  </a>
  <a href="https://discord.com/invite/arkhamworkshop">
    <img alt="Community Discord" src="https://img.shields.io/discord/1218395254013558844?logo=discord&logoColor=E0E3FF&label=Community%20Discord&labelColor=5865F2&style=for-the-badge" />
  </a>
</p>

<hr />

<br />

The scripthook gives you access to a full SDK for working with the game, world and engine. The SDK exposes Unreal Engine 3's own UnrealScript API to C# scripts. Modders get to work with the same types, properties and functions as the original developers did. There are also many useful life-cycle events *(e.g. tick and game enter)* and helpers provided. Below is an example mod that shows off some of BmSDK's capabilities:
<details> 
<summary>Script to spawn in Joker near the player</summary>

```csharp
using BmSDK;
using BmSDK.BmGame;
using BmSDK.BmScript;

[Script]
public class DemoScript : Script
{
    public override void OnKeyDown(Keys key)
    {
        if (key != Keys.J) return;

        // Load UPK with Joker's assets
        Game.LoadPackage("FunFair");

        // Spawn Joker in front of the player
        var player = Game.GetPlayerPawn();
        var joker = new RPawnVillainThug(player.Location, player.Rotation);
        joker.InitCharacter(RCharacter_Joker.StaticClass());

        var playerDir = player.Rotation.ToDirection() with { Z = 0 };
        joker.Move(playerDir * 100);
    }
}
```
</details>

Check out the [documentation](https://bmsdk.dev/docs) for more info!

## 🚀 Getting started
If you want to play script mods, getting started is simple:
1. Download the latest release from [releases](../../releases/latest) and open the ZIP file.
2. Inside you'll see two folders: `Binaries` and `BmGame`. Copy both to your game folder (likely `C:\Program Files\Epic Games\BatmanArkhamCity`). There should already be 2 folders in there with the same names.
3. BmSDK is now installed! To play script mods, simply drop any .cs files into your `BmGame\Scripts` folder and start the game.

Keep in mind that script mods can potentially harm your computer. Make sure you only download and install scripts from trusted sources.

### ⚠️ Notice for GOG users:
Only Steam and Epic copies of Arkham City are supported currently. GOG support is being considered, but BmSDK unfortunately does not work on this platform for the time being.

## 🧩 Setting Up for Mod Development
Follow these steps to set up your environment for building, running, and debugging script mods:
1. [Install BmSDK](#-getting-started)
2. Go to [visualstudio.microsoft.com/downloads](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Stable) and run the Visual Studio Installer.
3. In the Visual Studio Installer, select "**.NET desktop development**" from the _Workloads_ tab.
4. Start Visual Studio and open the solution in `%GameDir%\BmGame\ScriptsDev`.
5. Write your code in any C# source file in `%GameDir%\BmGame\Scripts`.
6. Run your code by pressing **F5** in Visual Studio.
7. Follow the [docs](https://bmsdk.dev/docs/guides/first-mod/) to write your first script.

## 🛠️ Contributing
To get started contributing to BmSDK, see the docs for instructions: [Building from source](https://bmsdk.dev/docs/contributing/building/)

## 📋 Legal notice
BmSDK is published under the [MIT licence](LICENSE.md).

BmSDK is not associated with Warner Bros. Games or Rocksteady Studios. All product and company names are trademarks or registered trademarks of their respective holders. Use of these names does not imply any affiliation or endorsement by them.
