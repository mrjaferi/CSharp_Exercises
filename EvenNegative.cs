using System;

namespace DistanceConversion
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleaseenter a number :");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is even.");
            }
            else
            {
                Console.WriteLine($"The number {number} is odd.");
            }
        }
    }
}