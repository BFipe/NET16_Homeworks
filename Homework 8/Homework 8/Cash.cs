using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8
{
    public class Cash : IPaymentMethod
    {
        private double _cashAmmountOfMoney;

        public Cash(double ammountOfMoney)
        {
            CashAmmountOfMoney = ammountOfMoney;
        }

        public double CashAmmountOfMoney
        {
            get { return _cashAmmountOfMoney; }
            set { _cashAmmountOfMoney = value; }
        }

        public void AddMoney(double ammountOfMoney)
        {
            CashAmmountOfMoney += ammountOfMoney;
            Console.WriteLine($"Sucсess! Added {ammountOfMoney} to your Cash, now you have {CashAmmountOfMoney}");
        }

        public bool IsPaymentPossible(double ammountOfMoney)
        {
            if (CashAmmountOfMoney >= ammountOfMoney)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MakePayment(double ammountOfMoney)
        {
            if (IsPaymentPossible(ammountOfMoney))
            {
                CashAmmountOfMoney -= ammountOfMoney;
                Console.WriteLine($"Sucсess! Now you have {CashAmmountOfMoney}");
            }
            else
            {
                Console.WriteLine($"Not enough money, you have only {CashAmmountOfMoney}");
            }
        }

        public void Balance()
        {
            Console.Write($"You have {CashAmmountOfMoney}");
        }

        public override string ToString()
        {
            return "Cash";
        }
    }
}
