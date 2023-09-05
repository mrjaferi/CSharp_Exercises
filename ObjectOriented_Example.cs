using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented_Example
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Car myCar = new Car();
            string brand = myCar.brand = "MVM";
            string model = myCar.model = "X22";
            string color = myCar.color = "black";
            string year = myCar.year = "2022";

            //Console.WriteLine(myCar.brand + "\t" + myCar.model + "\t" + myCar.color + "\t" + myCar.year);

            Car.Print(brand, model, color, year);

            Car.Start();
            Car.Stop();
            Car.Repair();

            Console.ReadKey();
        }
    }

    public class Car
    {
        public string brand;
        public string year;
        public string color;
        public string model;

        public static void Print(string brand, string model, string color, string year)
        {
            Console.WriteLine(brand + "\t" + model + "\t" + color + "\t" + year);
        }

        public static void Start()
        {
            Console.WriteLine("The car started...");
        }

        public static void Stop()
        {
            Console.WriteLine("The car stoped...");
        }

        public static void Repair()
        {
            Console.WriteLine("The car needs repairs.");
        }
    }
}
