using System;
using System.Collections.Generic;

namespace Homeework_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите размерность массива");
            int mass_l = int.Parse(Console.ReadLine());
            int[] mass = new int[mass_l];
            for (int i = 0; i < mass_l; i++)
            {
                Console.WriteLine($"Введите {i + 1} эллемент");
                mass[i] = int.Parse(Console.ReadLine());
            }

            Stack<int> stack = new Stack<int>(mass);

            foreach (int number in stack)
            {
                Console.WriteLine(number);
            }
        }
    }
}
