using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;

namespace UrlsAndRoutes.Controllers
{   
    public class CustomerController : Controller
    {
        [Route("Myroute")]
        public ViewResult Index()
        {
            return View("Result", new Result { Controller = nameof(CustomerController), Action = nameof(Index)});
        }

        public ViewResult List()
        {
            return View("Result", new Result { Controller = nameof(CustomerController), Action = nameof(List) });
        }
    }
}
