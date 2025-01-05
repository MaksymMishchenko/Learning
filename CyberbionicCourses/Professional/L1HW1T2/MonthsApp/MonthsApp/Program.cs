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
                        Console.Write("You choose see data by months.\n Enter month number: ");
                        int month = int.Parse(Console.ReadLine());

                        foreach (var item in calendar.GetDataByMonths(month))
                        {
                            Console.Write(item);
                        }

                        break;
                    }

                case 2:
                    {
                        Console.Write("You choose see data by days.\n Enter count of days: ");
                        int days = int.Parse(Console.ReadLine());

                        foreach (var item in calendar.GetDataByDays(days))
                        {
                            Console.Write(item);
                        }

                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("You choose all the information by year: ");
                        foreach (var item in calendar)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    }
                default:
                {
                    Console.WriteLine("You made the wrong choice. Please? try again.");
                    break;
                }
            }
        }
    }
}
