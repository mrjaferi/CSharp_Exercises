using System;

namespace DistanceConversion
{
    class program
    {
        static void Main(string[] args)
        {
            var channel = 0;
            var favourite = false;

            do
            {
                Console.WriteLine($"\'channel #{++channel}\'");
                Console.WriteLine($"Is your favorite channel channel #{channel} ?\n(yes or no)");
                var userResponse = Console.ReadLine();

                if (userResponse == "yes" || userResponse == "Yes" || userResponse == "YES")
                {
                    favourite = true;
                }
                else
                {
                    favourite = false;
                }
            }
            while (!favourite);

            Console.WriteLine($"The channel {channel} is ready for you to play.");
            Console.WriteLine("------------------------------------------------");
        }
    }
}