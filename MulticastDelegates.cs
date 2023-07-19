namespace MulticastDelegates
{
    public delegate void SayHiDelegate();
    internal class MulticastDelegates
    {
        static void Main(string[] args)
        {
            SayHiDelegate sayHi = null;

            sayHi = new SayHiDelegate(SayHiEnglish);
            sayHi += new SayHiDelegate(SayHiGeorgian);
            sayHi += new SayHiDelegate(SayHiSpanish);

            sayHi();
        }

        // say hi in English
        public static void SayHiEnglish()
        {
            Console.WriteLine("Hello");
        }


        // say hi in English
        public static void SayHiGeorgian()
        {
            Console.WriteLine("Gamarjoba");
        }


        // say hi in English
        public static void SayHiSpanish()
        {
            Console.WriteLine("Hola");
        }
    }
}