namespace MultidimensionalArraysExercise
{
    internal class MultidimensionalArraysExercise
    {
        static void Main(string[] args)
        {
            string[,] a = new string[3, 3];
            a[0, 0] = "item00";
            a[0, 1] = "item01";
            a[0, 2] = "item02";
            a[1, 0] = "item10";
            a[1, 1] = "item11";
            a[1, 2] = "item12";
            a[2, 0] = "item20";
            a[2, 1] = "item21";
            a[2, 2] = "item22";

            Console.WriteLine("\tColumn1 \tColumn2 \tColumn3");
            Console.WriteLine("\t------- \t------- \t-------");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Row " + (i + 1));
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t");
                    Console.Write(a[i, j]);
                    Console.Write("\t");
                    if (j == 2)
                        Console.WriteLine();
                }
            }
        }
    }
}