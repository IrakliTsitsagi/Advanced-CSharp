namespace TuplesWithMethods
{
    internal class TuplesWithMethods
    {
        static void Main(string[] args)
        {
            var damajor = Tuple.Create(27, "Damajor", "Didebulidze", "Gldani");
            DisplayInformation(damajor);
            Console.WriteLine();

            var Zviad = Tuple.Create(27, "Zviad", "Iakobidze", "Gori");
            DisplayInformation(Zviad);
            Console.WriteLine();
            Console.WriteLine(GetInformation().Item1);
            Console.WriteLine(GetInformation().Item2);
            Console.WriteLine(GetInformation().Item3);
            Console.WriteLine(GetInformation().Item4);
        }

        public static void DisplayInformation(Tuple<int, string, string, string> personInfo)
        {
            Console.WriteLine(personInfo.Item1);
            Console.WriteLine(personInfo.Item2);
            Console.WriteLine(personInfo.Item3);
            Console.WriteLine(personInfo.Item4);

        }

        public static Tuple<int, string, string, string> GetInformation()
        {
            var info = Tuple.Create(23, "CikLadol", "Shterlecki", "Gori");
            return info;
        }
    }
}