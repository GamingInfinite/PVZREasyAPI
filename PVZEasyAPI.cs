using Il2CppReloaded.Gameplay;
using Il2CppReloaded.Input;
using Il2CppReloaded.TreeStateActivities;
using MelonLoader;

[assembly: MelonInfo(typeof(PVZREasyAPI.PVZEasyAPI), "PVZREasyAPI", "1.0.0", "SamanthaUSR", null)]
[assembly: MelonGame("PopCap Games", "PvZ Replanted")]

namespace PVZREasyAPI
{
    public class PVZEasyAPI : MelonMod
    {
        public static Board _cachedBoard;

        public static Board Board
        {
            get
            {
                return _cachedBoard;
            }
        }

        public static GameplayActivity Activity
        {
            get
            {
                return Board.mApp;
            }
        }
        public static List<Plant> AllPlants
        {
            get
            {
                if (Board == null || Board.m_plants == null)
                {
                    return [];
                }

                List<Plant> plants = [];
                for (int i = 0; i < Board.m_plants.Count; i++)
                {
                    Plant plant = Board.m_plants[i];
                    plants.Add(plant);
                }

                return plants;
            }
        }
        public static List<Zombie> AllZombies
        {
            get
            {
                if (Board == null || Board.m_zombies == null)
                {
                    return [];
                }

                List<Zombie> zombies = [];
                for (int i = 0; i < Board.m_zombies.Count; i++)
                {
                    Zombie zombie = Board.m_zombies[i];
                    if (!zombie.mDead)
                    {
                        zombies.Add(zombie);
                    }
                }
                return zombies;
            }
        }
        public static List<Coin> AllCoins
        {
            get
            {
                if (Board == null || Board.m_coins == null)
                {
                    return [];
                }

                List<Coin> coins = [];

                for(int i = 0; i <= Board.m_coins.Count; i++)
                {
                    Coin coin = Board.m_coins[i];
                    coins.Add(coin);
                }

                return coins;
            }
        }

        public override void OnInitializeMelon()
        {
            HarmonyInstance.PatchAll();
        }
    }
}