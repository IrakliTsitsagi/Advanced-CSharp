namespace OptionalArguments
{
    internal class OptionalArguments
    {
        static void Main(string[] args)
        {
            DisplayPlayerInfo(77, "Kvaratskhelia", 90, "Georgia", "Napoli");
            DisplayPlayerInfo(10, "Messi", 89, "Argentina");
            DisplayPlayerInfo(11, "Nkunku", 10); // country ze unknown dawers clubze arafers
        }

        public static void DisplayPlayerInfo(int no, string name, int goals, string country = "Unknown", string club = "")
        {
            Console.WriteLine("Hi from the first method");
            Console.WriteLine(no);
            Console.WriteLine(name);
            Console.WriteLine(goals);
            Console.WriteLine(country);
            Console.WriteLine(club);
            Console.WriteLine();
        }

        public static void DisplayPlayerInfo(int no, string name, int goals)
        {
            Console.WriteLine("Hi from the overloaded method");
            Console.WriteLine(no);
            Console.WriteLine(name);
            Console.WriteLine(goals);
            Console.WriteLine();
        }
    }
}