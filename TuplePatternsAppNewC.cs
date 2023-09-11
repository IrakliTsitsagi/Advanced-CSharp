namespace TuplePatternsAppNewC
{
    internal class TuplePatternsAppNewC
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckPrices("Vienna", "Austria"));
            Console.WriteLine(CheckPrices("Paris", "France"));
            Console.WriteLine(CheckPrices("Paris", "USA"));

            Console.WriteLine(CheckPrices("Vienna", "Austria", "German"));
        }

        public static string CheckPrices(string city, string country, string language) =>
            (city, country, language) switch
            {
                ("Vienna", "Austria", "German") => "Above average",
                ("Paris", "France", "French") => "Very High",
                ("Paris", "USA", "English") => "Average",
                (_, _, _) => " no info"
            };

        public static string CheckPrices(string city, string country) =>
            (city, country) switch
            {
                ("Vienna", "Austria") => "Above Average",
                ("Paris", "France") => "Very High",
                ("Paris", "USA") => "Average",
                (_, _) => " no info"
            };
    }
}