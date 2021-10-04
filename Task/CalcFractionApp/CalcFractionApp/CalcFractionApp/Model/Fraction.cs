using System;
using System.Dynamic;

namespace CalcFractionApp.Model
{
    public class Fraction
    {
        public Fraction(double numerator, double denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public double Numerator { get; }
        public double Denominator { get; }

    }
}