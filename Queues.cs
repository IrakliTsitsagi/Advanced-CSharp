using System.Collections;

namespace Queues
{
    internal class Queues
    {
        static void Main(string[] args)
        {
           // pirveli shedis pirveli gamodis

            // creating
            Queue queue = new Queue();


            // adding
            queue.Enqueue("Davita");
            queue.Enqueue("Dama");
            queue.Enqueue("Sensei");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // removing
            Console.WriteLine("----------");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}