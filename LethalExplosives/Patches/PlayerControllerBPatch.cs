using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNetcodeStuff;
using HarmonyLib;

namespace LethalExplosives.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    class PlayerControllerBPatch
    {
        [HarmonyPatch("LateUpdate")]
        [HarmonyPostfix]
        static void testSprintPatch(ref float ___sprintMeter)
        {
            ___sprintMeter = 1f;
        }
    }
}
