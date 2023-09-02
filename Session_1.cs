using System;
using System.Linq;

namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your list of numbers:");
            string input = Console.ReadLine();
            String[] strlist = input.Split(' ');

            var sum = 0;

            for (int i = 0; i < strlist.Length; i += 2)
            {
                if (strlist.Length % 2 != 0 && i == strlist.Length - 1)
                {
                    Console.WriteLine(strlist[i]);
                }
                else
                {
                    var num1 = Convert.ToInt32(strlist[i]);
                    var num2 = Convert.ToInt32(strlist[i + 1]);
                    sum = num1 + num2;
                    Console.Write(sum + " ");
                }
            }
        }
    }
}
