namespace Nested_Local_Functions
{
    internal class Nested_Local_Functions
    {
        static void Main(string[] args)
        {
            PerformMathOperations(1, 2, 3, 4);
        }

        public static void PerformMathOperations(params int[] numbers)
        {
            Console.WriteLine("Add = " + AddNumbers());
            int AddNumbers()
            {
                int result = 0;
                foreach (var number in numbers)
                {
                    result = result + number;
                }
                return result;
            }

            Console.WriteLine("Multi = " + MultiplyNumbers());
            int MultiplyNumbers()
            {
                int result = 1;
                foreach (var number in numbers)
                {
                    result = result * number;
                }
                return result;
            }
        }
    }
}