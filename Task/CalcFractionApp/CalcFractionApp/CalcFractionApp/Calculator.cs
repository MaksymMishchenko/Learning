using System;
using CalcFractionApp.Model;

namespace CalcFractionApp
{
    public class Calculator
    {
        private int ReturnDenominator(Fraction a, Fraction b)
        {
            var den = 0;
            for (int i = 1; i <= a.Denominator * b.Denominator; i++)
            {
                if (i % a.Denominator == 0 && i % a.Denominator == 0)
                {
                    den = i;
                }
            }
            return den;
        }

        public Fraction Sum(Fraction first, Fraction second)
        {
            var den = ReturnDenominator(first,second);
            var result = (first.Numerator * second.Denominator +
                          second.Numerator * first.Denominator);
            return new Fraction(result,den);
        }
    }
}
