using System;

namespace CurrencyConversionProgram
{
    class Program
    {
        static double Dev(double money, double course)
        {
            return Math.Round(money / course, 2);
        }
        static void Main()
        {
            Console.Write("Enter the amount in UAH to be converted: ");
            var value = Console.ReadLine();
            var money = Convert.ToDouble(value);

            Console.Write("Convert to: USD, EUR, PLN \nEnter the currency code: ");
            string curCode = Console.ReadLine();

            switch (curCode)
            {
                case "USD":
                {
                    var result = Dev(money, 26.80);
                    Console.WriteLine("Result: for {0} UAH you can buy {1} USD", money, result);
                    break;
                }

                case "EUR":
                {
                    var result = Dev(money, 29.90);
                        Console.WriteLine("Result: for {0} UAH you can buy {1} EUR", money, result);
                        break;
                    }
                case "PLN":
                {
                    var result = Dev(money, 6.65);
                    Console.WriteLine("Result: for {0} UAH you can buy {1} PLN", money, result);
                    break;
                }
                default:
                {
                    Console.WriteLine("You entered the wrong currency. Please, try enter 'USD','EUR' OR 'PLN'.");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
