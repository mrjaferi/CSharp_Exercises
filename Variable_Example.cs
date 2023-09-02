using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Variable_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The variables of the list of students' characteristics
            int rowNumber = 1;
            string name;
            string family;
            int age;
            bool gender = true;


            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(rowNumber);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nPlease enter your name :");
            Console.ResetColor();
            name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Please enter your family :");
            Console.ResetColor();
            family = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Please enter your age :");
            Console.ResetColor();
            age = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Is your gender male ? [true / false]");
            Console.ResetColor();
            gender = Convert.ToBoolean(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n--------------------------\n");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Display output : \"show\"");
            Console.ResetColor();
            string output = Console.ReadLine();

            if (output == "show" || output == "Show" || output == "SHOW")
            {
                Console.WriteLine(rowNumber);
                Console.WriteLine(name);
                Console.WriteLine(family);
                Console.WriteLine(age);
                Console.WriteLine(gender);
            }


            Console.ReadKey();
        }
    }
}
