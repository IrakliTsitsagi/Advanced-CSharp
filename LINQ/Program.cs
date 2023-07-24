using System.Net.Cache;

namespace LINQMethodSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filteredList = new List<Employees>();
            var listOfEmployees = new List<Employees>
            {
                new Employees { Id = 1,FirstName = "Jeki", LastName = "Begura", Salary = 5000m, Age = 35, Appraisal = new List<int>{7,7,8} },
                new Employees { Id = 1,FirstName = "Dejan", LastName = "Stankovichi", Salary = 10000m, Age = 44, Appraisal = new List<int>{9,8,7} },
            };

            Employees.DisplayWithApparisal(listOfEmployees, "All Employees");

            // LINQ metodi
            //  IEnumerable<Employees> list = listOfEmployees.Where(e => e.Salary >= 6000 && e.Age > 40); // esec mojna
            filteredList = listOfEmployees.Where(e => e.Salary >= 6000 && e.Age > 40).ToList();


            // esaa dzveli metodit
            //foreach (var employee in listOfEmployees)
            //{
            //    if (employee.Salary >= 6000 && employee.Age >= 40)
            //        Console.WriteLine(employee.FirstName);
            //}
            foreach (var employee in filteredList)
            {
                Console.WriteLine(employee.FirstName);
            }
            Console.WriteLine();
        }
    }
}