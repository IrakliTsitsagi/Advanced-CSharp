namespace TimeSpanApp
{
    internal class TimeSpanApp
    {
        static void Main(string[] args)
        {
            TimeSpan ts = new TimeSpan(10, 8, 55);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.TotalHours);

            ts = ts.Add(new TimeSpan(0, 0, 30));
            Console.WriteLine(ts);

            DateTime myDateOne = new DateTime(1999, 10, 30);
            DateTime myDateTwo = new DateTime(2017, 10, 30);

            TimeSpan sub = myDateTwo - myDateOne;
            sub = myDateTwo.Subtract(myDateOne);
            Console.WriteLine(sub.TotalDays / 365.25);
        }
    }
}