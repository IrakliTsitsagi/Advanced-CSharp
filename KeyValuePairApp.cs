using System.Threading.Channels;

namespace KeyValuePairApp
{
    internal class KeyValuePairApp
    {
        static void Main(string[] args)
        {
            var capitals = new List<KeyValuePair<string, string>>();

            capitals.Add(new KeyValuePair<string, string>("Georgia", "Tbilisi"));
            capitals.Add(new KeyValuePair<string, string>("Russia", "Moscow"));
            capitals.Add(new KeyValuePair<string, string>("Turkey", "Ankara"));
            capitals.Add(new KeyValuePair<string, string>("Armenia", "Erevan"));

            capitals.RemoveAt(1);

            foreach (var item in capitals)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine(GetFirstAndLastName().Key + " " + GetFirstAndLastName().Value);
        }


        public static KeyValuePair<string, string> GetFirstAndLastName()
        {
            string firstName = "Dejan";
            string lastName = "Stankovic";
            return new KeyValuePair<string, string>(firstName, lastName);
        }
    }
}