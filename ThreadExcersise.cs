using System.Threading.Channels;

namespace ThreadExcersise
{
    internal class ThreadExcersise
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(() => Console.WriteLine("Hello from Lambda")));
            t1.Start();
        }
    }
}