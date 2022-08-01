using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_7
{
    internal abstract class Medicines
    {
        private int _cost;
        public Medicines(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; }

        public int Cost
        {
            get { return _cost; }
            set
            {
                if (value < 0)
                {
                    _cost = 0;
                }
                else
                {
                    _cost = value;
                }
            }
        }

        public abstract void Print();
        public abstract void HowToUse();



    }
}
