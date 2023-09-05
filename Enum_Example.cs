using System;

namespace Enum_Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Color.Red);
            Console.WriteLine((int)Color.Red);
            Console.WriteLine("Red");

            Console.WriteLine((int)Color.Green);

            var selectedColor = Color.Black;

            if (selectedColor == Color.Black)
            {

            }

            var currentDay = Days.Sunday;
            switch (currentDay)
            {
                case Days.Saturday:
                    Console.WriteLine(Days.Saturday);
                    break;
                case Days.Sunday:
                    Console.WriteLine(Days.Sunday);
                    break;
                case Days.Monday:
                    Console.WriteLine(Days.Monday);
                    break;
                case Days.Tuesday:
                    Console.WriteLine(Days.Tuesday);
                    break;
                case Days.Wednezday:
                    Console.WriteLine(Days.Wednezday);
                    break;
                case Days.Thursday:
                    Console.WriteLine(Days.Thursday);
                    break;
                case Days.Friday:
                    Console.WriteLine(Days.Friday);
                    break;
                default:
                    Console.WriteLine("ERROR!");
                    break;
            }

            Console.WriteLine("Enter a index");
            var input = Console.ReadLine();
            var userInput = (Days)Enum.Parse(typeof(Days), input);
            Console.WriteLine(userInput);
        }
    }

    public enum Color
    {
        Red = 1200,
        Green = 2700,
        Blue = 5400,
        White = 3600,
        Black = 4000
    }

    public enum Days
    {
        Saturday=1,
        Sunday,
        Monday,
        Tuesday,
        Wednezday,
        Thursday,
        Friday
    }
}