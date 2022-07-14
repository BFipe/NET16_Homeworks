using System;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(x*-1);
            Console.ReadKey();
        }
    }
}
