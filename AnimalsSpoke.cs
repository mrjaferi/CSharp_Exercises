using System;

namespace AnimalsSpoke
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dog = new Dog();
            var cat = new Cat();

            dog.Speak();
            cat.Speak();

            Console.WriteLine("Enter dog's name:");
            dog.Name = Console.ReadLine();
            Console.WriteLine(dog);
        }
    }

    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("This animal spoke ...");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Mewww");
        }
    }

    class Dog : Animal
    {
        public string Name { get; set; }
        public override void Speak()
        {
            Console.WriteLine("Hoppp");
        }

        public override string ToString()
        {
            return "Name is " + Name;
        }
    }
}