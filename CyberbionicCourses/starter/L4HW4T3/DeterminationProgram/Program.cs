using System;

namespace DeterminationProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number between 0 and 100");

            var userValue = Convert.ToInt32(Console.ReadLine());

            if (userValue >= 0 && userValue <= 14)
            {
                Console.WriteLine("You are in the first numerical range");
            }

            else if (userValue >= 15 && userValue <= 35)
            {
                Console.WriteLine("You are in the second numerical range");
            }

            else if (userValue >= 36 && userValue <= 50)
            {
                Console.WriteLine("You are in the third numerical range");
            }
            else if (userValue >= 50 && userValue <= 100)
            {
                Console.WriteLine("You are in the fourth numerical range");
            }
            else
            {
                Console.WriteLine("Error. Enter a value from 0 to 100");
            }

            Console.ReadKey();
        }
    }
}
