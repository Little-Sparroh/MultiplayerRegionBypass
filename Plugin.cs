using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

[BepInPlugin(PluginGUID, PluginName, PluginVersion)]
[MycoMod(null, ModFlags.IsClientSide)]
public class RegionBypassPlugin : BaseUnityPlugin
{
    public const string PluginGUID = "sparroh.regionbypass";
    public const string PluginName = "RegionBypass";
    public const string PluginVersion = "1.0.0";

    internal static new ManualLogSource Logger;

    private void Awake()
    {
        Logger = base.Logger;
        var harmony = new Harmony(PluginGUID);

        var tryGetConfigMethod = AccessTools.Method(typeof(PlayerOptions), "TryGetConfig", generics: new[] { typeof(float) });
        if (tryGetConfigMethod != null)
        {
            harmony.Patch(tryGetConfigMethod, new HarmonyMethod(AccessTools.Method(typeof(RegionBypassPlugin), "TryGetConfigFloatPrefix")));
        }

        Logger.LogInfo($"{PluginName} loaded successfully.");
    }

    private static bool TryGetConfigFloatPrefix(ref string key, ref float value, ref bool __result)
    {
        if (key == "LobbyDistance")
        {
            value = 3.0f;
            __result = true;
            Logger.LogInfo("Forced LobbyDistance to 3 (Worldwide)");
            return false;
        }
        return true;
    }
}
