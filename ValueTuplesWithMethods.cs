namespace ValueTuplesWithMethods
{
    internal class ValueTuplesWithMethods
    {
        static void Main(string[] args)
        {
            var penaldo = (7, "Penaldo", 60);
            var messi = (10, "Messi", 69);

            DisplayPlayerInfo(penaldo);
            DisplayPlayerInfo(messi);

            DisplayPlayerInfo(DisplayPlayerInfo());
        }

        public static void DisplayPlayerInfo((int playerNo, string playerName, int playerGoal) player)
        {
            Console.WriteLine(player.playerNo);
            Console.WriteLine(player.playerName);
            Console.WriteLine(player.playerGoal);
            Console.WriteLine();
        }

        public static (int, string, int) DisplayPlayerInfo()
        {
            var gerrard = (10, "Gerrard", 65);
            return gerrard;
        }
    }
}