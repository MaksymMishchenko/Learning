using ControllersAndActionsApp.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActionsApp.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult SimpleForm() => View("SimpleForm");

        public void ReceiveForm(string name, string city)
            => new CustomHtmlResult { Content = $"{name} is live in {city}" };
    }
}
