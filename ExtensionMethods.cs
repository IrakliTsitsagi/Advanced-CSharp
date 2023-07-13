namespace ExtensionMethods
{
    internal class ExtensionMethods
    {
        static void Main(string[] args)
        {
            int x = 90;
            Console.WriteLine(x.IsGreater(50));

            string text = "Ahmad";
            Console.WriteLine(text.IsNumber()); // tu ricxvebs chavwer textshi true tu asoebs false
        }
    }

    // aucilebelia statikuri klasi
    static class MyCustomExtension
    {
        public static bool IsGreater(this int value, int number)
        {
            return value > number;
        }

        public static bool IsNumber(this string text)
        {
            return int.TryParse(text, out int result);
        }
    }
}