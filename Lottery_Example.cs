using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //دریافت تعداد شرکت کنندگان
            Console.WriteLine("Enter the number of participants :");
            int numOfParticipants = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n----------------------------------\n");

            //تولید عدد تصادفی و انتخاب برنده
            Random random = new Random();
            int winnerIndex = random.Next(numOfParticipants);

            //نمایش برنده قرعه کشی
            Console.WriteLine($"Lottery winner : number {winnerIndex}");

            Console.ReadKey();
        }
    }
}
