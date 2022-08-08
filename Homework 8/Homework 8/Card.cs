using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8
{
    public class Card : IPaymentMethod
    {
        private double _cardAmmountOfMoney;

        public Card(string cardName, double ammountOfMoney)
        {
            CardAmmountOfMoney = ammountOfMoney;
            CardName = cardName;
        }
        public string CardName { get; set; }
        public double CardAmmountOfMoney
        {
            get { return _cardAmmountOfMoney; }
            set { _cardAmmountOfMoney = value; }
        }

        public void AddMoney(double ammountOfMoney)
        {
            CardAmmountOfMoney += ammountOfMoney;
            Console.WriteLine($"Sucсess! Added {ammountOfMoney} to your card \"{CardName}\", now you have {CardAmmountOfMoney}");
        }

        public bool IsPaymentPossible(double ammountOfMoney)
        {
            if (CardAmmountOfMoney >= ammountOfMoney)
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
                CardAmmountOfMoney -= ammountOfMoney;
                Console.WriteLine($"Sucсess! Now you have {CardAmmountOfMoney} on your card");
            }
            else
            {
                Console.WriteLine($"Not enough money, you have only {CardAmmountOfMoney} on your card");
            }
        }

        public void Balance()
        {
            Console.Write($"You have {CardAmmountOfMoney}");
        }

        public override string ToString()
        {
            return $"card {CardName}";
        }

      
    }
}
