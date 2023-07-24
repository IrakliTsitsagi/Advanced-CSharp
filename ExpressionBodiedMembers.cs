using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace ExpressionBodiedMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddTwoNumbersFaster(5, 10));
            SayHi();
            Animals dog = new Animals();
            dog.Name = "Iriska";
            Console.WriteLine(dog.Name);
        }

        public static void SayHi() => Console.WriteLine("Welcome back");

        public static int AddTwoNumbersFaster(int x, int y) => x + y;

        public static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }
    }

    class Animals
    {
        // esec mokle constructori
        public Animals() => Console.WriteLine("A new animal");

        // propful + tabs
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        // ager es ufro moklea vidre age rogorc maqvs
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

    }
}