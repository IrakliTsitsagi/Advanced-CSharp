using System.Text;

namespace StringBuilderApp
{
    internal class StringBuilderApp
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder("Hello");
            builder.Append(" Joni");
            Console.WriteLine(builder);
            builder.Insert(10, " Helloooo"); // es 10 indeqsia sadac ginda chasva sityva
            Console.WriteLine(builder);
            builder.Remove(0, 6);
            Console.WriteLine(builder);
            builder.Replace('o', '0'); // stringebis chanacvlebac sheidzleba
            Console.WriteLine(builder);
            string text = builder.ToString(); // sxva cvladshi vinaxav ravi es ise maswavles ro tostring undao
            Console.WriteLine(text);
        }
    }
}