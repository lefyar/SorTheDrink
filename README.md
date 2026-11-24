# SorTheDrink

SorTheDrink is a Unity AR app for exploring the nutrition information on packaged drinks. Point a camera at a supported beverage label to see its information card, or use the searchable library to look up a drink by name and category. The catalog contains 11 beverages. Energy, sugar, and sodium values are recorded per whole bottle or can.

[Demo Video](https://youtu.be/jdphixZWKNU?si=zIp0IB2zwijLXqH0)

## Open the project

1. Install **Unity 6000.0.73f1** through Unity Hub. For an Android build, include Android Build Support, the Android SDK and NDK tools, and OpenJDK.
2. In Unity Hub, add the folder containing `Assets`, `Packages`, and `ProjectSettings`. Open the project and allow Unity to restore its packages.
3. Download the **Vuforia Engine 11.4.4** Unity installer. In Unity, choose **Assets → Import Package → Custom Package**, select the downloaded installer, then accept the prompt to add Vuforia Engine. The SDK is installed locally on each checkout. [Vuforia SDK downloads](https://developer.vuforia.com/downloads/sdk) · [Installation guide](https://developer.vuforia.com/library/vuforia-engine/unity-extension/vuforia-engine-package-unity/)
4. Select the AR camera in the Scanner scene, open its Vuforia Engine configuration, and enter your own Vuforia app license key. The local configuration is excluded from Git.
5. Open [MainMenu.unity](Assets/_Project/Scenes/MainMenu.unity) and press **Play**.

## Try it

- **Library** — Search for a drink, narrow the list by category, and select a result to see its product and nutrition details.
- **Scanner** — Allow camera access and aim at a target such as Thai Milk Tea or Pocari Sweat. For a repeatable test, display a [target image](Assets/Editor/Vuforia/ImageTargetTextures/BeverageDatabase) on a second screen. The scanner uses the included Vuforia device database.
- **Android** — In **File → Build Profiles**, switch to Android, connect a device with USB debugging enabled, then choose **Build and Run**. The shared scene list starts with MainMenu and includes Scanner and Library.

## Project layout

| Path | Contents |
| --- | --- |
| `Assets/_Project/Scenes` | Menu, AR scanner, and library scenes |
| `Assets/_Project/Scripts/Data` | Beverage records and shared catalog |
| `Assets/_Project/Scripts/AR` | Displays the selected beverage card on its AR target |
| `Assets/_Project/Scripts/Library` | Catalog search, category filters, and detail panel |
| `Assets/StreamingAssets/Vuforia` | Compiled image-target database and target definitions |
| `Packages` and `ProjectSettings` | Unity dependencies, rendering settings, and scene order |

## Working with Git

Commit Unity assets together with their `.meta` files so references survive a fresh clone. The source fits in ordinary Git. Unity regenerates its import cache locally. After installing Vuforia, keep its SDK archive and machine-specific package paths local.
