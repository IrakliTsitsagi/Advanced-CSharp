namespace ParamsExercise
{
    internal class ParamsExercise
    {
        static void Main(string[] args)
        {
            loopThroughArray(10, 50, 25, 3);

            loopThroughArray("Ahmada", "Gela", "Vaja");

            loopThroughArray(DateTime.Now, new DateTime(2017, 10, 09));
        }

        public static void loopThroughArray<T>(params T[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}