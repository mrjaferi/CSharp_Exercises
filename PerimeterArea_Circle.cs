using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterArea_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Specify the type of operation: (Area / Perimeter)");
            Console.ResetColor();
            string operation = Console.ReadLine();

            if (operation == "Area" || operation == "AREA" || operation == "area")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter the radius of the circle :");
                Console.ResetColor();
                double radius = Convert.ToDouble(Console.ReadLine());

                double area = Math.PI * radius * radius;

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"\nThe area of the circle is : {area} ");
            }

            if (operation == "Perimeter" || operation == "PERIMETER" || operation == "perimeter")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter the diameter of the circle :");
                Console.ResetColor();
                double diameter = Convert.ToDouble(Console.ReadLine());

                double perimeter = Math.PI * diameter;

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"\nThe perimeter of a circle is : {perimeter} ");
            }


            Console.ReadKey();
        }
    }
}
