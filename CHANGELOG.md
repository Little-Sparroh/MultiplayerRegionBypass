# Changelog

## 1.1.0
- Initial release
- Unlocks the Worldwide multiplayer lobby distance option

1.0.0 (2025-08-19)
Added

    Region bypass functionality - forces server browser to show lobbies worldwide instead of regional only
    Harmony patch on PlayerOptions.TryGetConfig<float> to force LobbyDistance setting to worldwide filter
    Logging for confirmation when bypass is applied

Tech

    Initial mod template setup with BepInEx framework
    Add MinVer for version management
    Add thunderstore.toml configuration for mod publishing
    Add LICENSE.md and CHANGELOG.md template files
    Basic plugin structure with HarmonyLib integration
