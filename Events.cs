using Il2CppReloaded.Gameplay;

namespace PVZREasyAPI
{
    public class Events
    {
        public static Action<Board> OnBoardUpdate = (board) => { };
        public static Action<Board> OnBoardStart = (board) => { };
        public static Action<Coin> OnAddCoin = (coin) => { };
    }
}
