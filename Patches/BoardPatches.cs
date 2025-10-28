using HarmonyLib;
using Il2CppReloaded.Gameplay;

namespace PVZREasyAPI.Patches
{
    [HarmonyPatch(typeof(Board))]
    internal class BoardPatches
    {
        [HarmonyPostfix]
        [HarmonyPatch(nameof(Board.Update))]
        public static void OnBoardUpdate(Board __instance)
        {
            PVZEasyAPI._cachedBoard = __instance;
            Events.OnBoardUpdate.Invoke(__instance);
        }

        [HarmonyPostfix]
        [HarmonyPatch(nameof(Board.StartLevel))]
        public static void OnBoardStart(Board __instance)
        {
            Events.OnBoardStart.Invoke(__instance);
        }

        [HarmonyPostfix]
        [HarmonyPatch(nameof(Board.AddCoin))]
        public static void OnAddCoin(ref Coin __result)
        {
            Events.OnAddCoin.Invoke(__result);
        }
    }
}
