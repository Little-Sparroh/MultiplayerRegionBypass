using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

[BepInPlugin(PluginGUID, PluginName, PluginVersion)]
[MycoMod(null, ModFlags.IsClientSide)]
public class MultiplayerRegionBypassPlugin : BaseUnityPlugin
{
    public const string PluginGUID = "sparroh.multiplayerregionbypass";
    public const string PluginName = "MultiplayerRegionBypass";
    public const string PluginVersion = "1.1.0";

    internal static new ManualLogSource Logger;

    private void Awake()
    {
        Logger = base.Logger;

        try
        {
            var harmony = new Harmony(PluginGUID);
            harmony.PatchAll(typeof(RegionBypassPatches));
        }
        catch (System.Exception ex)
        {
            Logger.LogError($"Error applying patches: {ex.Message}");
            return;
        }

        Logger.LogInfo($"{PluginName} loaded successfully.");
    }
}
