using System.Data;
using System.Timers;
using Timer = System.Timers.Timer;

namespace TimerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Elapsed += Timer_Elapsed;
            timer.Interval = 3000;
            timer.Enabled = true;

            Console.WriteLine("Press x to exit");
            while (Console.Read() != 'x') ;
        }

        private static void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Yes it is working " + DateTime.Now.ToLongTimeString());
        }
    }
}