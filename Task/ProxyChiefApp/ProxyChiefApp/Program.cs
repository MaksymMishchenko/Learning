using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ProxyChiefApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Chief chief = new Chief();
            while (true)
            {
                Thread.Sleep(2000);
                Console.Clear();

                Console.WriteLine("Welcome to Chief\n");
                Console.WriteLine("========Orders========");

                List<Order> orders = chief.GetOrders();

                foreach (Order order in orders)
                {
                    string status = chief.GetStatuses().First(s => s.Key == order.StatusId).Value;

                    Console.WriteLine($"Order: {order.Name}\t\t{status}");
                }
            }
        }
    }
}
