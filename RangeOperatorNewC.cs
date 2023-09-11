namespace RangeOperatorNewC
{
    internal class RangeOperatorNewC
    {
        static void Main(string[] args)
        {
            var cities = new string[] {
                "New York", // 0 - 5
                "Vienna",   // 1- 4
                "Madrid",   // 2 - 3
                "London",   // 3 - 2
                "Cairo"    // 4- 1
            };

            // var copyCities = cities[0..5];
            // var copyCities = cities[^5..^0];
            var copyCities = cities[..];

            foreach (var city in copyCities)
            {
                Console.WriteLine(city);
            }

            Range cityRange = 0..5;
            Console.WriteLine(cityRange.Start);
            Console.WriteLine(cityRange.End);

            var newCities = cities[cityRange];
            foreach (var city in newCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}