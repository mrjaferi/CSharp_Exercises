using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the operator (sin, cos, tan, log) :");
            string op = Console.ReadLine();

            Console.WriteLine("Enter the number :");
            double number_1 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            if (op == "sin" || op == "Sin" || op == "SIN")
            {
                result = Math.Sin(number_1);
                Console.WriteLine(result);
            }

            if (op == "cos" || op == "Cos" || op == "COS")
            {
                result = Math.Cos(number_1);
                Console.WriteLine(result);
            }

            if (op == "tan" || op == "Tan" || op == "TAN")
            {
                result = Math.Tan(number_1);
                Console.WriteLine(result);
            }

            if (op == "log" || op == "Log" || op == "LOG")
            {
                result = Math.Log10(number_1);
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
