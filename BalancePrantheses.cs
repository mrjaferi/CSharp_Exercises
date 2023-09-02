﻿using System;
using System.Collections.Generic;

namespace BalancePrantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sequence of parentheses, aqualads, brackets and characters:");
            string input = Console.ReadLine();

            if (Orders.IsValidExpression(input))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The characters are entered correctly!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The characters are entered incorrectly!");
                Console.ResetColor();
            }
        }

    }

    public class Orders
    {
        public static bool IsValidExpression(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (IsOpeningCharacter(c))
                {
                    stack.Push(c);
                }
                else if (IsClosingCharacter(c))
                {
                    if (stack.Count == 0 || !IsMatchingPair(stack.Peek(), c))
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }

        public static bool IsOpeningCharacter(char c)
        {
            return c == '(' || c == '{' || c == '[' || c == '/';
        }

        public static bool IsClosingCharacter(char c)
        {
            return c == ')' || c == '}' || c == ']' || c == '\\';
        }

        public static bool IsMatchingPair(char opening, char closing)
        {
            return (opening == '(' && closing == ')') ||
                   (opening == '{' && closing == '}') ||
                   (opening == '[' && closing == ']') ||
                   (opening == '/' && closing == '\\');
        }
    }
}