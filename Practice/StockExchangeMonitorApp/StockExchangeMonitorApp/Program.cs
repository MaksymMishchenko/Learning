using System;

namespace StockExchangeMonitorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new StockExchangeMonitor();
            result.PriceChangeHandler = ShowPrice;
            result.Start();
        }

        static void ShowPrice(int price)
        {
            Console.WriteLine($"New price is: {price}");
        }
    }
}
