using System;

namespace ConvertToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = "123abc";
            try
            {
                int number = int.Parse(numberString);
                Console.WriteLine("Number: " + number);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
