using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerSmaller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three integers :");
            int number_1 = Convert.ToInt32(Console.ReadLine());
            int number_2 = Convert.ToInt32(Console.ReadLine());
            int number_3 = Convert.ToInt32(Console.ReadLine());

            int max = number_1;
            int min = number_1;

            if (number_2 > max)
            {
                max = number_2;
            }

            if (number_3 > max)
            {
                max = number_3;
            }

            if (number_2 < min)
            {
                min = number_2;
            }

            if (number_3 < min)
            {
                min = number_3;
            }

            Console.WriteLine("\n-------------------------------\n");

            Console.WriteLine($"The largest number is : {max}");
            Console.WriteLine($"\nThe smallest number is : {min}");

            Console.ReadKey();
        }
    }
}
