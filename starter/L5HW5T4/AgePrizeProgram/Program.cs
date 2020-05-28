using System;

namespace AgePrizeProgram
{
    class Program
    {
        static void Main()
        {
            string percent1 = "10%",
                   percent2 = "15%",
                   percent3 = "25%",
                   percent4 = "35%",
                   percent5 = "45%",
                   percent6 = "55%";

            Console.Write("Enter your length of service: ");
            var age = Convert.ToInt32(Console.ReadLine());

            if (age < 0)
            {
                Console.WriteLine("Your yellowness cannot be negative!");
            }
            else if (age < 5)
            {
                Console.WriteLine("Your bonus is {0} from the salary", percent1);
            }
            else if (age == 5 && age < 10)
            {
                Console.WriteLine("Your bonus is {0} from the salary", percent2);
            }
            else if (age == 10 && age < 15)
            {
                Console.WriteLine("Your bonus is {0} from the salary", percent3);
            }
            else if (age == 15 && age < 20)
            {
                Console.WriteLine("Your bonus is {0} from the salary", percent4);
            }
            else if (age == 20 && age < 25)
            {
                Console.WriteLine("Your bonus is {0} from the salary", percent5);
            }
            else if (age == 25 || age > 25)
            {
                Console.WriteLine("Your bonus is {0} from the salary. Congratulations!", percent6);
            }
            else
            {
                Console.WriteLine("You are not entitled to a bonus!");
            }

            Console.ReadKey();
        }
    }
}
