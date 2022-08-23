using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_10
{
    public delegate void NotifyWarmUpCompleted(string dishName, int minuites);
    internal class Microwave
    {
        public event NotifyWarmUpCompleted WarmUpCompleted;


        public void WarmUp(string dishName, int minuites)
        {
            if (minuites < 0)
            {
                return;
            }
            Console.WriteLine($"Microvawing {dishName} for {minuites} min. mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm");

            if (WarmUpCompleted != null)
            {
                WarmUpCompleted.Invoke(dishName, minuites);
            }
        }
    }
}
