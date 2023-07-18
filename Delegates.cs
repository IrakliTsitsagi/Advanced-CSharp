namespace Delegates
{
    // void delegate with no argument
    public delegate void PlayerInfoDel();

    // void delegate with one string argument
    public delegate void PlayerInfoWithNameDel(string playerName);

    // void delegate with one string and one int argument
    public delegate void PlayerInfoWithGoalsDel(string playerName, int goals);

    // void dekegate with one int argument
    public delegate string PlayerBasedOnNumber(int number);
    internal class Delegates
    {
        static void Main(string[] args)
        {
            PlayerInfoDel ronaldinho = new PlayerInfoDel(DisplayInformation);
            ronaldinho.Invoke();

            PlayerInfoWithNameDel playerName = new PlayerInfoWithNameDel(DisplayInformation);
            playerName("Messi");

            PlayerInfoWithGoalsDel newPlayer = new PlayerInfoWithGoalsDel(DisplayInformation);
            newPlayer("Ronaldoi", 60);

            PlayerBasedOnNumber number = new PlayerBasedOnNumber(DisplayInformation);
            Console.WriteLine(number(8));
            Console.WriteLine(number(7));
            Console.WriteLine(number(6));
        }

        public static void DisplayInformation()
        {
            Console.WriteLine("Information about player : Ronaldinho");
        }

        public static void DisplayInformation(string playerName)
        {
            Console.WriteLine("Information about player : " + playerName);
        }

        public static void DisplayInformation(string playerName, int goals)
        {
            Console.WriteLine("Information about player : " + playerName + " and he score " + goals);
        }

        public static string DisplayInformation(int number)
        {
            string playerName = string.Empty;
            switch (number)
            {
                case 7: playerName = "Kvara"; break;
                case 8: playerName = "Gerrard"; break;
                case 10: playerName = "Messi"; break;
                default: break;
            }
            return playerName;
        }
    }
}