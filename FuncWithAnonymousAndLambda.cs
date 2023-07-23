namespace FuncWithAnonymousAndLambda
{
    internal class FuncWithAnonymousAndLambda
    {
        static void Main(string[] args)
        {
            string name = "Dejan Stankovichi";

            // Func
            Func<string, string> ConvertToUppercase = UppercaseString;
            Console.WriteLine("Using func ");
            Console.WriteLine(ConvertToUppercase(name));

            // Anonymous method
            Func<string, string> anonymousMethod = delegate (string myName) { return myName.ToUpper(); };
            Console.WriteLine("Using anonymous method");
            Console.WriteLine(anonymousMethod(name));

            // Lambda expression
            Func<string, string> lambdaExpression = text => text.ToUpper();
            Console.WriteLine("Using lambda expression");
            Console.WriteLine(lambdaExpression(name));

        }

        public static string UppercaseString(string input)
        {
            return input.ToUpper();
        }
    }
}