using System;

namespace CalcFractionApp
{
    class ConsoleWrapper : IConsoleWrapper
    {
        public void Show(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}