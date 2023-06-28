using System.Collections;

namespace Stacks
{
    internal class Stacks
    {
        static void Main(string[] args)
        {
            // pirveli shedis bolo gamodis. anu davita shevida pirveli da gamova bolo
            // creating
            Stack stack = new Stack();

            // adding
            stack.Push("Davita");
            stack.Push("Bacho");
            stack.Push("Dama");
            stack.Push("Irakla");
            // removing
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }
    }
}
