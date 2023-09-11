namespace NullCoalescingAssignmentNewC
{
    internal class NullCoalescingAssignmentNewC
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int? i = null;

            numbers.Add(i ??= 5); // if null mashin 5 gaxdeba tu araa null da magalitad
            // zemot weria ro int i = 2 mashin ar gaxdeba 5

            Console.WriteLine("Value of i = " + i);

            foreach (var no in numbers)
            {
                Console.WriteLine(no);
            }
        }
    }
}