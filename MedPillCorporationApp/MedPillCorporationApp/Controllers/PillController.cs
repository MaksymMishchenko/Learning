using MedPillCorporationApp.Interfaces;
using MedPillCorporationApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedPillCorporationApp.Controllers
{
    [Route("api/[controller]")]
    public class PillController : Controller
    {
        private IPillRepository _repository;
        public PillController(IPillRepository repo)
        {
            _repository = repo;

        }

        [HttpGet]
        public IQueryable<Pill> GetPills() => _repository.Pills;

    }
}
