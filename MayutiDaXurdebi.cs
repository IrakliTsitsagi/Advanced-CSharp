﻿namespace MayutiDaXurdebi
{
    internal class MayutiDaXurdebi
    {
        static void Main(string[] args)
        {
            //Input - Money 77 , Coins 25,10,5,1
            //Output - 5 (25,25,25,1,1)
            ChangeGreedy(77, new int[] { 25, 10, 5, 1 });

            Console.WriteLine();

            //Input - Money 40 , Coins 25,20,10,5,1
            //Output - 5 (20,20)
            int[] coins = { 25, 20, 10, 5, 1 };
            int[] result = ChangeBruteForceCode(40, coins);
            Console.WriteLine("Change: " + string.Join(", ", result));
        }
        public static void ChangeGreedy(int money, int[] coins)
        {
            int i = 0;
            int count = 0;
            while (money > 0 && i < coins.Length)
            {
                if (coins[i] > money && money > 0)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine(money + " " + coins[i]);
                    money -= coins[i];
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public static int[] ChangeBruteForceCode(int money, int[] coins)
        {
            coins = coins.OrderByDescending(c => c).ToArray();
            int[] count = new int[coins.Length];
            int[] bestChange = new int[coins.Length];
            int smallestNumber = int.MaxValue;

            for (int i_1 = 0; i_1 <= money / coins[0]; i_1++)
            {
                for (int i_2 = 0; i_2 <= money / coins[1]; i_2++)
                {
                    for (int i_3 = 0; i_3 <= money / coins[2]; i_3++)
                    {
                        for (int i_4 = 0; i_4 <= money / coins[3]; i_4++)
                        {
                            for (int i_5 = 0; i_5 < money / coins[4]; i_5++)
                            {
                                int valueOfCoins = (i_1 * coins[0]) +
                                    (i_2 * coins[1]) + (i_3 * coins[2]) +
                                    (i_4 * coins[3]) + (i_5 * coins[4]);

                                if (valueOfCoins == money)
                                {
                                    int numberOfCoins = i_1 + i_2 +
                                        i_3 + i_4 + i_5;

                                    if (numberOfCoins < smallestNumber)
                                    {
                                        smallestNumber = numberOfCoins;
                                        count = new int[] { i_1, i_2, i_3, i_4, i_5 };
                                        bestChange = new int[] { i_1, i_2, i_3, i_4, i_5 };
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"{money} Cents can be split into:");
            for (int i = 0; i < coins.Length; i++)
            {
                Console.WriteLine($"{coins[i]} cent coin: {bestChange[i]} times");
            }

            return count;
        }
    }
}
