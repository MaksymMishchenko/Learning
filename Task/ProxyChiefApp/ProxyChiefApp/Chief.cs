using System;
using System.Collections.Generic;
using System.Threading;

namespace ProxyChiefApp
{
    internal class Chief
    {
        public Dictionary<int, string> GetStatuses()
        {
            Dictionary<int, string> statuses = new Dictionary<int, string>();
            statuses.Add(1, "ready");
            statuses.Add(2, "not ready");
            statuses.Add(3, "preparing");

            Thread.Sleep(2000);

            return statuses;
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>
            {
                new Order() { Name = "Hot Dog", StatusId = RandomizeStatus()},
                new Order(){Name = "Pizza", StatusId = RandomizeStatus()},
                new Order(){Name = "Sandwich", StatusId = RandomizeStatus()}
            };
            return orders;
        }

        private static int RandomizeStatus() => new Random().Next(1, 4);
    }
}
