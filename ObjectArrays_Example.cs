using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectArrays_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object arrays
            // Anonymous objects

            var garage = new Car[]
            {
                new Car("Bens"),
                new Car("BMW"),
                new Car("Toyota")
            };

            foreach (var car in garage)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(car.Model);
                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }

    public class Car
    {
        public string Model { get; set; }
        public Car(string model)
        {
            Model = model;
        }
    }
}
