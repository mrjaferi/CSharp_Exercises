using System;

namespace DistanceConversion
{
    class program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var randomNumber = random.Next(1, 101);

            var guess = 0;
            var tries = 0;

            while (guess != randomNumber)
            {
                Console.WriteLine("Your guess:");
                guess = Convert.ToInt32(Console.ReadLine());
                tries++;

                if (guess > randomNumber)
                {
                    Console.WriteLine("Guess the number less.");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Guess the number more.");
                }
            }

            Console.WriteLine($"congratulations! You guessed the number {tries}.");
        }
    }
}