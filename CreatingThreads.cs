using System.Threading;

namespace CreatingThreads
{
    internal class CreatingThreads
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(SayHiEnglish));
            t1.Name = "thread number 1 (English)";
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(SayHiSpanish));
            t2.Name = "thread number 2(Spanish)";
            t2.Start();
        }

        public static void SayHiEnglish()
        {
            Console.WriteLine("starting to execute " + Thread.CurrentThread.Name);
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i + "Hi");
            }
        }

        public static void SayHiSpanish()
        {
            Console.WriteLine("starting to execute " + Thread.CurrentThread.Name);
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i + "Hola");
            }
        }
    }
}