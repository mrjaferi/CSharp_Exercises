using System;

namespace MathOperations
{
    public class MathOperation
    {
        public void Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Sum of two numbers: " + sum);
        }
        public void Add(int a, int b, int c)
        {
            int sum = a + b + c;
            Console.WriteLine("Sum of three numbers: " + sum);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            MathOperation math = new MathOperation();
            math.Add(5, 10); // Output: Sum of two numbers: 15
            math.Add(2, 4, 6); // Output: Sum of three numbers: 12
        }
    }
}
