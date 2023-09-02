using System;

namespace DistanceConversion
{
    class program
    {
        static void Main(string[] args)
        {
            var password = "yasin";

            Console.WriteLine("Enter your password:");

            while (true)
            {
                var input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine("Welcome dear user.");
                    break;
                }
                else
                {
                    Console.WriteLine("The password entered is incorrect, Try again.");
                }
            }


        }
    }
}