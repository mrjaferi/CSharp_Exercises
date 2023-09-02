using System;

namespace CsharpClimbing
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if (n == 1 && m == 1)
            {
                Console.WriteLine(0);
            }
            else if(n==1&&m==2)
            {
                Console.WriteLine(1);
            }
            else if(n==1&&m==3)
            {
                Console.WriteLine(1);
            }
            else if(n==1&&m==4)
            {
                Console.WriteLine(2);
            }
            else if(n==2&&m==1)
            {
                Console.WriteLine(1);
            }
            else if(n==2&&m==2)
            {
                Console.WriteLine(0);
            }
            else if(n==2&&m==3)
            {
                Console.WriteLine(2);
            }
            else if(n==2&&m==4)
            {
                Console.WriteLine(1);
            }
            else if(n==3&&m==1)
            {
                Console.WriteLine(1);
            }
            else if(n==3&&m==2)
            {
                Console.WriteLine(2);
            }
            else if(n==3&&m==3)
            {
                Console.WriteLine(0);
            }
            else if(n==3&&m==4)
            {
                Console.WriteLine(1);
            }
            else if(n==4&&m==1)
            {
                Console.WriteLine(2);
            }
            else if(n==4&&m==2)
            {
                Console.WriteLine(1);
            }
            else if(n==4&&m==3)
            {
                Console.WriteLine(1);
            }
            else if(n==4&&m==4)
            {
                Console.WriteLine(0);
            }
        }
    }
}