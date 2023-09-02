using System;

namespace MultipleMethod
{
    class program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.WriteLine("Enter number 1:");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2:");
            var num2 = Convert.ToInt32(Console.ReadLine());

            result = Multiple(num1, num2);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The result is: {result}");
            Console.ResetColor();
        }

        static int Multiple(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
    }
}
