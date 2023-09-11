namespace UsingDeclarationAppNewC
{
    internal class UsingDeclarationAppNewC
    {
        class Resource : IDisposable
        {
            public void Use() => Console.WriteLine("Using resource...");
            public void Dispose() => Console.WriteLine("Disposing resource...");
        }
        static void Main(string[] args)
        {
            //var resourse = new Resource();
            //resourse.Use();
            //Console.WriteLine("\nThis app is awesome");
            //resourse.Dispose();

            // better version
            // using var resource = new Resource();
            //resource.Use();
            //Console.WriteLine("\nThis app is awesome");

            // and also better version but different
            using (var resource = new Resource())
            {
                resource.Use();
            }
            Console.WriteLine("\nThis app is awesome");
        }
    }
}