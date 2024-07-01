using MedPillCorporationApp.Interfaces;

namespace MedPillCorporationApp.Models
{
    public class PillRepository : IPillRepository
    {
        private ApplicationDbContext _context;

        public PillRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<Pill> Pills => _context.Pills;
    }
}
