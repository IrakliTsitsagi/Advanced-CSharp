using System.Security.Cryptography;

namespace GenericDelegates
{
    public delegate T DisplayInfo<T>(T value);
    internal class GenericDelegates
    {
        static void Main(string[] args)
        {
            DisplayInfo<int> myNumber = new DisplayInfo<int>(DisplayValue);
            Console.WriteLine(myNumber(100));

            DisplayInfo<double> myDoubleNumber = new DisplayInfo<double>(DisplayValue);
            Console.WriteLine(myDoubleNumber(3.5));

            DisplayInfo<DateTime> myDate = new DisplayInfo<DateTime>(DisplayValue);
            Console.WriteLine(myDate(new DateTime(2010, 2, 28)));
        }

        public static T DisplayValue<T>(T value)
        {
            Console.WriteLine("Now we are accessing variable of type " + value.GetType().Name);
            return value;
        }
    }
}