using System;

namespace DistanceConversion
{
    class program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var letter = (char)('a' + random.Next(26));

            Console.WriteLine("A letter has been chosen at random. Can your guess what it is?");

            while (true)
            {
                Console.WriteLine("Enter your guess:");
                var input = Console.ReadLine().ToLower();

                if (input.Length != 1)
                {
                    Console.WriteLine("Please enter a single letter.");
                }
                else if (input[0] == letter)
                {
                    Console.WriteLine("Congratulations! You guessed the letter.");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, try again!");
                }
            }
        }
    }
}