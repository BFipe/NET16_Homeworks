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
                    _fraction = 1;
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

        public FractionalNumber Add(FractionalNumber FractionalNumber2, out FractionalNumber Anwser)
        {
            Anwser = new FractionalNumber(Integer * FractionalNumber2.Fraction + FractionalNumber2.Integer * Fraction, Fraction * FractionalNumber2.Fraction);
            Anwser.Simplify(out Anwser);
            return Anwser; //Все равно не понял как работает это, если сюда спокойно можно подставить null
        }

        public FractionalNumber Substract(FractionalNumber FractionalNumber2, out FractionalNumber Anwser)
        {
            Anwser = new FractionalNumber(Integer * FractionalNumber2.Fraction - FractionalNumber2.Integer * Fraction, Fraction * FractionalNumber2.Fraction);
            Anwser.Simplify(out Anwser);
            return Anwser;
        }

        public FractionalNumber Multiply(FractionalNumber FractionalNumber2, out FractionalNumber Anwser)
        {
            Anwser = new FractionalNumber(Integer * FractionalNumber2.Integer, Fraction * FractionalNumber2.Fraction);
            Anwser.Simplify(out Anwser);
            return Anwser;
        }

        public FractionalNumber Divide(FractionalNumber FractionalNumber2, out FractionalNumber Anwser)
        {
            Anwser = new FractionalNumber(Integer * FractionalNumber2.Fraction, Fraction * FractionalNumber2.Integer);
            Anwser.Simplify(out Anwser);
            return Anwser;
        }
    }
}
