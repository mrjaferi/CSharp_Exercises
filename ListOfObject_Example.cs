using System;

namespace ListOfObject_Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            // var product1 = new Product("Toy", 10);
            // var product2 = new Product("Paper", 35);
            // var product3 = new Product("Glue", 50);

            var productsList = new List<Product>()
            {
                new Product("Toy", 15),
            new Product("Paper", 45),
            new Product("Glue", 55)
        };
        
            productsList.Add(new Product("Toy", 10));
            productsList.Add(new Product("Paper", 35));
            productsList.Add(new Product("Glue", 50));

            foreach (var product in productsList)
            {
                Console.WriteLine(product);
            }

        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Product(string name, int quantity)
        {
            Quantity = quantity;
            Name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name} - Quantity: {Quantity}";
        }
    }
}