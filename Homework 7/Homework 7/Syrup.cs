using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_7
{
    internal class Syrup : Medicines
    {
        public Syrup(string name, int cost, string packageType) : base(name, cost)
        {
            PackageType = packageType;
        }

        public  string PackageType { get; set; }

        public override void HowToUse()
        {
            Console.WriteLine("Take 1ml of the syrup and swallow with a cup of water");
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Cost:{Cost}, Package type: {PackageType}");
        }
    }
}
