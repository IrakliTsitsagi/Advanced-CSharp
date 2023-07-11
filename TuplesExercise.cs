namespace TuplesExercise
{
    internal class TuplesExercise
    {
        static void Main(string[] args)
        {
            var employeesInformation = new List<Tuple<int, string, string, DateTime>>();
            // gza 1
            employeesInformation.Add(new Tuple<int, string, string, DateTime>(3, "Dama", "Didebulidze", new DateTime(2017, 11, 25)));
            // gza 2
            employeesInformation.Add(Tuple.Create(1, "Guja", "Butxuzi", new DateTime(2015, 01, 01)));
            employeesInformation.Add(Tuple.Create(4, "Nodar", "Inauri", new DateTime(2015, 01, 02)));
            employeesInformation.Add(Tuple.Create(2, "Joyola", "Demurishvili", new DateTime(2015, 01, 09)));

            foreach (var employee in employeesInformation)
            {
                Console.WriteLine($"{employee.Item1}, {employee.Item2}, {employee.Item3}, {employee.Item4}");
            }
            Console.WriteLine();

            employeesInformation.Sort();
            foreach (var employee in employeesInformation)
            {
                Console.WriteLine($"{employee.Item1}, {employee.Item2}, {employee.Item3}, {employee.Item4}");
            }
            Console.WriteLine();

            employeesInformation.Reverse();
            foreach (var employee in employeesInformation)
            {
                Console.WriteLine($"{employee.Item1}, {employee.Item2}, {employee.Item3}, {employee.Item4}");
            }
        }
    }
}