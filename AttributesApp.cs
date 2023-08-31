namespace AttributesApp
{
    internal class AttributesApp
    {
        static void Main(string[] args)
        {
            Persons.SayHi();
            Persons.SayHello();
        }
    }

    class Persons
    {
        // say histan rom mivitan mauss qvemot mocemul teqsts michvenebs
        [Obsolete("This method is going to be included in the upcoming versions")]
        public static void SayHi()
        {
            Console.WriteLine("hi");
        }

        [Obsolete("fakiu")]
        public static void SayHello()
        {

        }
    }
}