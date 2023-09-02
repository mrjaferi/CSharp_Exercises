using System;

namespace DistanceConversion
{
    class program
    {
        static void Main(string[] args)
        {
            string[] studentNames = new string[] { "Yasin", "Zahra", "Sepideh", "Matin", "Ali", "Ashkan" };

            Array.Sort(studentNames, StringComparer.InvariantCulture);

            Console.WriteLine("Sorted students:");
            foreach (string students in studentNames)
            {
                Console.WriteLine(students);
            }
        }
    }
}