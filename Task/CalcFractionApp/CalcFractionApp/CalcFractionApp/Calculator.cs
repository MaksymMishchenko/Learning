using System;
using CalcFractionApp.Model;

namespace CalcFractionApp
{
    class Calculator
    {
        private Fraction _fraction1;
        private Fraction _fraction2;


        public Calculator()
        {
            InitialFraction();
        }

        void InitialFraction()
        {
            _fraction1 = new Fraction( 1,2);
            _fraction2 = new Fraction(2,5);
        }


        public int CommonDenominator()
        {
            int common=0;

            for (int i = 1; i <= _fraction1.Denominator * _fraction2.Denominator; i++)
            {
                if (i % _fraction1.Denominator == 0 && i % _fraction2.Denominator == 0)
                {
                    common = i;
                    
                }
            }
            return common;
        }

        public double SumFraction()
        {
            //var fraction1Numerator = CommonDenominator() / _fraction1.Denominator *
            //                _fraction1.Numerator;
            //var fraction2Numerator = CommonDenominator() / _fraction2.Denominator *
            //                         _fraction2.Numerator;
            //var result = fraction1Numerator + fraction2Numerator;
            //
            //var stroka = result + "/" + CommonDenominator(); ;


            var result = (_fraction1.Numerator * _fraction2.Denominator +
                             _fraction2.Numerator * _fraction1.Denominator)/CommonDenominator();
            return result;
        }
    }
}
