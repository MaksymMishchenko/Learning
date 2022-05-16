using System;

namespace MonthsApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Calendar App");
            Console.WriteLine(new string('-', 25));
            Console.WriteLine("Make your choice:\n 1 - see data by months, \n 2 - see data by days, \n 3 - see all the information ");
            var calendar = new Calendar();

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("You choose see data by months");
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("You choose see data by days");
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("You choose all the information by year");
                        foreach (var item in calendar)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    }
            }


        }
    }
}
