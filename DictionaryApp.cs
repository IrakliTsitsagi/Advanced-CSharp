namespace DictionaryApp
{
    internal class DictionaryApp
    {
        static void Main(string[] args)
        {
            // creating

            Dictionary<string, string> capitals = new Dictionary<string, string>();

            // creating with initialization

            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                {1, "Dejana" },
                {2, "Kaxa" },
                {3, "Jenaro" }
            };
            foreach (var item in names)
            {
                Console.WriteLine(item.Value);
            }

            // add

            capitals.Add("Georgia", "Tbilisi");
            capitals.Add("Armenia", "Erevan");
            capitals.Add("Azerbaijan", "Baku");
            capitals.Add("Turkey", "Ankara");
            capitals.Add("Russia", "Moscow");




            // displaying
            Console.WriteLine("------");
            // foreachit
            foreach (var item in capitals)
            {
                // key qveyanas achvenebs value dedaqalaqs arcerts tu ar chawer orives achvenebs
                Console.WriteLine(item.Value); // aq ginda keys chawer ginda arafers gaachnia ra ginda        
            }

            // forit
            // for (int i = 0; i < capitals.Count; i++)
            // {
            //Console.WriteLine(capitals.Keys.ElementAt(i)); //aqac igive key value an arcerts chawer
            // Console.WriteLine(capitals[capitals.Keys.ElementAt(i)]); // asec xdeba
            // }

            // index
            Console.WriteLine("-----------");
            capitals["Russia"] = "Tbilisi"; // davipyrot ruseti
            Console.WriteLine(capitals["Russia"]);

            // capacity



            // try get value

            capitals.TryGetValue("Turkey", out string result);
            if (result != null)
                Console.WriteLine("result is " + result);

            // remove

            capitals.Remove("Russia");
            Console.WriteLine("-------");
            for (int i = 0; i < capitals.Count; i++)
            {
                Console.WriteLine(capitals[capitals.Keys.ElementAt(i)]);
            }

            // remove all
            // capitals.Clear();

            // contains
            Console.WriteLine("---------");
            Console.WriteLine(capitals.ContainsKey("Georgia"));
        }
    }
}