using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActionsApp.Controllers
{
    public class DeriverController : Controller
    {
        public ViewResult Headers() => View("DictionaryResult", Request.Headers.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.First())); 
    }
}
