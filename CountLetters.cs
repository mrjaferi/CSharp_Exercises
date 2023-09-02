using System;

namespace DistanceConversion
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the text you want");
            var text = Console.ReadLine();

            Console.WriteLine("How many words should we calculate for you?");
            char letter = Convert.Tochar(Console.ReadLine());

            foreach (string txt in text)
            {
                var count = 0;

                foreach (char c in txt)
                {
                    if (c == letter)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"The number of '{letter}'s in {txt} is {count}");
            }

        }
    }
}
