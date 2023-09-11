using System.Diagnostics;

namespace SwitchExpressionsNewC
{
    enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December,
    }
    internal class SwitchExpressionsNewC
    {

        static void Main(string[] args)
        {
            Months months = Months.June;
            Console.WriteLine(CheckMonthOldWay(months));
            Console.WriteLine(CheckMonth(months));
        }

        // new way
        public static string CheckMonth(Months month) =>
            month switch
            {
                Months.January => "Winter",
                Months.February => "Winter",
                Months.March => "Spring",
                Months.April => "Spring",
                Months.May => "Spring",
                Months.June => "Summer",
                Months.July => "Summer",
                Months.August => "Summer",
                Months.September => "Autumn",
                Months.October => "Autumn",
                Months.November => "Autumn",
                Months.December => "Winter",
                _ => "Invalid input"

            };


        // this is old ugly way
        public static string CheckMonthOldWay(Months month)
        {
            switch (month)
            {
                case Months.December:
                case Months.January:
                case Months.February:
                    return "Winter";

                case Months.March:
                case Months.April:
                case Months.May:
                    return "Spring";

                case Months.June:
                case Months.July:
                case Months.August:
                    return "Summer";

                case Months.September:
                case Months.October:
                case Months.November:
                    return "Autumn";

                default:
                    return "Invalid input";
            }
        }
    }
}