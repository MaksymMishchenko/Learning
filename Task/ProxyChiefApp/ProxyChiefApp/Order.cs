using System;

namespace ProxyChiefApp
{
    class Order
    {
        public Guid Type { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public int StatusId { get; set; } = 0;
    }
}
