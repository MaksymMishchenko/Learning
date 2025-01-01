using Microsoft.AspNetCore.Mvc;

namespace SportsStoreAPP.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Error() => View();                       
    }
}
