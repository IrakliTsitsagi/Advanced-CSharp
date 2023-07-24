namespace ConditionalOperator
{
    internal class ConditionalOperator
    {
        static void Main(string[] args)
        {
            //if (IsAdmin() == true)
            //{
            //    Console.WriteLine("Yes, he is an admin");
            //}
            //else
            //{
            //    Console.WriteLine("Not an admin");
            //}

            // shorter way
            Console.WriteLine(IsAdmin() ? "Yes an admin" : "Not an admin");
        }

        public static bool IsAdmin()
        {
            return false;
        }
    }
}