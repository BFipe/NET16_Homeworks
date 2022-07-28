using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6
{
    public class Phone
    {
        private int _weight;

        public Phone (string number, string model, int weight)
        {
             Number = number;
             Model = model;
            Weight = weight;
        }

        public string Number 
        { 
            get;
            set;
        }

        private string Model
        {
            get;
            set;
        }

        private int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value < 0)
                {
                    _weight = 0;
                }
                else
                {
                    _weight = value;
                }
            }
        }

        public void RecieveCall(string name)
        {
            Console.WriteLine($"You're calling {name}");
        }
    }
}
