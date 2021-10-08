using System;
using CalcFractionApp.Model;

namespace CalcFractionApp
{
    class Display : IDisplay
    {
        public void Show(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}