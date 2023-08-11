namespace DynamicKeyword
{
    internal class DynamicKeyword
    {
        static void Main(string[] args)
        {
            dynamic value = 0;
            Console.WriteLine("Value = " + value);
            Console.WriteLine("value type is " + value.GetType().Name);
            Console.WriteLine();

            value = "Kata";
            Console.WriteLine("Value = " + value);
            Console.WriteLine("value type is " + value.GetType().Name);
            Console.WriteLine();

            value = new Animals();
            value.Name = "Miako";
            Console.WriteLine("Value = " + value.Name);
            Console.WriteLine("value type is " + value.GetType().Name);
            Console.WriteLine();
        }
    }

    class Animals
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}