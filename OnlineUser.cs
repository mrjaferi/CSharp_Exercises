using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Is there a problem with the site ?\n y = yas\n n = no");
        var input = Console.ReadLine();

        var condition = input == "y" ? "Check your internet, you are offline." : "You are online, please refresh the page.";

        Console.WriteLine(condition);
    }
}