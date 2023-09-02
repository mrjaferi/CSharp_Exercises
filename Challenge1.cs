using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the length of the first side :");
            Console.ResetColor();
            double side_1 = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the length of the second side :");
            Console.ResetColor();
            double side_2 = Convert.ToDouble(Console.ReadLine());

            double pythagoras = Math.Sqrt((side_1 * side_1) + (side_2 * side_2));

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\nThe length of the third side is : {pythagoras} ");

            Console.ReadKey();
        }
    }
}
