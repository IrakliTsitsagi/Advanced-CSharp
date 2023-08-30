namespace ReadonlyKeyword
{
    internal class ReadonlyKeyword
    {
        static void Main(string[] args)
        {
            Animals dog = new Animals("Dog");
            Console.WriteLine(dog.AnimalName);

            // ase shemidzlia shevcvalo dogis name
            dog = new Animals("Another dog");
            Console.WriteLine(dog.AnimalName);
        }
    }

    class Animals
    {
        readonly private string animalName;

        public string AnimalName
        {
            get => animalName;
        }

        public Animals(string name)
        {
            animalName = name;
        }
    }
}