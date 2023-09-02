using System;
using System.Collections.Generic;

namespace LargestNumberMethod
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a list of numbers (separate numbers with spaces):");
            string input = Console.ReadLine();

            // Analyzing input into numbers
            List<int> numbers = ParseInput(input);

            if (numbers.Count > 0)
            {
                // Find the largest number
                int maxNumber = FindMaxNumber(numbers);

                Console.WriteLine($"The largest number in the list: {maxNumber}");
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

        static int FindMaxNumber(List<int> numbers)
        {
            int maxNumber = int.MinValue;

            foreach (int number in numbers)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            return maxNumber;
        }
    }
}