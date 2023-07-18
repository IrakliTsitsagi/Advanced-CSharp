using System.Diagnostics;

namespace DelegatesVsDirectMethodCalls
{
    public delegate void DoSomethingDelegate();
    internal class DelegatesVsDirectMethodCalls
    {
        static void Main(string[] args)
        {
            Stopwatch watchOne = new Stopwatch();
            Stopwatch watchTwo = new Stopwatch();
            DoSomethingDelegate taskOne = new DoSomethingDelegate(DoSomething);

            // using delegates
            Console.WriteLine("delegates method\n ---------------");
            watchOne.Start();
            taskOne();
            watchOne.Stop();
            var elapsedOne = watchOne.Elapsed;
            Console.WriteLine(Math.Round(elapsedOne.TotalSeconds, 2));


            // using direct calls 
            Console.WriteLine("\nDirect method\n ---------------");
            watchTwo.Start();
            DoSomething();
            watchTwo.Stop();
            var elapsedTwo = watchOne.Elapsed;
            Console.WriteLine(Math.Round(elapsedTwo.TotalSeconds, 2));

            Console.WriteLine("\nDelegates saved you " + Math.Round(elapsedTwo.TotalMilliseconds - elapsedOne.TotalMilliseconds, 4) + " Milliseconds");
            Console.WriteLine("\nDelegates saved you " + Math.Round(elapsedTwo.TotalSeconds - elapsedOne.TotalSeconds, 4) + " Seconds");

        }

        public static void DoSomething()
        {
            double number = 8.54321;
            List<double> list = new List<double>();
            for (double i = 0; i < 60_000_000; i++)
            {
                number += i + DateTime.Now.Second;
                list.Add(number);
            }
            list.Reverse();
        }
    }
}