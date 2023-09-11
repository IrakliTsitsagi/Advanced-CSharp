namespace DisposableRefStructsNewC
{
    internal class DisposableRefStructsNewC
    {
        static void Main(string[] args)
        {
            using (var car = new Car())
            {
                Console.WriteLine("My car is very cool");
            }
        }
    }

    // ese erors agdebs
    //ref struct Car : IDisposable
    //{

    //}
    // davfixet usingis mainshi gamoyenebita
    ref struct Car
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose Method is Called");
        }
    }
}