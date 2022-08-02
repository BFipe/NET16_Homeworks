using System;
using System.Collections.Generic;
using System.Text;

namespace Additional_task
{
    internal class FractionalNumber
    {
        private int _fraction;
        public FractionalNumber(int integer, int fraction)
        {
            Integer = integer;
            Fraction = fraction;
        }
        public int Fraction
        {
            get { return _fraction; }
            set
            {
                if (value <= 0)
                {
                    while (value < 0)
                    {
                        value = int.Parse(Console.ReadLine());
                    }
                    _fraction = value;
                }
                else
                {
                    _fraction = value;
                }
            }
        }

        public int Integer { get; set; }

        public FractionalNumber Simplify(out FractionalNumber FractionalNumberSimplified)
        {
            int integerSimplified = Integer;
            int fractionSimplified = Fraction;
            int leastNumber;

            if (Fraction > Integer)
            {
                leastNumber = Integer;
            }
            else
            {
                leastNumber=Fraction;
            }


            for (int i = 2; i <= leastNumber; i++)
            {
                if (Fraction % i == 0 && Integer % i == 0)
                {
                    integerSimplified = Integer / i;
                    fractionSimplified = Fraction / i;
                }
            }
            FractionalNumberSimplified = new FractionalNumber(integerSimplified, fractionSimplified);
            return FractionalNumberSimplified;
        }

        public FractionalNumber Add(FractionalNumber FractionalNumber, out FractionalNumber Anwser)
        {
            Anwser = new FractionalNumber(Integer * FractionalNumber.Fraction + FractionalNumber.Integer * Fraction, Fraction * FractionalNumber.Fraction);
            Anwser.Simplify(out Anwser);
            return Anwser; //Все равно не понял как работает это, если сюда спокойно можно подставить null
        }

        public FractionalNumber Substract(FractionalNumber FractionalNumber, out FractionalNumber Anwser)
        {
            Anwser = new FractionalNumber(Integer * FractionalNumber.Fraction - FractionalNumber.Integer * Fraction, Fraction * FractionalNumber.Fraction);
            Anwser.Simplify(out Anwser);
            return Anwser;
        }

        public FractionalNumber Multiply(FractionalNumber FractionalNumber, out FractionalNumber Anwser)
        {
            Anwser = new FractionalNumber(Integer * FractionalNumber.Integer, Fraction * FractionalNumber.Fraction);
            Anwser.Simplify(out Anwser);
            return Anwser;
        }

        public FractionalNumber Divide(FractionalNumber FractionalNumber, out FractionalNumber Anwser)
        {
            Anwser = new FractionalNumber(Integer * FractionalNumber.Fraction, Fraction * FractionalNumber.Integer);
            Anwser.Simplify(out Anwser);
            return Anwser;
        }

        public void Double()
        {
            
            double Anwser = (double)Integer / (double)Fraction;
            Console.WriteLine($"Double variant for a fraction - {Anwser}");
        }
    }
}
