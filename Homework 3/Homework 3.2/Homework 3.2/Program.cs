using System;

namespace Homework_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers in a row");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > 100 && b>100)
            {
                Console.WriteLine("A and B are greater than 100");
            }
            if (a % 2 == 0 ^ b % 2 == 0)
            {
                Console.WriteLine("Only one of the numbers A and B is even");
            }
            if (a > 0 || b > 0)
            {
                Console.WriteLine("Either A or B is greater than 0");
            }
            if (a % 3 == 0 && b % 3 == 0 && c % 3 == 0)
            {
                Console.WriteLine("Every number (A B C) is divisible by 3");
            }
            if ((a > 50 && b > 50 & c < 50) || (a < 50 && b > 50 & c < 50) || (a < 50 && b > 50 & c > 50))
            {
                Console.WriteLine("Only one of the number (A B C) less than 50");
            }
            if (a < 0 || b < 0 || c < 0)
            {
                Console.WriteLine("One of the number (A B C) is less than 0");
            }
        }
    }
}
