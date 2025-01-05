using System;
using System.Runtime.InteropServices;

namespace MethodCalculateProgram
{
    class Program
    {
        //create method Calculate - signature and body
        static int Calculate(int first, int second, int third)
        {
            //return the value of the method arguments
            return (first + second + third) / 2;
        }

        static void Main()
        {  //set the value to our variables
            int first = 2, second = 3, third = 5;
            int result = Calculate(first, second, third);
            Console.WriteLine("Arithmetic mean of argument values: {0}", result);
            Console.Write("Press any key to close console window");
            Console.ReadKey();

        }
    }
}