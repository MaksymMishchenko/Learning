using System;
using CalcFractionApp.Model;

namespace CalcFractionApp
{
    public class DisplayResult
    {
        private Calculator _result;

        public DisplayResult()
        {
            _result = new Calculator();
            
        }

        public void Show()
        {
            Console.WriteLine(_result.SumFraction());
        }

    }
}