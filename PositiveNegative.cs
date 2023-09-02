using System;

namespace DistanceConversion
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number :");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"\nThe number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"\nThe number {number} is negative.");
            }
            else
            {
                Console.WriteLine("Your number is 0");
            }
        }
    }
}