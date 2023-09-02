using System;

namespace DistanceConversion
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a username :");
            var userName = Console.ReadLine();

            Console.WriteLine("Please enter a password :");
            var password = Console.ReadLine();

            if (userName == "yasin" && password == "211")
            {
                Console.WriteLine($"\n{userName}, welcome!");
            }
            else if (userName != "yasin")
            {
                Console.WriteLine($"\nThe username entered is incorrect.");
            }
            else if (password != "211")
            {
                Console.WriteLine("The password entered is incorrect.");
            }
            else
            {
                Console.WriteLine("Login failed!");
            }
        }
    }
}