using System;

namespace Session_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock();
            var input = myClock.Menu();

            myClock.Case(input);
        }


    }

    public class Clock
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public int HourToMinute(int hour)
        {
            Hour = hour;
            int result;
            return result = Hour * 60;
        }

        public int MinuteToSecond(int minute)
        {
            Minute = minute;
            return Minute * 60;
        }

        // public void SecToHour()
        // {
        //     var h = Math.(Second / 3600);
        //     var b = Second % 3600;
        //     var m = Math.Floor(b / 60);
        //     var s = b % 60;
        //     Console.WriteLine($"{h}h {m}min {s}sec");
        // }

        public string Menu()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Clock Converter");
            Console.ResetColor();

            Console.WriteLine("#1 Hour to minute");
            Console.WriteLine("#2 Minute to second");
            // Console.WriteLine("#3 Hour to minute");

            Console.WriteLine("Enter the options");
            string input = Console.ReadLine();
            return input;

        }

        public void Case(string input)
        {

            switch (input)
            {
                case "1":
                    Console.WriteLine("1");
                    break;
                case "2":
                    Console.WriteLine("2");
                    break;
            }


        }
    }
}