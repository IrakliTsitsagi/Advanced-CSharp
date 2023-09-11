namespace AsyncStreamsAppNewC
{
    internal class AsyncStreamsAppNewC
    {
        static async Task Main(string[] args)
        {
            foreach (var prod in GetProducts())
            {
                Console.WriteLine(prod);
            }
            Console.WriteLine();
            await foreach (var prod in GetProductsAsync())
            {
                await Console.Out.WriteLineAsync(prod);
            }
        }

        static IEnumerable<string> GetProducts()
        {
            yield return "Getting Products...";
            yield return "Product 1";
            yield return "Product 2";
            yield return "Product 3";
        }

        static async IAsyncEnumerable<string> GetProductsAsync()
        {
            yield return "Getting Products...";
            await Task.Delay(1000);
            yield return "Product 1";
            await Task.Delay(1000);
            yield return "Product 2";
            await Task.Delay(1000);
            yield return "Product 3";
        }
    }
}