using System;
using System.Runtime.InteropServices;

namespace PowerTwoProgram
{
    class Program
    {
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (Step(a)) Console.WriteLine("The number - {0} is a power of two!", a);
            else Console.WriteLine("The number - {0} is not a power of two!", a);
            Console.ReadKey();
        }
        public static bool Step(int a)
        {
            if (a == 2) return true;
            else if (a % 2 == 0) return Step(a / 2);
            else return false;
        }
    }
}
