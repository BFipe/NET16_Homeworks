using System;

namespace Homework_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Microwave microwave = new Microwave();
            microwave.WarmUpCompleted += WarmUpCompletedHandler;
            microwave.WarmUp("chickmn ngts", 6);
        }

        private static void WarmUpCompletedHandler(string dishName, int minuites)
        {
            Console.WriteLine($"i microwaved ur {dishName} for {minuites} min. Its still cold but i microvawed ur plate");
        }
    }
}
