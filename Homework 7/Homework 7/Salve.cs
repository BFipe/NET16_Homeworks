using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_7
{
    internal class Salve : Medicines
    {
        private int _salveVolume;
        public Salve(string name, int cost, int salveVolume) : base(name, cost)
        {
            SalveVolume = salveVolume;
        }

        public int SalveVolume
        {
            get
            {
                return _salveVolume;
            }
            set
            {
                if (value < 0)
                {
                    _salveVolume = 0;
                }
                else
                {
                    _salveVolume = value;
                }
            }
        }

        public override void HowToUse()
        {
            Console.WriteLine("Spread over dry clean skin 2 times in the morning and in the evening");
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Cost:{Cost}, Volume per pack: {SalveVolume}ml");
        }
    }
}
