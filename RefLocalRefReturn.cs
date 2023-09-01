namespace RefLocalRefReturn
{
    internal class RefLocalRefReturn
    {
        static void Main(string[] args)
        {
            // es xoa rogorc vaketebdi
            //int X1 = 3;
            //int X2 = X1;
            //Console.WriteLine(X1);
            //Console.WriteLine(X2);

            // ase axla. anu ro shevcvli X1 X2 ic icvleba
            int X1 = 3;
            ref int X2 = ref X1;
            Console.WriteLine(X1 + " " + X2);
            X1 = 2;
            Console.WriteLine(X1 + " " + X2);

            //  Console.WriteLine(ReturnByReference()); aq funqciit momaqvs

            ref var returnValue = ref ReturnByReference();
            Console.WriteLine(returnValue); // aq referensit
        }

        public static ref string ReturnByReference()
        {
            string[] arrayOfNames = { "Ela", "Luiza", "Eve", "Claire" };
            return ref arrayOfNames[0];
        }
    }
}