namespace VerbatimInterpolatedStringsNewC
{
    internal class VerbatimInterpolatedStringsNewC
    {
        static void Main(string[] args)
        {
            string normal = "Gori lamazi qalaqia \nme mand vcxovrob";
            Console.WriteLine(normal);

            string verbatim = @"gori lamazia vaa
lamaziii
me mand vcxovrob kaco.";
            Console.WriteLine(verbatim);

            int visits = 124134134;

            string[] @for = { "Jacck", "Jeni", "Smiti" };
            foreach (var name in @for)
            {
                Console.WriteLine(name);
            }

            string concat = "me viyavi gorshi " + visits + " jer";
            Console.WriteLine(concat);

            string interpolate = $"me viyavi gorshi {visits} jer.";
            Console.WriteLine(interpolate);

            string format = string.Format("me viyavi gorshi {0} jer.", visits);
            Console.WriteLine(format);

            string fileName = "employees.xls";
            string folderName = $@"C:\Users\Irakli\OneDrive\Desktop\C#\test\{fileName}";
            Console.WriteLine(folderName);

            string travelToGori = $@"Gori aris lamazi ! viyavi {visits}";
            Console.WriteLine(travelToGori);


        }
    }
}