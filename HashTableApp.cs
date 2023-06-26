using System.Collections;

namespace HashTableApp
{
    internal class HashTableApp
    {
        static void Main(string[] args)
        {
            // creating
            Hashtable hash = new Hashtable();

            // adding
            hash.Add("Microsoft", "USA");
            hash.Add("Sony", "Japan");
            hash.Add("IKEA", "Sweden");
            hash.Add("Mercedes", "Germany");

            // displaying
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            // capacity
            Console.WriteLine("Count is " + hash.Count);

            // remove
            hash.Remove("Microsoft");
            Console.WriteLine("after removing");
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            // contains 
            Console.WriteLine("-------");
            Console.WriteLine("contains condition");
            if (hash.Contains("Sony")) // hash.ContainsValue vwer ro qveyanaze vkitxo
            {
                Console.WriteLine("Yes it contains it");
            }
            else
            {
                Console.WriteLine("no it does not have it");
            }

            // copy to array list
            Console.WriteLine("-------");
            Console.WriteLine("after copying");
            ArrayList array = new ArrayList(hash.Values); // hash.Keys rom kompaniebi daweros. values qveynebs miwers
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}