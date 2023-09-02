using System;

namespace DistanceConversion
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight in kilograms :");
            var weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your height in meters :");
            var height = Convert.ToDouble(Console.ReadLine());

            var bmi = weight / (height * height);

            Console.WriteLine($"Your BMI is {bmi}");

            if (bmi < 18.5)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("You are underweight.");
                Console.ResetColor();
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Your weight is ideal.");
                Console.ResetColor();
            }
            else if (bmi >= 25.0 && bmi <= 29.9)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("You are overweight.");
                Console.ResetColor();
            }
            else if (bmi >= 30.0 && bmi <= 39.9)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("You are obese.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Error: The value entered is incorrect.  Please enter a numeric value.");
                Console.ResetColor();
            }
        }
    }
}