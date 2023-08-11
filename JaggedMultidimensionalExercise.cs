namespace JaggedMultidimensionalExercise
{
    internal class JaggedMultidimensionalExercise
    {
        static void Main(string[] args)
        {
            int[][,] jaggedMultiArray = new int[3][,];

            jaggedMultiArray[0] = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            jaggedMultiArray[1] = new int[3, 2] { { 10, 10 }, { 20, 20 }, { 30, 30 } };
            jaggedMultiArray[2] = new int[2, 2] { { 3, 5 }, { 1, 2 } };
            Console.WriteLine();

            // Printing the jagged array
            for (int i = 0; i < jaggedMultiArray.Length; i++)
            {
                Console.WriteLine($"Array {i}:");
                for (int j = 0; j < jaggedMultiArray[i].GetLength(0); j++)
                {
                    for (int k = 0; k < jaggedMultiArray[i].GetLength(1); k++)
                    {
                        Console.Write($"{jaggedMultiArray[i][j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

            }
        }
    }
}