using WebShopApp.Data.Models;

namespace WebShopApp.Data.Interfaces
{
    public interface IOrders
    {
        void CreateOrder(Order order);
    }
}
