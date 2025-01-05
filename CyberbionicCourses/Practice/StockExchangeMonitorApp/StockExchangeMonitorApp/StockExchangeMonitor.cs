using System;
using System.Threading;

namespace StockExchangeMonitorApp
{
    class StockExchangeMonitor
    {
        public delegate void PriceChange(int price);
        public PriceChange PriceChangeHandler { get; set; }

        public void Start()
        {
            while (true)
            {
                int bankOfAmerica = new Random().Next(50);
                PriceChangeHandler(bankOfAmerica);
                Thread.Sleep(3000);
            }
        }
    }
}
