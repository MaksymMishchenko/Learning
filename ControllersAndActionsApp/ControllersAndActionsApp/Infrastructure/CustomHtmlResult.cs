using ControllersAndActionsApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace ControllersAndActionsApp.Infrastructure
{
    public interface IActionResult
    {
        Task ExecuteResultAsync(ActionContext context);
    }

    public class CustomHtmlResult : IActionResult
    {
        public string? Content { get; set; }
        public Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context)
        {
            context.HttpContext.Response.StatusCode = 200;
            context.HttpContext.Response.ContentType = "text/html";
            byte[] content = Encoding.ASCII.GetBytes(Content);
            return context.HttpContext.Response.Body.WriteAsync(content, 0, content.Length);            
        }
    }
}
