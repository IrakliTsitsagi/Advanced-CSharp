namespace IEnumerableApp
{
    internal class IEnumerableApp
    {
        static void Main(string[] args)
        {
            IEnumerable<int> result = from value in Enumerable.Range(1, 10)
                                      select value;

            foreach (int value in result)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            double avg = result.Average();
            Console.WriteLine(avg);

            List<int> list = result.ToList();
            int[] array = result.ToArray();

            list.Add(11);
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Add(15);
            Console.WriteLine("What is in the list now");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            result = list.AsEnumerable(); // amis gareshe ienumerable 10 mde iqneboda iseva
            Console.WriteLine("What is in the ienumerable now");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");

            IEnumerator<int> enumerator = list.GetEnumerator();

            while (enumerator.MoveNext()) // foreach uarze iyo da viyenebt whiles
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}