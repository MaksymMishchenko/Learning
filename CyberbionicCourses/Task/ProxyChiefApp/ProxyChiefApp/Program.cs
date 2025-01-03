using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProxyChiefApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IChief chief = new ProxyChief(new Chief());
            while (true)
            {
                Thread.Sleep(2000);
                Console.Clear();

                Console.WriteLine("Welcome to Chief\n");
                Console.WriteLine("========Orders========");

                IEnumerable<Order> orders = chief.GetOrders();

                foreach (Order order in orders)
                {
                    string status = chief.GetStatuses().First(s => s.Key == order.StatusId).Value;

                    Console.WriteLine($"Order: {order.Name}\t\t{status}");
                }
            }
        }
    }
}
