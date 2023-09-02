using System;

namespace DistanceConversion
{
    class program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("______________________________________________");
            Console.WriteLine("Another program from your friend \"Yasin Jaferi\"");
            Console.ResetColor();

            // بدست آوردن مساحت برحسب مایل
            Console.WriteLine("\nEnter the distance in miles :");
            var miles = Convert.ToDouble(Console.ReadLine());


            // تبدیل به کلومتر
            var kilometers = miles * 1.60934;

            // نمایش نتیجه
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n --> {miles} miles is equal to {kilometers} kilometers.");
            Console.ResetColor();
        }
    }
}