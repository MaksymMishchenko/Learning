using System;

namespace TheoryNumberMethod
{
    class Program
    {
        static void Number(int x)
        {
            //positive or negative check
            Console.WriteLine(x >= 0 ? "You entered a positive number" : "You entered a negative number");
        }
        static void Main()
        {
            Console.Write("Enter the number: ");

            string value = Console.ReadLine();
            int userNum = Convert.ToInt32(value);
            Number(userNum);
            //delay
            Console.ReadKey();
        }
    }
}
