namespace ParamsKeyword
{
    internal class ParamsKeyword
    {
        static void Main(string[] args)
        {
            LoopThroughArray(new string[5] { "Dejan", "Bejan", "Ylekac", "Slesha", "Lado" }); // aq 5 unda iyos imena
            Console.WriteLine();
            LoopThroughArray("Yursha", "ufroyle", "uaresiyle"); // aq ramdensac minda chavwer axla
        }

        public static void LoopThroughArray(params string[] names) // params resizes aketebs tavisit kaia
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}