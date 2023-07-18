namespace MoreAboutDelegates
{
    // void delegate with one string and one int argument
    public delegate void PlayerInfoWithGoals(string playerName, int goals);

    // string delegate with one int and one string argument
    public delegate string PlayerInfoGoalsClub(int playerNo, string club, string country = "Unknown");
    internal class MoreAboutDelegates
    {
        static void Main(string[] args)
        {
            PlayerInfoWithGoals playerOne = new PlayerInfoWithGoals(DisplayInformation);
            PlayerInfoGoalsClub playerTwo = new PlayerInfoGoalsClub(DisplayInformation);

            // playerOne("Ronaldo", 50);

            //  playerTwo(9, "Inter", "Brazil");
            Console.WriteLine(playerTwo.Method);

            foreach (var item in playerTwo.Method.GetParameters())
            {
                Console.WriteLine($"{item.ParameterType}, {item.Name}, {item.Position}, {item.IsOptional}, {item.DefaultValue}");
            }
        }

        public static void DisplayInformation(string playerName, int goals)
        {
            Console.WriteLine("Info about player : " + playerName + " " + goals);
        }

        public static string DisplayInformation(int number, string club, string country = "Unknown")
        {
            // same logic goes in here
            Console.WriteLine("Hi...");
            return string.Empty;
        }
    }
}