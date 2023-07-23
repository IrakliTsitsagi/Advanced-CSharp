namespace ActionWithAnonymousAndLambda
{
    internal class ActionWithAnonymousAndLambda
    {
        static void Main(string[] args)
        {
            string name = "Jack";

            // Action
            Action<string> Message = ShowMessage;
            Message(name);

            // Anonymous method
            name = "John";
            Action<string> anonymousMethod = delegate (string myName) { Console.WriteLine($"Hi, how are you today, {myName}?"); };
            anonymousMethod(name);

            // Lambda expression
            name = "Sandrai";
            Action<string> lambdaExpression = x => Console.WriteLine($"Hi, how are you today, {x}?");
            lambdaExpression(name);
        }

        public static void ShowMessage(string name)
        {
            Console.WriteLine($"Hi, how are you today, {name}?");
        }
    }
}