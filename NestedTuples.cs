namespace NestedTuples
{
    internal class NestedTuples
    {
        static void Main(string[] args)
        {
            var employeeInfo = new Tuple<int, string, string, string, string, string, string, Tuple<decimal, decimal, decimal, decimal, decimal>>
                (105, "James", "Watson", "", "", "", "", Tuple.Create(2000m, 3000m, 4000m, 5000m, 6000m));

            Console.WriteLine("Employee name is " + employeeInfo.Item2);
            Console.WriteLine("Last 5 salaries");
            Console.WriteLine(employeeInfo.Rest.Item1);
            Console.WriteLine(employeeInfo.Rest.Item2);
            Console.WriteLine(employeeInfo.Rest.Item3);
            Console.WriteLine(employeeInfo.Rest.Item4);
            Console.WriteLine(employeeInfo.Rest.Item5);
        }
    }
}