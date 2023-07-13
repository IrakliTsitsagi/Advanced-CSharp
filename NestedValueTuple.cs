namespace NestedValueTuple
{
    internal class NestedValueTuple
    {
        static void Main(string[] args)
        {
            var ronaldoGoals = (year2017: 64, year2016: 60, year2015: 50);
            var ronaldo = (playerNo: 10, playerName: "Ronaldo", playerGoals:ronaldoGoals);
            Console.WriteLine(ronaldo.playerNo);
            Console.WriteLine(ronaldo.playerName);
            Console.WriteLine(ronaldo.playerGoals.year2017);
            Console.WriteLine(ronaldo.playerGoals.year2016);
            Console.WriteLine(ronaldo.playerGoals.year2015);
            Console.WriteLine();

        }
    }
}