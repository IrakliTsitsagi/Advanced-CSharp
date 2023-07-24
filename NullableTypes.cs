namespace NullableTypes
{
    internal class NullableTypes
    {
        static void Main(string[] args)
        {
            // DateTime myDate = new DateTime();
            // Console.WriteLine(myDate);

            DateTime? myDate = null; // null ro mivanicho --> ? unda dasva iq
            Console.WriteLine(myDate);

            // int number = 0;
            int? number = null;
            Console.WriteLine(number);
            number = 5;

            int numberTwo = (int)number;
            numberTwo = 10;

            Console.WriteLine(number ?? numberTwo);

            string firstName = null;
            firstName = "John";

            string message = null;
            message = "first name is null";

            Console.WriteLine(firstName ?? message);
        }
    }
}