using System;
using CalcFractionApp.Model;

namespace CalcFractionApp
{
    class Display : IDisplay
    {
        public void Show(Fraction obj)
        {
            Console.WriteLine(obj.Numerator+"/"+obj.Denominator);
        }
    }
}