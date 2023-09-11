namespace IndexOperatorNewC
{
    internal class IndexOperatorNewC
    {
        static void Main(string[] args)
        {
            var cities = new string[]
            {
                "New York", // 0 - 5
                "Vienna",   // 1- 4
                "Madrid",   // 2 - 3
                "London",   // 3 - 2
                "Cairo"    // 4- 1
            };

            Console.WriteLine(cities[cities.Length - 1]);
            Console.WriteLine(cities[^1]); // same but different aq qvemodan zemot itvvleba
            Console.WriteLine(cities[^2]); // london

            List<int> numbers = new List<int>();
            numbers.Add(0);
            numbers.Add(1); // amas dabechdavs
            numbers.Add(4);
            numbers.Add(5);

            Console.WriteLine(numbers[^3]); // 1

        }
    }
}