using System;

namespace SumOddLoopProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second number:");
            int b = Convert.ToInt32(Console.ReadLine()); 

            int sum = 0;

            for (int i = a + 1; i < b; i++)
            {
                sum += i;
            }

            Console.WriteLine("The sum of all numbers located between the indicated numbers - {0}", sum);
            Console.ReadKey();
        }
    }
}
