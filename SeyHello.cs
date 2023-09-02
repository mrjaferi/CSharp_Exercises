using System;

namespace DistanceConversion
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            SeyHello(name);
        }

        static void SeyHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
    }
}
