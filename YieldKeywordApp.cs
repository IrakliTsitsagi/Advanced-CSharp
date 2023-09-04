namespace YieldKeywordApp
{
    internal class YieldKeywordApp
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(PerformMathOperations(2,3));
            foreach (var item in PerformMathOperations(3, 2))
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<double> PerformMathOperations(int numOne, int numTwo)
        {
            yield return numOne + numTwo;  // yeldis da ienumerables gareshe 2 jer ver daareturneb
            yield return numOne * numTwo;
            yield return numOne - numTwo;
            yield return Math.Round(((double)numOne / (double)numTwo), 2);
        }
    }
}