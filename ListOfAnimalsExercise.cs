namespace ListOfAnimalsExercise
{
    internal class ListOfAnimalsExercise
    {
        static void Main(string[] args)
        {
            Animals dog = new Animals();
            dog.Name = "Iriska";

            Animals cat = new Animals();
            cat.Name = "Miako";

            Animals elephant = new Animals();
            elephant.Name = "Fofy";

            List<Animals> list = new List<Animals>();
            list.Add(dog);
            list.Add(cat);
            list.Add(elephant);

            foreach (var item in list)
            {
                item.SayHi();
                item.Feed();
            }
        }
    }

    class Animals
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("Hello my name is " + name);
        }

        public void Feed()
        {
            Console.WriteLine(name + " is now eating");
        }
    }
}