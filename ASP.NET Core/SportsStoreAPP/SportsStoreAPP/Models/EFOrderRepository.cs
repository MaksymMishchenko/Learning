using Microsoft.EntityFrameworkCore;
using SportsStoreAPP.Interfaces;

namespace SportsStoreAPP.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private ApplicationDbContext _context;
        public EFOrderRepository(ApplicationDbContext ctx)
        {
            _context = ctx;
        }
        public IQueryable<Order> Orders => _context.Orders.Include(o => o.Lines).ThenInclude(p => p.Product);

        public void SaveOrder(Order order)
        {
            _context.AttachRange(order.Lines.Select(i => i.Product));
            if (order.OrderId == 0)
            {
                _context.Orders.Add(order);
            }
            _context.SaveChanges();
        }
    }
}
