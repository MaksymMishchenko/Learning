using System;

namespace CalcFractionApp
{
    class Calculator
    {
        private Fraction _fraction1;
        private Fraction _fraction2;

        public Calculator(Fraction fraction1, Fraction fraction2)
        {
            _fraction1 = fraction1;
            _fraction2 = fraction2;
        }

        public int CommonDenominator()
        {
            int common=0;

            for (int i = 1; i <= _fraction1.Denominator * _fraction2.Denominator; i++)
            {
                if (i % _fraction1.Denominator == 0 && i % _fraction2.Denominator == 0)
                {
                    common = i;
                    return common;
                }
               
            }
            return 1;
        }

        public string SumFraction()
        {
            var fraction1Numerator = CommonDenominator() / _fraction1.Denominator *
                            _fraction1.Numerator;
            var fraction2Numerator = CommonDenominator() / _fraction2.Denominator *
                                     _fraction2.Numerator;
            var result = fraction1Numerator + fraction2Numerator;

            var stroka = result + "/" + CommonDenominator(); ;

            return stroka;
        }
    }
}
