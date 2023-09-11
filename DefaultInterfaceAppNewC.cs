using System.Threading.Channels;

namespace DefaultInterfaceAppNewC
{
    internal class DefaultInterfaceAppNewC
    {
        static void Main(string[] args)
        {
            ICar F1 = new Ferrari();
            F1.Start();
            F1.Run();

            Ferrari Spider = new Ferrari();
            ((ICar)Spider).Run(200);
        }
    }

    class Ferrari : ICar
    {
        public void Run()
        {
            Console.WriteLine("Car is running");
        }
    }

    interface ICar
    {
        public void Start() => Console.WriteLine("Car has started!");

        public void Run();

        public void Run(double carSpeed) => Console.WriteLine($"Car is runing at {carSpeed} km/h");
    }
}