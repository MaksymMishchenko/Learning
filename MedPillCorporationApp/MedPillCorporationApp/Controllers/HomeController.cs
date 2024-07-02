using MedPillCorporationApp.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MedPillCorporationApp.Controllers
{
    public class PillController : Controller
    {
        private IPillRepository _repository;
        public PillController(IPillRepository repo)
        {
            _repository = repo;

        }
        public IActionResult Index()
        {
            return View(_repository.Pills);
        }
    }
}
