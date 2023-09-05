using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Specifications of women's pants
            Shirt versace = new Shirt();

            versace.model = "VERSACE";
            versace.size = "XXL";
            versace.type = "summer";
            versace.color = "white";
            versace.collarType = "round";
            versace.numberButtons = 5;
            versace.sizeButtons = 2;
            versace.numberPockets = 1;


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Model: {versace.model} \t Size: {versace.size} \t Type: {versace.type} \t Color: {versace.color} \n" +
                $"Collar type: {versace.collarType} \t Number of buttons: {versace.numberButtons} \t The size of the buttons: {versace.sizeButtons} \t " +
                $"Number of pockets: {versace.numberPockets}\n");


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Shirt.ForWomen();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------------------------");
            Console.ResetColor();

            //Specifications of men's pants
            Pant slash = new Pant();

            slash.model = "SLASH";
            slash.size = "100";
            slash.type = "summer";
            slash.color = "black";
            slash.numberPockets = 6;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Model: {slash.model} \t Size: {slash.size} \t Type: {slash.type} \t Color: {slash.color} \nNumber of pockets: {slash.numberPockets}\n");


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Shirt.ForMen();
            Console.ResetColor();

            Console.ReadKey();
        }
    }

    public class Shirt : Clothes
    {
        public string collarType;
        public int numberButtons;
        public int sizeButtons;
        public int numberPockets;
    }

    abstract public class Clothes
    {
        public string type;
        public string color;
        public string size;
        public string model;

        public static void ForMen()
        {
            Console.WriteLine("This is men's clothing.");
        }

        public static void ForWomen()
        {
            Console.WriteLine("This is women's clothing.");
        }
    }

    sealed public class Pant : Clothes
    {
        public int numberPockets;
    }
}
