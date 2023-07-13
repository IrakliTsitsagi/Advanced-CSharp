namespace ValueTuples
{
    internal class ValueTuples
    {
        static void Main(string[] args)
        {
            // ase davainstale value tuple PM> install-package "system.valuetuple" tools-nuget package manager console
            int x = 0;

            (int playerNo, string playerName, int playerGoals) ronaldo = (7, "Ronaldo", 55);
            Console.WriteLine(ronaldo.playerNo);
            Console.WriteLine(ronaldo.playerName);
            Console.WriteLine(ronaldo.playerGoals);
            Console.WriteLine();

            // another way
            var messi = (playerNo:10, playerName:"Messi", playerGoals:60);
            Console.WriteLine(messi.playerNo);
            Console.WriteLine(messi.playerName);
            Console.WriteLine(messi.playerGoals);

        }
    }
}