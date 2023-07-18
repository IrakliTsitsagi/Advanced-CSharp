using System.Diagnostics;

namespace StopWatchApp
{
    internal class StopWatchApp
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Loop(200_000_000);
            watch.Stop();

            Console.WriteLine("Milliseconds " + watch.Elapsed.Milliseconds);
            Console.WriteLine("ToTal Milliseconds " + watch.Elapsed.TotalMilliseconds);
            Console.WriteLine("Seconds " + watch.Elapsed.Seconds);
            Console.WriteLine("Total seconds " + watch.Elapsed.TotalSeconds);
            Console.WriteLine("Ticks " + watch.Elapsed.Ticks);
        }

        public static void Loop(long number)
        {
            for (long i = 0; i < number; i++)
            {

            }
            Console.WriteLine("Process done.");
        }
    }
}