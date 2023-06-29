namespace GenericStacks
{
    internal class GenericStacks
    {
        static void Main(string[] args)
        {
            Stack<string> Ram = new Stack<string>();

            Ram.Push("Visual Studio");
            Ram.Push("Photoshop");
            Ram.Push("Google Chrome");
            Ram.Push("NotePad");

            Console.WriteLine(Ram.Peek());

            //foreach (var item in Ram)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}