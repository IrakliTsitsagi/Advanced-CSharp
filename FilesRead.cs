using System.IO;

namespace FilesRead
{
    internal class FilesRead
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\Irakli\OneDrive\Desktop\C#\test\Names.txt";
            StreamReader sr = new StreamReader(file);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }
    }
}