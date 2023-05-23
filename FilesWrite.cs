using System.IO;

namespace FilesWrite
{
    internal class FilesWrite
    {

        // failshi text fails vqmni da saxelebs vwer ase
        static void Main(string[] args)
        {


            // vqmni axal direqtoriasa saxelad males
            // Directory.CreateDirectory(@"C:\Users\\Irakli\OneDrive\Desktop\C#\test\Males"); // rom sheiqmneba mere unda daakomentaro ro kide ar sheqmnas

            // asec sheidzleba an string file = "C:\\Users\\Irakli\\OneDrive\\Desktop\\C#\\test";
            string file = @"C:\Users\\Irakli\OneDrive\Desktop\C#\test\Males\Names.txt";  // ese
            StreamWriter sw = new StreamWriter(file,true); // sxva saxelebic ro chaweros da arsebulebs ar gadaaweros vwer ,true
            sw.WriteLine("Dejan");
            sw.WriteLine("Vaja");
            sw.Close();
        }
    }
}