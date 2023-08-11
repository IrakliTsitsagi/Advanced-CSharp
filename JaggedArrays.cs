namespace JaggedArrays
{
    internal class JaggedArrays
    {
        static void Main(string[] args)
        {
            // jagged array aris arrayebis array

            int[][] jaggedArrayOne = new int[3][];
            jaggedArrayOne[0] = new int[5] { 0, 1, 2, 3, 4 };
            jaggedArrayOne[1] = new int[2] { 54, 17 };
            jaggedArrayOne[2] = new int[3] { 1, 3, 5 };

            // different way

            int[][] jaggedArrayTwo =
            {
                new int[] {0,1,2,3},
                new int[] {10,20,30,50}
            };

            // Console.WriteLine(jaggedArrayTwo[1][3]);

            for (int i = 0; i < jaggedArrayTwo.Length; i++)
            {
                Console.WriteLine("Now accessing array no " + i);
                for (int j = 0; j < jaggedArrayTwo[i].Length; j++)
                {
                    Console.WriteLine(jaggedArrayTwo[i][j]);
                }
            }

            Console.WriteLine();
        }
    }
}