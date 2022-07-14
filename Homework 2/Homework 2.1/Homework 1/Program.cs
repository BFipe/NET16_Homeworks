using System;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anwser = 1;
            Console.WriteLine("Enter your number");
            int x = int.Parse(Console.ReadLine());
            for (int i = 2; i <= x; i++)
            {
                anwser = anwser * i;
            }
            Console.WriteLine($"Factorial of {x} is {anwser}");
            Console.ReadKey();
        }
    }
}
