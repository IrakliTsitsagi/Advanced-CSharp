using System.Threading.Channels;

namespace ConditionalOperatorExercise
{
    internal class ConditionalOperatorExercise
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 2 == 0 ? "Even Number" : "Odd Number");
        }
    }
}