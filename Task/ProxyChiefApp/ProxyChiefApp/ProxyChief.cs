using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProxyChiefApp
{
    internal class ProxyChief : IChief
    {
        private readonly Chief _chief;
        private IDictionary<int, string>? _statuses;

        public ProxyChief(Chief chief)
        {
            _chief = chief;
        }
        public IDictionary<int, string> GetStatuses()
        {
            // logging
            using (StreamWriter writeLog = new StreamWriter("StatusLog.txt", true, Encoding.UTF8))
            {
                writeLog.WriteLine(DateTime.Now);
            }
            if (_statuses is null)
            {
                _statuses = _chief.GetStatuses();
            }
            return _statuses;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _chief.GetOrders();
        }
    }
}
