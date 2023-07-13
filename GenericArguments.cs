namespace GenericArguments
{
    internal class GenericArguments
    {
        static void Main(string[] args)
        {
            DisplayInfo("John");
            DisplayInfo(2);
            DisplayInfo(2.5);
            DisplayInfo(DateTime.Now);

            var playerInfo = (7, "ylekaca", 10);
            DisplayInfo(playerInfo);
        }

        // yvelaferze midis int string shmrint print T magaria
        public static void DisplayInfo<T>(T info)
        {
            Console.WriteLine(info);
        }
    }
}