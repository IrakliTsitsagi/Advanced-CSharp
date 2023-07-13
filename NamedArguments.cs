namespace NamedArguments
{
    internal class NamedArguments
    {
        static void Main(string[] args)
        {
            DisplayPlayerInfo(country: "Georgia", name: "Khvicha", goals: 90, no: 77);
        }

        public static void DisplayPlayerInfo(int no, string name, int goals, string country = "Unknown")
        {
            Console.WriteLine(no);
            Console.WriteLine(name);
            Console.WriteLine(goals);
            Console.WriteLine(country);
            Console.WriteLine();
        }
    }
}
