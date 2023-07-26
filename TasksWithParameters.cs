namespace TasksWithParameters
{
    internal class TasksWithParameters
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(new Action<object>(SayHi), "Zaza");
            task1.Start();

            Task task2 = new Task(delegate (object name)
            {
                Console.WriteLine("Welcome back " + name);
            }, "Dejan");
            task2.Start();

            Task task3 = new Task(name => { Console.WriteLine("Welcome back " + name); }, "Gubaz");
            task3.Start();

            Console.ReadLine();
        }

        public static void SayHi(object name)
        {
            Console.WriteLine("Welcome back " + name);
        }
    }
}