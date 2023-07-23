namespace ActionDelegate
{
    internal class ActionDelegate
    {
        static void Main(string[] args)
        {
            // generic
            Action<int> actionOne = DisplayInformation;
            actionOne(16);

            // non generic
            Action actionTwo = DisplayInformation;
            actionTwo();
        }

        public static void DisplayInformation(int number)
        {
            Console.WriteLine("Dejana aris am nomrit " + number);
        }

        public static void DisplayInformation()
        {
            Console.WriteLine("Mgelkaca");
        }
    }
}