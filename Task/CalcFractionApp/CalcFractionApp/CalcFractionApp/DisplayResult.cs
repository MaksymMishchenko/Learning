using System;

namespace CalcFractionApp
{
    public class DisplayResult
    {
        private Calculator _result;

        public DisplayResult()
        {
            _result = new Calculator(new Fraction() { Denominator = 2, Numerator = 1 }, new Fraction() { Denominator = 5, Numerator = 2 });
            
        }

        public void Show()
        {
            Console.WriteLine(_result.SumFraction());
        }

    }
}