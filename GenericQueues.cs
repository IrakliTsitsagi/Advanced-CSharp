namespace GenericQueues
{
    internal class GenericQueues
    {
        static void Main(string[] args)
        {
            Queue<DateTime> arrivals = new Queue<DateTime>();

            arrivals.Enqueue(new DateTime(2017, 01, 01));
            arrivals.Enqueue(new DateTime(2019, 10, 27));
            arrivals.Enqueue(new DateTime(2020, 06, 09));

            Console.WriteLine("at the top " + arrivals.Peek());
            Console.WriteLine("-------");

            foreach (var item in arrivals)
            {
                Console.WriteLine(item);
            }

            arrivals.Dequeue(); // pirvels amoagdebs es

            Console.WriteLine("at the top " + arrivals.Peek());
            Console.WriteLine("-------");
            foreach (var item in arrivals)
            {
                Console.WriteLine(item);
            }
        }
    }
}