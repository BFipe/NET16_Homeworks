using System;

namespace Homework_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation ( +  -  *  /  %)");
            char op = char.Parse(Console.ReadLine());
            switch (op)
            {
                case '+':
                    Console.WriteLine(x + y);
                    break;
                case '-':
                    Console.WriteLine(x - y);
                    break;
                case '*':
                    Console.WriteLine(x * y);
                    break;
                case '/':
                    Console.WriteLine(x / y);
                    break;
                case '%':
                    Console.WriteLine(x % y);
                    break;
                default:
                    Console.WriteLine("Wrong operation, try again");
                    break;
            }
        }
    }
}
