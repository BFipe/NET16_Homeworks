using System;

namespace Homework_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("Введите размерность массива");
            int mass_l = int.Parse(Console.ReadLine());
            int[] mass = new int[mass_l];

            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1} эллемент");
                mass[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            for (int i = 0; i < mass_l; i++)
            {
                if (i % 2 != 0) sum += mass[i];
            }

            Console.WriteLine($"Сумма нечётных эллементов массива = {sum}");

            int min = mass[0];

            for (int i = 0; i < mass_l; i++)
            {
                if (min > mass[i]) min = mass[i];
            }

            Console.WriteLine($"Минимальный эллемент массива - {min}");
        }
    }
}
