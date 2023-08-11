namespace Indexers
{
    internal class Indexers
    {
        static void Main(string[] args)
        {
            Animals animals = new Animals();

            animals[0] = "Dog";
            animals[1] = "Cat";
            animals[2] = "Tiger";

            Console.WriteLine(animals[1]);
        }
    }

    class Animals
    {
        private string[] name = new string[100];

        public string this[int index]
        {
            get { return name[index]; }
            set { name[index] = value; }
        }
    }
}