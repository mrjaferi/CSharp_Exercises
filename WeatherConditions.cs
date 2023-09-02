using System;

namespace DistanceConversion
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the desired temperature :");
            var temp = Convert.ToInt32(Console.ReadLine());

            if (temp < 10)
            {
                Console.WriteLine("It is cold.");
            }
            else if (temp >= 10 && temp <= 28)
            {
                Console.WriteLine("Weather is mild.");
            }
            else if (temp > 28)
            {
                Console.WriteLine("it is hot.");
            }
            else
            {
                Console.WriteLine("Error: Please enter a numeric value.");
            }
        }
    }
}