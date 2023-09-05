using System;

namespace Interface_Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            var eagle = new Eagle();
            var rabbit = new Rabbit();
            var fish = new Fish();

            eagle.Hunt();
            rabbit.Run();
            fish.Hunt();
            fish.Run();
        }
    }

    public class Rabbit : IPrey
    {
        public void Run()
        {
            Console.WriteLine("Rabbit is running.");
        }
    }

    interface IPrey
    {
        void Run();
    }

    interface IPredator
    {
        void Hunt();
    }

    public class Fish : IPredator, IPrey
    {
        public void Hunt()
        {
            Console.WriteLine("Fish is hunting.");
        }

        public void Run()
        {
            Console.WriteLine("Fish is running.");
        }
    }

    public class Eagle : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("Eagle is hunting.");
        }
    }
}