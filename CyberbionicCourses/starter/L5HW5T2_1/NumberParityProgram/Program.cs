using System;

namespace NumberParityProgram
{
    class Program
    {
        static void Main()
        {   
            //first option
            Console.Write("Enter your number:");
            var value = Convert.ToInt32(Console.ReadLine());
            if ((value % 2) == 0)
            {
                Console.WriteLine("You entered {0}, it's even number", value);
            }
            else
            {
                Console.WriteLine("You entered {0}, it's not even number", value);
            }
            //second option
            
            if ((value & 1) == 0)
            {
                Console.WriteLine("You entered {0}, it's even number", value);
            }
            else
            {
                Console.WriteLine("You entered {0}, it's not even number", value);
            }

            Console.ReadKey();
        }
    }
}
