using System;
using CalcFractionApp.Model;

namespace CalcFractionApp
{
    public class Convertor
    {
        public Fraction CreateFraction(string fraction)
        {
           String[]parts = fraction.Split("/");

            return new Fraction(decimal.Parse(parts[0]), decimal.Parse(parts[1]));
        }
    }
}
