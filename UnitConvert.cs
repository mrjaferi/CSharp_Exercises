using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConvert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //تعریف واحدهای مختلف
            const double cmToInch = 0.3937;
            const double inchToCm = 2.54;

            //دریافت واحد از کاربر
            Console.WriteLine("Enter the unit to convert from (cm /inch) :");
            string fromUnit = Console.ReadLine();

            Console.WriteLine("Enter the value :");
            double value = Convert.ToDouble(Console.ReadLine());

            //تبدیل به واحد دیگر
            double result;
            string toUnit;

            if (fromUnit == "cm" || fromUnit == "Cm" || fromUnit == "CM")
            {
                result = value * cmToInch;
                toUnit = "inch";
            }
            else
            {
                result = value * inchToCm;
                toUnit = "cm";
            }

            Console.WriteLine($"{value} {fromUnit} equals {result} {toUnit}");


            Console.ReadKey();
        }
    }
}
