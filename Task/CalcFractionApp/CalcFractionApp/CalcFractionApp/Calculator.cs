using System;
using CalcFractionApp.Model;

namespace CalcFractionApp
{
    public class Calculator
    {
        private int _returnDenominator;

        public int ReturnDenominator(Fraction a, Fraction b)
        {
            for (int i = 1; i <= a.Denominator * b.Denominator; i++)
            {
                if (i % a.Denominator == 0 && i % a.Denominator == 0)
                {
                    _returnDenominator = i;
                }
            }
            return _returnDenominator;
        }

        public Fraction Sum(Fraction first, Fraction second)
        {
            ReturnDenominator(first,second);
            var result = (first.Numerator * second.Denominator +
                          second.Numerator * first.Denominator);
            return new Fraction(result,_returnDenominator);
        }
    }
}
