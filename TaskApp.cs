namespace TaskApp
{
    internal class TaskApp
    {
        static void Main(string[] args)
        {
            Task task = new Task(new Action(SayHi));
            task.Start();

            Task task2 = new Task(delegate ()
            {
                Console.WriteLine("Task2 is starting");
                Console.WriteLine("Task2 is running");
                Console.WriteLine("Hi there from task 2");
                Thread.Sleep(4000);
                Console.WriteLine("Task2 is complete");
            });
            task2.Start();

            Task task3 = new Task(() =>
            {
                Console.WriteLine("Task3 is starting");
                Console.WriteLine("Task3 is running");
                Console.WriteLine("Hi there from task 3");
                Thread.Sleep(5000);
                Console.WriteLine("Task3 is complete");
            });
            task3.Start();

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Welcome back " + name);

            Console.ReadLine();
        }

        public static void SayHi()
        {
            Console.WriteLine("Task is starting");
            Console.WriteLine("Task is running");
            Console.WriteLine("Hi there");
            Thread.Sleep(2000);
            Console.WriteLine("Task is complete");
        }
    }
}