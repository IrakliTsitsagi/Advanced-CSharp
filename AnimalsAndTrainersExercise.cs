﻿using System.Collections;

namespace AnimalsAndTrainersExercise
{
    internal class AnimalsAndTrainersExercise
    {
        static void Main(string[] args)
        {
            Animals dog = new Animals();
            dog.Name = "Iriska";

            Animals cat = new Animals();
            cat.Name = "Miako";

            Animals elephant = new Animals();
            elephant.Name = "Fofy";

            Trainers john = new Trainers();
            john.TrainerName = "John Ghambashidze";

            ArrayList list = new ArrayList();
            list.Add(dog);
            list.Add(cat);
            list.Add(elephant);
            list.Add(john);

            foreach (var item in list)
            {
                if (typeof(Animals) == item.GetType())
                {
                    ((Animals)item).SayHi();
                    ((Animals)item).Feed();
                }
                else
                {
                    ((Trainers)item).SayHi();
                }
            }
        }

        struct Animals
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

        struct Trainers
        {
            private string trainerName;

            public string TrainerName
            {
                get { return trainerName; }
                set { trainerName = value; }
            }

            public void SayHi()
            {
                Console.WriteLine("Hello I'm the trainer " + trainerName);
            }
        }
    }
}