using System;
using System.Linq;

namespace Generic_Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            var intArray = new int[] { 1, 5, 15 };
            var doubleArray = new double[] { 1.5, 5.75, 1.65 };
            var stringArray = new string[] { "25", "30", "1020" };

            DisplayMyArray<int, string>(intArray, "Yasin");
            DisplayMyArray<double, int>(doubleArray, 250);
            DisplayMyArray<string, bool>(stringArray, false);

            Console.WriteLine("-------------------------------");

            var myShape = new Shape<int>();
            myShape.Size = 250;
            Console.WriteLine(myShape.Size);

        }

        public static void DisplayMyArray<T, TName>(T[] myArray, TName myParam)
        {
            foreach (var item in myArray)
            {
                Console.WriteLine("My item: " + item);
            }

            Console.WriteLine("My param is: " + myParam);
        }
    }

    public class Shape<T>
    {
        public T Size { get; set; }
    }
}