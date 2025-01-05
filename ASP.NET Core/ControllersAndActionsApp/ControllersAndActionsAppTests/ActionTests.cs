using ControllersAndActionsApp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActionsAppTests
{
    public class ActionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ViewSelected()
        {
            // Arange
            var controller = new HomeController();

            // Act
            ViewResult result = controller.ReceiveForm("Adam", "London");

            // Assert            
            Assert.That("Result", Is.EqualTo(result.ViewName));            
        }
    }
}