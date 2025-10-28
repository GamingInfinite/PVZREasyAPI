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

        [HarmonyPrefix]
        [HarmonyPatch(nameof(Board.DisposeBoard))]
        public static void OnBoardDispose()
        {
            PVZEasyAPI._cachedBoard = null;
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

        [HarmonyPostfix]
        [HarmonyPatch(nameof(Board.AddZombie))]
        public static void OnAddZombie(ref Zombie __result)
        {
            Events.OnAddZombie.Invoke(__result);
        }

        [HarmonyPostfix]
        [HarmonyPatch(nameof(Board.AddPlant))]
        public static void OnAddPlant(ref Plant __result)
        {
            Events.OnAddPlant.Invoke(__result);
        }
    }
}
