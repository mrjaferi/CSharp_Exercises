using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence :");
            string sentence = Console.ReadLine();

            //Split the sentence into words
            string[] words = sentence.Split(' ');

            //Reverse each word and output the result
            Console.WriteLine("Output :");

            for (int i = 0; i < words.Length; i++)
            {
                char[] wordChars = words[i].ToCharArray();
                Array.Reverse(wordChars);
                Console.WriteLine(new string(wordChars) + " ");
            }

            Console.ReadKey();
        }
    }
}
