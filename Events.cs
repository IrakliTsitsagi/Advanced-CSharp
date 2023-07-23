namespace Events
{
    public delegate void myDelegate(string name);
    internal class Events
    {
        public event myDelegate myEvent;

        public Events()
        {
            myEvent += new myDelegate(SayHiGeorgian);
            myEvent += new myDelegate(SayHiItalian);
            myEvent += new myDelegate(SayHiEnglish);
        }
        static void Main(string[] args)
        {
            Events prog = new Events();
            prog.myEvent("Guram");
        }

        public void SayHiEnglish(string name)
        {
            Console.WriteLine("Hi " + name);
        }

        public void SayHiGeorgian(string name)
        {
            Console.WriteLine("Gamarjoba " + name);
        }

        public void SayHiItalian(string name)
        {
            Console.WriteLine("Ciao " + name);
        }
    }
}