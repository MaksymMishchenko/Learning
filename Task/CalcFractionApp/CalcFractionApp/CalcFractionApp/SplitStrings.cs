using System;
using CalcFractionApp.Model;

namespace CalcFractionApp
{
    public class SplitStrings
    {
        public Fraction SplitToChar(string fraction)
        {
           String[]str = fraction.Split("/");

            return new Fraction(decimal.Parse(str[0]), decimal.Parse(str[1]));
        }
        
    }
}
