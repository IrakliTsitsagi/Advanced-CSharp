namespace ListAppT
{
    internal class ListAppT
    {
        static void Main(string[] args)
        {
            // creating

            List<string> firstList = new List<string>();
            IList<string> secondList = new List<string>();

            // adding

            firstList.Add("England");
            firstList.Add("Georgia");
            firstList.Add("Germany");
            firstList.Add("China");

            // displaying

            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            // index
            Console.WriteLine("indexit povna");
            firstList[2] = "Korea"; //ese sheidzleba chanacvleba
                                    // Console.WriteLine(firstList[2]);
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            // capacity

            Console.WriteLine("Count is " + firstList.Count);

            // sorting

            Console.WriteLine("after sorting");
            firstList.Sort();
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            // reversing

            Console.WriteLine("after reversing");
            firstList.Reverse();
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            // removing

            // firstList.RemoveAt(0); indeqsit washla
            // firstList.RemoveRange(0, 24); am reinjshi washla
            Console.WriteLine("after removing");
            firstList.Remove("China");
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("count now is " + firstList.Count);

            // remove all

            // firstList.Clear();

            // contains

            Console.WriteLine(firstList.Contains("Georgia"));

            // GetRange

            secondList = firstList.GetRange(0, 2);
            Console.WriteLine("now we are in the second list");
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
        }
    }
}