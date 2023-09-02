using System;

namespace PowerMethod
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the power:");
            int power = int.Parse(Console.ReadLine());

            int result = Power(number, power);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The result is: {result}");
            Console.ResetColor();
        }

        static int Power(int number, int power)
        {
            int result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
