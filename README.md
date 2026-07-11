# Multiplayer Region Bypass

A BepInEx mod for Mycopunk that unlocks the **Worldwide** multiplayer lobby distance option.

## Features

- Extends the lobby distance slider beyond the default range
- Adds a fourth option: **Close**, **Medium**, **Far**, and **Worldwide**
- Updates the on-screen label to match the selected distance

## Getting Started

### Dependencies

* Mycopunk (base game)
* [BepInEx](https://github.com/BepInEx/BepInEx) - Version 5.4.2403 or compatible

### Installing

**Via Thunderstore (Recommended)**:
1. Download and install via Thunderstore Mod Manager / r2modman
2. The mod will be automatically installed to the correct directory

**Manual Installation**:
1. Place `MultiplayerRegionBypass.dll` in your `<Mycopunk Directory>/BepInEx/plugins/` folder

### Building

1. Clone this repository
2. Open the solution in Visual Studio, Rider, or your preferred C# IDE
3. Build in Release mode

Alternatively:
```bash
dotnet build --configuration Release
```

## Configuration

No configuration required. The Worldwide lobby distance option is enabled automatically when the mod loads.

## Help

* **Mod not loading?** Verify BepInEx is installed correctly and check the BepInEx console for errors
* **Option missing?** Confirm the mod loaded successfully and that you are looking at the multiplayer lobby distance setting

## Authors

- Sparroh

## License

This project is licensed under the MIT License - see the LICENSE file for details
