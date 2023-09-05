using System;

namespace Restaurant_Enum
{
    class Program
    {
        public static void Main(string[] args)
        {
            RestaurantOrder order1 = new RestaurantOrder();

            order1.CustomerName = "John";
            order1.Food = FoodType.Pizza;
            order1.Quantity = 2;

            Console.WriteLine($"Customer Name: {order1.CustomerName}");
            Console.WriteLine($"Food: {order1.Food}");
            Console.WriteLine($"Quantity: {order1.Quantity}");
        }
    }

    public class RestaurantOrder
    {
        public string CustomerName { get; set; }
        public FoodType Food { get; set; }
        public int Quantity { get; set; }
    }

    public enum FoodType
    {
        Pizza,
        Burger,
        Sandwich,
        Pasta
    }
}