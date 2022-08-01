using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_7
{
    internal class Pills : Medicines
    {
        private int _pillsCount;
        public Pills(string name, int cost, int pillsCount) : base(name, cost)
        {
            PillsCount = pillsCount;
        }

        public int PillsCount
        {
            get
            {
                return _pillsCount;
            }
            set
            {
                if (value < 0)
                {
                    _pillsCount = 0;
                }
                else
                {
                    _pillsCount = value;
                }
            }
        }

        public override void HowToUse()
        {
            Console.WriteLine("Take 1 pill after the breakfast");
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Cost:{Cost}, Every pack have {PillsCount} pills");
        }
    }
}
