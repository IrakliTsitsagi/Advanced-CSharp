using System.Diagnostics;
namespace StartingAndStoppingProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process.Start("Notepad.exe");
            //  Process.Start(@"C:\Users\Irakli\OneDrive\Desktop\C#");
            //Process.Start("chrome.exe");
            //Process.Start("https://www.facebook.com");

            Process[] notepads = Process.GetProcessesByName("notepad");
            foreach (var process in notepads)
            {
                process.Kill();
            }
        }
    }
}