using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputObjects_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car("Benz");

            ChangeColor(myCar, "red");

            var copiedCar = Copy(myCar);

            Console.WriteLine(myCar.Color);
            Console.WriteLine(myCar.Model);

            Console.ReadKey();
        }

        public static void ChangeColor(Car car, string color)
        {
            car.Color = color;
        }

        public static Car Copy(Car car)
        {
            return new Car(car.Model);
        }
    }

    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public Car(string model)
        {
            Model = model;
        }
    }
}
