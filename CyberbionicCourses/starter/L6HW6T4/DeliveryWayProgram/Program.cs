using System;
using System.Diagnostics;

namespace DeliveryWayProgram
{
    class Program
    {
        static void Main()
        {   //display on screen string
            Console.Write("Enter the number of customers for delivery: ");
            //input user numeral
            int counter = Convert.ToInt32((Console.ReadLine()));
            int factorial = 1;
            //negative check
            if (counter < 0)
            {   //Error - negative check
                Console.WriteLine("The number of customers cannot be negative. Try again!");
            }
            else
            {
                do
                {
                    factorial *= counter--;
                }

                while (counter > 0);

                {   //display on screen result
                    Console.Write("Possible delivery routes: {0}", factorial);
                }
            }
            //Delay
            Console.ReadKey();
        }
    }
}