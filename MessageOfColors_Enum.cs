using System;

namespace MessageOfColors_Enum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Color myColor = Color.Red;
            PrintMessage(myColor);
        }

        static void PrintMessage(Color color)
        {
            switch (color)
            {
                case Color.Red:
                    Console.WriteLine("Stop!");
                    break;
                case Color.Green:
                    Console.WriteLine("Go!");
                    break;
                case Color.Blue:
                    Console.WriteLine("Cool!");
                    break;
                case Color.Yellow:
                    Console.WriteLine("Be careful!");
                    break;
                default:
                    Console.WriteLine("Unknown color");
                    break;
            }
        }
    }

    enum Color
    {
        Red,
        Green,
        Blue,
        Yellow
    }
}