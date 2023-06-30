using System.Collections.Specialized;

namespace NameValueCollectionApp
{
    internal class NameValueCollectionApp
    {
        static void Main(string[] args)
        {
            // creating 

            NameValueCollection cities = new NameValueCollection();

            // adding

            cities.Add("Georgia", "Gori");
            cities.Add("Georgia", "Tbilisi");
            cities.Add("Georgia", "Kutaisi");
            cities.Add("Georgia", "Batumi");
            cities.Add("Georgia", "Khashuri");
            cities.Add("Turkey", "Ankara");
            cities.Add("Turkey", "Antalia");


            // displaying

            foreach (string item in cities)
            {
                Console.Write(item + ": ");
                Console.WriteLine(cities[item]);
            }

            // set

            cities.Set("Italy", "Venice");

            // contains

            Console.WriteLine(cities.HasKeys());

            // remove

            cities.Remove("Turkey");
            Console.WriteLine("after deleting");

            foreach (string item in cities)
            {
                Console.Write(item + ": ");
                Console.WriteLine(cities[item]);
            }
            // remove all
            // cities.Clear();
        }
    }
}