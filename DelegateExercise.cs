namespace DelegateExercise
{
    public delegate void DisplayPlayer(Dictionary<int, string> players);
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <int,string> listOfPlayers = new Dictionary<int, string> ();
            listOfPlayers.Add(7, "Penaldo");
            listOfPlayers.Add(10, "Messi");
            listOfPlayers.Add(77, "Kvara");

            DisplayPlayer player = new DisplayPlayer(DisplayPlayerInfo);
            player(listOfPlayers);
          
        }

        public static void DisplayPlayerInfo(Dictionary<int,string> players)
        {
            foreach (var player in players)
            {
                Console.WriteLine($"Player no : {player.Key}, Player name : {player.Value}"); ;
            }
        }
    }
}