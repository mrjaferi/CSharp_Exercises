using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string authorName;
            string topic;
            string articleText;

            Console.WriteLine("Enter author name :");
            authorName = Console.ReadLine();

            Console.WriteLine("Enter topic :");
            topic = Console.ReadLine();

            Console.WriteLine("Enter article text :");
            articleText = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"\nAuthor name: {authorName}\nTopic: {topic}\nArticle text: {articleText}");

            Console.ReadKey();
        }
    }
}
