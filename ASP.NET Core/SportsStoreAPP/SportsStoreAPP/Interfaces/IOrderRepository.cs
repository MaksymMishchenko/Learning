using SportsStoreAPP.Models;

namespace SportsStoreAPP.Interfaces
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
