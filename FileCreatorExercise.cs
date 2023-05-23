using System;
using System.IO;

namespace FileCreatorExercise
{
    internal class FileCreatorExercise
    {
        static void Main(string[] args)
        {
            StreamWriter sw;
            string language = string.Empty;
            int count = Enum.GetNames(typeof(Languages)).Length;
            for (int i = 0; i < count; i++)
            {
                language = Enum.GetValues(typeof(Languages)).GetValue(i).ToString();
                Console.WriteLine(language); // amit konsolshi wers
                Directory.CreateDirectory(@"C:\Users\Irakli\OneDrive\Desktop\C#\Languages");
                Directory.CreateDirectory(@"C:\Users\Irakli\OneDrive\Desktop\C#\Languages\\" + language);
                sw = new StreamWriter(@"C:\Users\Irakli\OneDrive\Desktop\C#\Languages\\" + language + "\\log.txt");
                sw.WriteLine("File number " + i + " created on " + DateTime.Now + " language is " + language); // amit wers failshi
                sw.Close();
            }

        }

        enum Languages
        {
            English,
            Georgian,
            German,
            Chinese

        }
    }
}