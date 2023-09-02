using System;
using System.Linq;

namespace PowMaximumMinimum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter two numbers to calculate the power:");
            Console.WriteLine("First number:");
            var number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Second number:");
            var number2 = Convert.ToDouble(Console.ReadLine());

            var power = CalculatePower(number1, number2);
            Console.WriteLine($"{number1} raised to the power of {number2}: {power}");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Enter 5 numbers:");
            var numbers = new double[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            var maximum = FindMaximum(numbers);
            var minimum = FindMinimum(numbers);

            Console.WriteLine($"Maximum number is: {maximum}");
            Console.WriteLine($"Minimum number is: {minimum}");
        }

        static double CalculatePower(double number1, double number2)
        {
            double result = number1;
            for (int i = 0; i < number2 - 1; i++)
            {
                result *= number1;
            }
            return result;
        }

        static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        static double FindMaximum(double[] numbers)
        {
            double max = numbers[0];
            foreach (var number in numbers)
            {
                if (max < number)
                {
                    max = number;
                }
            }
            return max;
        }

        static double FindMinimum(double[] numbers)
        {
            double min = numbers[0];
            foreach (var number in numbers)
            {
                if (min > number)
                {
                    min = number;
                }
            }
            return min;
        }
    }
}
