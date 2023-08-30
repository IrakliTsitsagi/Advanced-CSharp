using static System.Console;
using static System.Math;
namespace StaticDirectives
{
    internal class StaticDirectives
    {
        static void Main(string[] args)
        {
            WriteLine(Round(2.5465, 2));

            // ase unda damewera imeebis gareshe using staticis
            //  Console.WriteLine(Math.Round(2.5465, 2));
        }
    }
}