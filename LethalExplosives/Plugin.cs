using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using LethalExplosives.Patches;

namespace LethalExplosives
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class LethalExplosivesBase : BaseUnityPlugin
    {
        private const string modGUID = "com.github.ShadowzOfTheDark.LethalExplosives";
        private const string modName = "Lethal Explosives";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static LethalExplosivesBase Instance;

        internal ManualLogSource mls;

        void Awake() 
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("Lethal Explosives awake.");

            harmony.PatchAll(typeof(PlayerControllerBPatch));
        }

    }
}
