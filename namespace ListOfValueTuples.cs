namespace ListOfValueTuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfPlayers = new List<(int playerNo, string playerName, int playerGoals)>();

            listOfPlayers.Add((7, "Penaldo", 0));
            listOfPlayers.Add((10, "Messi", 60));
            listOfPlayers.Add((77, "Kvara", 999));
            listOfPlayers.Add((8, "Gerrard", 80));

            foreach (var player in listOfPlayers)
            {
                Console.WriteLine($"{player.playerNo} - {player.playerName} - {player.playerGoals}");
                Console.WriteLine();
            }

            listOfPlayers.Sort();

            foreach (var player in listOfPlayers)
            {
                Console.WriteLine($"{player.playerNo} - {player.playerName} - {player.playerGoals}");
                Console.WriteLine();
            }
        }
    }
}