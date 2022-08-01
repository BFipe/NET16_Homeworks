using System;

namespace Additional_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FractionalNumber test1 = new FractionalNumber(22, 44);
            FractionalNumber test2 = new FractionalNumber(11, 56);
            FractionalNumber anwser;

            Console.WriteLine($"{test1.Integer}/{test1.Fraction}");
            test1.Simplify(out test1); //Я не понял как изменять значения сразу через класс, поэтому юзаю out
            Console.WriteLine($"{test1.Integer}/{test1.Fraction}");

            Console.WriteLine("_________________________");

            test1.Divide(test2, out anwser);
            Console.WriteLine($"Divide - {anwser.Integer}/{anwser.Fraction}");

            test1.Multiply(test2, out anwser); 
            Console.WriteLine($"Multiply - {anwser.Integer}/{anwser.Fraction}");

            test1.Add(test2, out anwser);
            Console.WriteLine($"Add - {anwser.Integer}/{anwser.Fraction}");

            test1.Substract(test2, out anwser);
            Console.WriteLine($"Substract - {anwser.Integer}/{anwser.Fraction}");
        }
    }
}
