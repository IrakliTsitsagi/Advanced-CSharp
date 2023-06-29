using System.Collections;

namespace GenericSortedList
{
    internal class GenericSortedList
    {
        static void Main(string[] args)
        {
            // creating

            SortedList list = new SortedList(); // non generic sortedlist
            SortedList<string, string> phoneBook = new SortedList<string, string>(); // generic sortedlist

            // adding

            phoneBook.Add("Irakla", "598617061");
            phoneBook.Add("Dama", "596111168");
            phoneBook.Add("Bako", "598252985");
            phoneBook.Add("Gorgasli", "577621021");

            // displaying

            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Key + ", the mobile no is " + item.Value);
            }

            // index

            phoneBook["Bako"] = "595585676";
            Console.WriteLine("Bako changed his number to " + phoneBook["Bako"]);

            // TryGetValue

            phoneBook.TryGetValue("Dama", out string number);
            Console.WriteLine(number);

            // remove
            Console.WriteLine("after removing");
            phoneBook.Remove("Bako");
            //  phoneBook.RemoveAt(1);
            foreach (var item in phoneBook)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(phoneBook.Count);

            // remove all

            //phoneBook.Clear();
            //Console.WriteLine();

            // contains

            Console.WriteLine(phoneBook.ContainsKey("Dama"));
            Console.WriteLine(phoneBook.ContainsValue("598617061"));
        }
    }
}