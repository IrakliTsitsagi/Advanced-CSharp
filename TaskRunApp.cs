namespace TaskRunApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task.Run(() =>
            //{
            //    Console.WriteLine("Hi from task");
            //}); // amas marjvena knopka da natura extract method izavs amas
            SayHiTask();

            AddNumbersTask(1, 2, 12);

            Console.ReadLine();
        }

        private static Task SayHiTask()
        {
            return Task.Run(() =>
              {
                  Console.WriteLine("Hi from task");
              });
        }

        public static Task AddNumbersTask(params int[] numbers)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Add numbers task started");
                int result = 0;
                foreach (var number in numbers)
                {
                    result += number;
                }
                Console.WriteLine("Total " + result);
            });
        }
    }
}