using System;

namespace Month_Enum
{
    class Program
    {
        public static void Main(string[] args)
        {
            int monthNumber = 5;
            Month myMonth = (Month)monthNumber;

            Console.WriteLine($"The month is {myMonth}");
        }
    }

    public enum Month
    {
        January = 1,
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
        December
    }
}