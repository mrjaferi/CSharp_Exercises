using System;

namespace Polymorphism_Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            var car = new Car();
            var bicycle = new Bicycle();

            Vehicle[] vehicles = { car, bicycle };

            foreach (var Vehicle in vehicles)
            {
                Vehicle.Go();
            }
        }
    }

    public class Vehicle
    {
        public virtual void Go()
        {
            Console.WriteLine("The vehicle is moving.");
        }
    }

    public class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving.");
        }
    }

    public class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving.");
        }
    }
}