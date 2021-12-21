using System;

namespace OperatorExplicitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            byte argument = 1;

            //явное преобразование byte-to-Digit
            Digit digit = (Digit)argument;

            Console.WriteLine(digit);
        }
    }
}
