using System;

namespace StringManipulator
{
    public class StringManipulator
    {
        public string Concatenate(string str1, string str2)
        {
            return str1 + str2;
        }

        public string Concatenate(string str1, string str2, string str3)
        {
            return str1 + str2 + str3;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            StringManipulator strManipulator = new StringManipulator();
            string result1 = strManipulator.Concatenate("Hello", " My Friends");
            Console.WriteLine(result1); // Output: Hello World

            string result2 = strManipulator.Concatenate("i'm", " ", "yasin");
            Console.WriteLine(result2); // Output: Hello C#
        }
    }
}