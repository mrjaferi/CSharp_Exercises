// using System;

// namespace Calculator_Generic
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter number 1:");
//             int firstNumber = int.Parse(Console.ReadLine());
//             Console.WriteLine("Enter number 2:");
//             int secondNumber = int.Parse(Console.ReadLine());

//             NumberHolder<int> numbers = new NumberHolder<int>(firstNumber, secondNumber);

//             int result = Sum(numbers.FirstNumber, numbers.SecondNumber);
//             Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
//         }

//         static T Sum<T>(T a, T b)
//         {
//             dynamic num1 = a;
//             dynamic num2 = b;
//             return num1 + num2;
//         }

//     }

//     public class NumberHolder<T> : ICalculationOperation<T>
//     {
//         public T FirstNumber { get; set; }
//         public T SecondNumber { get; set; }

//         public NumberHolder(T firstNumber, T secondNumber)
//         {
//             FirstNumber = firstNumber;
//             SecondNumber = secondNumber;
//         }

        // public T 
//     }

//     public interface ICalculationOperation<T>
//     {
//         T FirstNumber { get; set; }
//         T SecondNumber { get; set; }
//         T Plus();
//         T Minus();
//         T Multiple();
//         T Divide();

//     }
// }