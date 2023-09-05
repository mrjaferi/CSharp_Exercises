using System;
// using System.

namespace List_Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Generic lists
            List<string> foods = new List<string>();

            // Add method
            foods.Add("pizza");
            foods.Add("hamburger");
            foods.Add("hotdog");
            foods.Add("fries");
            foods.Add("hotdog");

            // Remove method
            foods.Remove("pizza");

            // Insert method
            foods.Insert(1, "sushi");
            foods.Insert(foods.IndexOf("hotdog") + 1, "sushi");

            // IndexOf method
            Console.WriteLine(foods.IndexOf("fries"));


            // LastIndexOf method
            Console.WriteLine(foods.LastIndexOf("hotdog"));

            // Contains method
            Console.WriteLine(foods.Contains("pizza"));
            Console.WriteLine(foods.Contains("pizzas"));

            // Count method
            Console.WriteLine(foods.Count);

            // Sort method
            foods.Sort();

            // Reverse method
            foods.Reverse();

            // Clear method
            foods.Clear();

            // ToArray method
            var myArray = foods.ToArray();


            foreach (var food in foods)
            {
                Console.WriteLine(food);
            }
        }
    }
}