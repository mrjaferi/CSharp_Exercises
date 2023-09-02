using System;

namespace _4154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\t\"c# cofeeshop\"\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Menu:");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("#6- View the foods menu");
            Console.WriteLine("#7- View the drinks menu");
            Console.WriteLine("#8- Exit");

            // Getting input from the customer
            Console.ForegroundColor = ConsoleColor.Gray;
            var inputNumber = Convert.ToInt32(Console.ReadLine());
            Console.Beep(500, 250);
            Console.ResetColor();
            Console.Clear();

            // The names and prices of foods
            string[] foodsMenu = { "Pizaa", "Burger", "Pasta", "Steak" };
            double[] foodsPrice = { 220, 165, 120, 320 };

            // The names and prices of drinks
            string[] drinksMenu = { "cofee", "Espresso", "Soda", "Hot chocolate" };
            double[] drinksPrice = { 25, 30, 15, 38 };

            var orders = new string[foodsMenu.Length + drinksMenu.Length];
            var ordersPrice = new double[foodsMenu.Length + drinksMenu.Length];
            var numberOfPerOrder = new double[foodsMenu.Length + drinksMenu.Length];

            // We are developing the project
            //double pay;
            int selection;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\t\"Cofeeshop menu\"\n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Menu:");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("#6- View the foods menu");
                Console.WriteLine("#7- View the drinks menu");
                Console.WriteLine("#8- Exit");
                selection = Convert.ToInt32(Console.ReadLine());
                Console.Beep(500, 250);
                Console.Clear();

                // We are developing the project
                // int foodNumber = 0;
                // int drinkNumber = 0;
                // int orderCounter = 0;


                if (selection == 6)
                {
                    Console.Clear();
                    Console.WriteLine("foods menu:");
                    Console.WriteLine("1-Pizaa = 220T \n2-Burger = 165T \n3-Pasta = 120T \n4-Steak = 320T\n5-Exit");
                }

                else if (selection == 7)
                {
                    Console.Clear();
                    Console.WriteLine("drinks menu:");
                    Console.WriteLine("1-cofee = 25T \n2-Espresso = 30T \n3-Soda = 15T \n4-Hot chocolate = 38T\n5-Exit");
                }
                else
                {
                    Console.WriteLine("Thanks for coming to our resturant!");
                }

            } while (selection != 8);
        }
    }
}
