using System;

namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            var plus = new CPlus();

            bool start = true;

            while (start)
            {
                Print();

                try
                {
                    IfElse();

                    Console.WriteLine("Do you intend to continue? (Y = Yes / N = No)");
                    char input = Convert.ToChar(Console.ReadLine());

                    if (input == 'Y' || input == 'y')
                    {
                        start = true;
                    }
                    else if (input == 'N' || input == 'n')
                    {
                        start = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Error: Please enter the correct phrase.");
                        Console.ResetColor();
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    Console.ResetColor();
                }
            }
        }

        public static void Print()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("CALCULATOR");
            Console.WriteLine("--------------------");
        }

        public static void OperationsPrint()
        {
            Console.WriteLine("Select operation:\n\t+ = Plus\n\t- = Minus\n\t* = Multiple\n\t/ = Divide");
        }

        public static void IfElse()
        {
            var plus = new CPlus();
            var minus = new CMinus();
            var multiple = new CMultiple();
            var divide = new CDivide();

            Console.WriteLine("Enter number 1:");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2:");
            var num2 = Convert.ToInt32(Console.ReadLine());

            OperationsPrint();
            char op = Convert.ToChar(Console.ReadLine());

            if (op == '+')
            {
                plus.Plus(num1, num2);
            }
            else if (op == '-')
            {
                minus.Minus(num1, num2);
            }
            else if (op == '*')
            {
                multiple.Multiple(num1, num2);
            }
            else if (op == '/')
            {
                divide.Divide(num1, num2);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Error: Please enter the correct phrase.");
                Console.ResetColor();
            }
        }
    }

    public class Operations
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int num3 { get; set; }
        public int PlusProperty { get; set; }
        public int MinusProperty { get; set; }
        public int MultipleProperty { get; set; }
        public int DivideProperty { get; set; }

        public virtual void Plus(int num1, int num2)
        {
            var result = num1 + num2;
        }

        public virtual void Minus(int num1, int num2)
        {
            var result = num1 - num2;
        }

        public virtual void Multiple(int num1, int num2)
        {
            var result = num1 * num2;
        }

        public virtual void Divide(int num1, int num2)
        {
            var result = num1 / num2;
        }
    }

    public class CPlus : Operations
    {
        public override void Plus(int num1, int num2)
        {
            var result = num1 + num2;

            Console.WriteLine("\n--------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" Risult is: {result} ");
            Console.ResetColor();
        }
    }

    public class CMultiple : Operations
    {
        public override void Multiple(int num1, int num2)
        {
            var result = num1 * num2;

            Console.WriteLine("\n--------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" Risult is: {result} ");
            Console.ResetColor();
        }
    }

    public class CMinus : Operations
    {
        public override void Minus(int num1, int num2)
        {
            var result = num1 - num2;

            Console.WriteLine("\n--------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" Risult is: {result} ");
            Console.ResetColor();
        }
    }

    public class CDivide : Operations
    {
        public override void Divide(int num1, int num2)
        {
            var result = num1 / num2;

            Console.WriteLine("\n--------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" Risult is: {result} ");
            Console.ResetColor();
        }
    }
}