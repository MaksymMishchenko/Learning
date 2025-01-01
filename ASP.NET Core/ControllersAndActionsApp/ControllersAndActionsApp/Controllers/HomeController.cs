using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActionsApp.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult SimpleForm() => View("SimpleForm");

        public ViewResult ReceiveForm(string name, string city)
            => View("Result", $"{name} is live in {city}");
    }
}
