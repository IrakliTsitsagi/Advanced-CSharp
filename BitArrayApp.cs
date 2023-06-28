using System.Collections;

namespace BitArrayApp
{
    internal class BitArrayApp
    {
        static void Main(string[] args)
        {
            // creating
            bool[] boolArray = new bool[4];
            boolArray[0] = false;
            boolArray[1] = false;
            boolArray[2] = false;
            boolArray[3] = true;

            BitArray firstArray = new BitArray(4);
            BitArray secondArray = new BitArray(boolArray);

            // setting value
            firstArray.Set(0, false);
            firstArray.Set(1, false);
            firstArray.Set(2, true);
            firstArray.Set(3, true);

            foreach (var item in firstArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------");

            foreach (var item in secondArray)
            {
                Console.WriteLine(item);
            }

            // and - or - not

            //// 1. and
            BitArray result = new BitArray(4);
            //result = firstArray.And(secondArray);
            //Console.WriteLine("-------");
            //// false da false aris false, false da truec aris false roca andia.
            //// da true true aris true andis shemtxvevashi.
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// or
            //result = firstArray.Or(secondArray);
            //Console.WriteLine("-------");
            //// 2. false
            //// ori false aris false. false true aris true. ori truec aris true
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            result = firstArray.Not();
            // 3. not
            // not aris sawinaagmdego am shemtxvevashi first arrays
            Console.WriteLine("-------");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}