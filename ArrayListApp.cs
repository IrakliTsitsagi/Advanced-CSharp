using System.Collections;

namespace ArrayListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating
            ArrayList array = new ArrayList();

            //adding
            array.Add("Gorgasala");
            array.Add("Dama");
            array.Add("Irakla");
            array.Add("Davita");
            array.Add("Otara");
            
            //array.Add(3); smeebis shenaxvac sheidzleba mara sortirebas ver gauwev sxvadasxva tipebs
           // array.Add(4.5d);

            foreach (var item in array) // itemebia first second 3 da 4.5d
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");

            // insert new item
            array.Insert(2, "Anzora"); // 2 nishnavs adgils anu secondis mere daemateba
            
             foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            // index
            Console.WriteLine("---------");
            Console.WriteLine(array[0].ToString());

            //capacity
            Console.WriteLine("---------");
            Console.WriteLine("count is " + array.Count);

            // sorting
            array.Sort();
            Console.WriteLine("after sorting");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            // reversing
            //rom ar davsorto da ise davareverso chemi chawerili tanmimdevrobisas daareversebs ubralod

            Console.WriteLine("------");
            array.Reverse();
            Console.WriteLine("after reversing");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            // contains
            Console.WriteLine("------");
            Console.WriteLine("after asking if contains");
            Console.WriteLine(array.Contains("Otara")); // tu maqvs Otara true tuara false

            // removing
            Console.WriteLine("------");
            array.Remove("Anzora");
           // array.RemoveAt(0); es indeqsit washlaa
            Console.WriteLine("after removing");
            foreach (var item in array)
            {
                Console.WriteLine(item);

            }

            // remove all
            Console.WriteLine("------");
            Console.WriteLine("after clearing");
            //array.Clear(); esaa remove all ra
           array.RemoveRange(1, 3); //es am reinjshi shlis
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

           // get range
           ArrayList names = new ArrayList();
            names = array.GetRange(0, 2);
            Console.WriteLine("--------");
            Console.WriteLine("after getting rangee");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
