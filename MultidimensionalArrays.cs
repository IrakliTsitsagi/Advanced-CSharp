namespace MultidimensionalArrays
{
    internal class MultidimensionalArrays
    {
        static void Main(string[] args)
        {
            string[,] Array2D = new string[3, 2];
            Array2D[0, 0] = "item 00";
            Array2D[0, 1] = "item 01";
            Array2D[1, 0] = "item 10";
            Array2D[1, 1] = "item 11";
            Array2D[2, 0] = "item 20";
            Array2D[2, 1] = "item 21";

            int[,] Array2DA = new int[4, 2] { { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 }, };
            string[,] Numbers = new string[,] { { "one", "two" }, { "three", "four" } };

            //foreach (var item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("now we are accessing row no " + i);
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("now we are accessing col no " + j);
                    Console.WriteLine(Numbers[i, j]);
                }
            }

            Console.WriteLine();
        }
    }
}