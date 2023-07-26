using System.Runtime.Serialization;

namespace ThreadExcersise2
{
    internal class ThreadExcersise2
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(delegate ()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Hello from anonymous assigned to t1");
                }
            }));
            t1.Start();
        }
    }
}