namespace PatternMatchingApp
{
    internal class PatternMatchingApp
    {
        static void Main(string[] args)
        {
            Dog iriska = new Dog();
            iriska.DogName = "Iriska";
            Cat kato = new Cat();
            Duck kvato = new Duck();

            AnimalSound(iriska);
            AnimalSound(kato);
            AnimalSound(kvato);
        }

        // using IS
        public static void AnimalSound(object animal)
        {
            if (animal is Dog)
                Console.WriteLine("Woof");
            if (animal is Cat)
                Console.WriteLine("Meow");
            if (animal is Duck)
                Console.WriteLine("Quack");
        }

        // using SWITCH
        public static void AnimalSoundWithSwitch(object animal)
        {
            switch (animal)
            {
                case Dog d: Console.WriteLine("woof"); break;
                case Cat d: Console.WriteLine("miau"); break;
                case Duck d: Console.WriteLine("yiyiyi"); break;
                default:
                    Console.WriteLine("xz"); break;
            }
        }
        // using SWITCH and WHEN

        public static void AnimalSoundWithSwitchAndWhen(object animal)
        {
            switch (animal)
            {
                case Dog d when d.DogName == null: Console.WriteLine("name is not set"); break;

            }
        }
    }

    class Dog
    {
        public string DogSound { get; set; }
        public string DogName { get; set; }
    }

    class Cat
    {
        public string CatSound { get; set; }
        public string CatName { get; set; }
    }

    class Duck
    {
        public string DuckSound { get; set; }
        public string DuckName { get; set; }
    }
}