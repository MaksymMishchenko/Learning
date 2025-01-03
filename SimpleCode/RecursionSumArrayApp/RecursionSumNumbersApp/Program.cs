using System;

namespace RecursionSumNumbersApp
{
    class Program
    {
        private static int SumNubers(int value)
        {
            if (value < 10)
            {
                return value;
            }

            int digit = value % 10;
            int nextValue = value / 10;
            return digit + SumNubers(nextValue);
        }

        static void Main(string[] args)
        {
            int value = 561;
            var sumNumbers = SumNubers(value);
            Console.WriteLine(sumNumbers);
        }
    }
}
