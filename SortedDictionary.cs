namespace SortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int,string> colors = new SortedDictionary<int,string>();
            colors.Add(4, "Blue");
            colors.Add(2, "Yellow");
            colors.Add(1, "Orange");
            colors.Add(5, "Black");
            colors.Add(3, "White");

            foreach (var item in colors) 
            {
                Console.WriteLine(item.Value);
            }

            colors[2] = "Purple";
            Console.WriteLine("-------");

            foreach (var item in colors)
            {   
                Console.WriteLine(item.Value);
            }

            colors.Remove(2);
            Console.WriteLine();
            Console.WriteLine("after removing");
            foreach (var item in colors)
            {
                Console.WriteLine(item.Value);
            }
        
        }
    }
}