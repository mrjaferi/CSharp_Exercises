using System;

namespace Divide_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividend = 10;
            int divisor = 0;
            try
            {
                int result = dividend / divisor;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}