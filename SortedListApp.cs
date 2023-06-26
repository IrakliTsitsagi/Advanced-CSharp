using System.Collections;

namespace SortedListApp
{
    internal class SortedListApp
    {
        static void Main(string[] args)
        {
            // creating
            SortedList sortedList = new SortedList();

            // adding
            sortedList.Add(1, "Jan"); // aq 10 ro davwero boloshi gadaitans
            sortedList.Add(2, "Feb"); // 2 aris key feb value. value sheidzleba iyos null key ara
            sortedList.Add(3, "Mar"); // key ar sheidzleba ertnairebi iyos magalitad amrtic 3 da aprilic 3 ar sheidzleba
            sortedList.Add(4, "Apr");
            sortedList.Add(5, "May");

            // displaying with foreach and for
            // with foreach
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            // with for
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine(sortedList.GetKey(i) + ": " + sortedList.GetByIndex(i));
            }

            // index
            Console.WriteLine(sortedList[2].ToString());

            // capacity
            Console.WriteLine(sortedList.Count);

            // remove 
            // sortedList.Remove(1); // es ianvars shlis
            // sortedList.RemoveAt(1); // es tebervals
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            // contains
            Console.WriteLine(sortedList.ContainsValue("Jun"));
            Console.WriteLine(sortedList.ContainsValue("Apr"));

            // copy to arrayList

            Console.WriteLine("now we are inside the array list");
            ArrayList array = new ArrayList(sortedList.Values);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}