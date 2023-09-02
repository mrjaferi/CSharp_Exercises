using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number 1 :");

            int number_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter your number 2 :");

            int number_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Enter the desired operation :\n Operation\t ShortKey\n Plus\t +\n Minus\t -\n Multiple\t *\n Divide\t \\ \n");

            char operation = Convert.ToChar(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------");

            if (operation == '+')
            {
                Console.WriteLine($"Total : {number_1 + number_2}");
            }

            if (operation == '-')
            {
                Console.WriteLine($"Total : {number_1 - number_2}");
            }

            if (operation == '*')
            {
                Console.WriteLine($"Total : {number_1 * number_2}");
            }

            if (operation == '/')
            {
                Console.WriteLine($"Total : {number_1 / number_2}");
            }

            Console.ReadKey();
        }
    }
}


