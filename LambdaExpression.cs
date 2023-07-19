namespace LambdaExpression
{
    delegate void DisplayMessage();
    delegate int Multiply(int n);
    internal class LambdaExpression
    {
        static void Main(string[] args)
        {
            Multiply MultiplyNumberr = delegate (int n) { { return n * 3; } };
            Multiply MultiplyNumber = n => n * 3; // lambda

            Console.WriteLine(MultiplyNumberr(30));
            Console.WriteLine(MultiplyNumber(30));

            DisplayMessage Message = delegate
            {
                Console.WriteLine("Hi from Anonymous " +
                "method");
            };
            DisplayMessage Messagee = () => Console.WriteLine("Hi from the lambda expression");
            Message();
            Messagee();
        }
    }
}