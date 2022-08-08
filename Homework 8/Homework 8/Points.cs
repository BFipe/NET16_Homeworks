using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8
{
    public class Points : IPaymentMethod
    {
        private double _pointsAmmountOfPoints;

        public Points(double ammountOfPoints)
        {
            PointsAmmountOfPoints = ammountOfPoints;
        }

        public double PointsAmmountOfPoints
        {
            get
            {
                return _pointsAmmountOfPoints;
            }
            set
            {
                if (value < 0)
                {
                    _pointsAmmountOfPoints = 0;
                }
                else
                {
                    _pointsAmmountOfPoints = value;
                }
            }
        }

        public void AddMoney(double ammountOfPoints)
        {
            PointsAmmountOfPoints += ammountOfPoints;
            Console.WriteLine($"Added {ammountOfPoints} to your Points, now you have {PointsAmmountOfPoints}");
        }

        public bool IsPaymentPossible(double ammountOfPoints)
        {
            if (PointsAmmountOfPoints >= ammountOfPoints * 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MakePayment(double ammountOfPoints)
        {
            if (IsPaymentPossible(ammountOfPoints))
            {
                PointsAmmountOfPoints -= ammountOfPoints * 3;
                Console.WriteLine($"Sucсess! Now you have {PointsAmmountOfPoints}");
            }
            else
            {
                Console.WriteLine($"Not enough Points, you have only {PointsAmmountOfPoints}");
            }
        }
        public void Balance()
        {
            Console.Write($"You have {PointsAmmountOfPoints}");
        }

        public override string ToString()
        {
            return "Points";
        }
    }
}
