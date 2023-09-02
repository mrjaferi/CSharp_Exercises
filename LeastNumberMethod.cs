using System;
using System.Collections.Generic;

namespace LeastNumberMethod
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the list of numbers (separate numbers with spaces):");
            string input = Console.ReadLine();

            // Analyzing input into numbers
            List<int> numbers = ParseInput(input);

            if (numbers.Count > 0)
            {
                //  Find the smallest number
                int minNumber = FindMinNumber(numbers);

                Console.WriteLine($"The lowest number in the list: {minNumber}");
            }
            else
            {
                Console.WriteLine("No number entered.");
            }
        }

        static List<int> ParseInput(string input)
        {
            List<int> numbers = new List<int>();

            string[] numberStrings = input.Split(' ');
            foreach (string numberString in numberStrings)
            {
                if (int.TryParse(numberString, out int number))
                {
                    numbers.Add(number);
                }
            }

            return numbers;
        }

        static int FindMinNumber(List<int> numbers)
        {
            int minNumber = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }

            return minNumber;
        }
    }
}