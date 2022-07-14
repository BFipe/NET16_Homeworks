using System;

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int y = int.Parse(Console.ReadLine());
            if (x>y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
            while (x<=y)
            {
                Console.WriteLine(x);
                x++;
            }
            Console.ReadKey();
        }
    }
}
