using System.Diagnostics;
namespace StartingAndStoppingProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esaa notepadis shemqmneli da teqstis chamweri. sxva videodan aq chavwere ubralod
            System.IO.File.WriteAllText(@"C:\Users\Irakli\OneDrive\Desktop\C#\exercise.txt", "Hello papagenna");
            System.Diagnostics.Process.Start("C:\\Users\\Irakli\\OneDrive\\Desktop\\C#");
            Process.Start("Notepad.exe");

            // es dawyeba gacherebaa procesis
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
