﻿using System.Collections.Concurrent;
using System.Threading;
namespace ConcurrentBagApp
{
    internal class ConcurrentBagApp
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            Thread t1 = new Thread(() =>
            {
                Console.WriteLine("Thread 1 has started");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Thread 1 added number " + i);
                    bag.Add(i);
                }
                Console.WriteLine("Thread 1 is complete");
            });

            Thread t2 = new Thread(() =>
            {
                Console.WriteLine("Thread 2 has started");
                for (int i = 11; i < 25; i++)
                {
                    Console.WriteLine("Thread 2 added number " + i);
                    bag.Add(i);
                }
                Console.WriteLine("Thread 2 is complete");
            });

            Thread t3 = new Thread(() =>
            {
                t1.Join();
                t2.Join();
                Console.WriteLine("Thread 3 has started");
                foreach (var item in bag)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Thread 3 is complete");
            });

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}