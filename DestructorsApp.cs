using System;
namespace DestructorsApp
{
    internal class DestructorsApp
    {
        static void Main(string[] args)
        {
            Animals dog = new Animals();

            var name = Console.ReadLine();

        }
    }

    class Animals
    {
        public Animals()
        {
            Console.WriteLine("a new animal is created");
        }

        // destructor eshveba roca programa about to dasruldes
        ~Animals()
        {
            Console.WriteLine("animals object is about to be destroyed");
        }
    }
}