using System.Reflection.Metadata;

namespace AnonymousMethods
{
    delegate void DisplayInfo();
    delegate void DisplayInfoBasedOnNumber(int number);
    internal class AnonymousMethods
    {
        static void Main(string[] args)
        {
            DisplayInfo normalDelegate = new DisplayInfo(GetInformation);
            normalDelegate();

            DisplayInfoBasedOnNumber oneParamDelegate = new DisplayInfoBasedOnNumber(GetInformation);
            oneParamDelegate(200);

            Console.WriteLine("------------\n");

            DisplayInfo normalDelegateAnonymous = delegate { Console.WriteLine("Hi from the anonymous method"); };
            normalDelegateAnonymous();

            DisplayInfoBasedOnNumber oneParameterDelegateAnonymous = delegate (int number)
            {
                Console.WriteLine("Hi" +
                " from the anonymous method with one int parameter " + number);
            };
            oneParameterDelegateAnonymous(500);
        }

        public static void GetInformation()
        {
            // same logic goes in here
            Console.WriteLine("Delegate with no parameter");
        }

        public static void GetInformation(int x)
        {
            // same logic goes in here
            Console.WriteLine("Delegate with 1 parameter " + x);
        }
    }
}