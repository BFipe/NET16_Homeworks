using System;

namespace Homework_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rasst, shir, kolvo = 0;
            while (kolvo <= 1)
            {
                Console.WriteLine("Введите кол-во столбов (не меньше 2)");
                kolvo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите расстояние между столбами (в м)");
            rasst = int.Parse(Console.ReadLine()) * 100;
            Console.WriteLine("Введите ширину столбов (в см)");
            shir = int.Parse(Console.ReadLine());
            Console.WriteLine($"Расстояние между столбами - {shir * (kolvo - 2) + rasst * (kolvo - 1)}");
            Console.ReadKey();
        }
    }
}
