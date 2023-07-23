namespace LambdaWithGenericList
{
    internal class LambdaWithGenericList
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(5); list.Add(8); list.Add(6); list.Add(15);
            list.Add(7); list.Add(2); list.Add(1); list.Add(12);

            var oddlist = list.Where(n => n % 2 != 0).ToList();
            var evenlist = list.Where(n => n % 2 == 0).ToList();

            Console.WriteLine("Odd numbers");
            foreach (var item in oddlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Even numbers");
            foreach (var item in evenlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}