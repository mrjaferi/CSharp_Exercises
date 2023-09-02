using System;

namespace DistanceConversion
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name :");
            var name = Console.ReadLine();

            var result=name.Insert(0, "mr/mrs.");

            Console.WriteLine($"Hello, dear {result}. An email has been sent to you, please check.");
        }
    }
}