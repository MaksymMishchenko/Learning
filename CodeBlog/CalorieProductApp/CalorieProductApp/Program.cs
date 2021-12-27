using System;

namespace CalorieProductApp
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Программа подсчета калорийности продуктов");
                Console.WriteLine("Команды: 'a' - новый продукт, 'r' - прочитать файл, 'q' - выход");
                string str = Console.ReadLine();

                IUserProduct product = new UserProduct();
                CPanel(product, str);

            } while (true);
        }

        static void CPanel(IUserProduct prod, string command)
        {
            switch (command)
            {
                case "a":
                    {
                        Console.WriteLine("Введите продукт:");
                        string product = Console.ReadLine();

                        Console.WriteLine("Введите калорийность: ");
                        double kCal = double.Parse(Console.ReadLine());

                        Console.WriteLine("Введите употребленное количество в граммах: ");
                        double weight = double.Parse(Console.ReadLine());

                        prod.Add(product, kCal, weight);
                        break;
                    }
                case "r":
                    {
                        prod.PrintFile();
                        break;
                    }
                case "q":
                    {
                        prod.Quit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Введена неверная команда. Повторите попытку снова");
                        break;
                    }
            }
        }
    }
}

