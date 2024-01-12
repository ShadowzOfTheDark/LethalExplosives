using BepInEx;

namespace ImprovisedExplosiveDevices
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, "Lethal Explosives", "1.0.0")]
    [BepInProcess("Lethal Company.exe")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
    }
}
