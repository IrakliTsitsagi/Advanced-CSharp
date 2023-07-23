namespace PredicateDelegate
{
    internal class Program
    {
        // eseigi funci unda areturnebdes actioni ara da predicates input parametri unda
        //qondes da booleans areturnebdes
        static void Main(string[] args)
        {
            Predicate<int> condition = IsAdmin;
            Console.WriteLine(condition(10));
        }

        public static bool IsAdmin(int empNo)
        {
            if (empNo == 10)
            {
                return true;
            }
            else return false;
        }
    }
}