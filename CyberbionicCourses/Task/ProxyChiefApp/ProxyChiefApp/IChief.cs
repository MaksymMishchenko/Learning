using System.Collections.Generic;

namespace ProxyChiefApp
{
    internal interface IChief
    {
        IDictionary<int, string> GetStatuses();

        IEnumerable<Order> GetOrders();
    }
}
