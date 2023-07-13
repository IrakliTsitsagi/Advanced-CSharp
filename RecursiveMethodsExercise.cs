namespace RecursiveMethodsExercise
{
    internal class RecursiveMethodsExercise
    {
        static void Main(string[] args)
        {
            string path = string.Empty;
            path = "C:\\Users\\Irakli\\OneDrive\\Desktop\\C#\\Recursive";
            Console.WriteLine(path);
            DisplayFolder(path, 0);
        }

        public static void DisplayFolder(string path, int indent)
        {
            foreach (var folder in Directory.GetDirectories(path))
            {
                Console.WriteLine($"{new string(' ', indent)} {Path.GetFileName(folder)}");
                DisplayFolder(folder, indent + 2);
                // es indent + 2 aris folders shiga folderis saxeli ro gawios gverdze 
            }
        }
    }
}