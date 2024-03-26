using System.Text;

namespace ConfiguringApps.Infrastructures
{
    public class ContentMiddleware
    {
        private RequestDelegate _nextDelegate;
        public ContentMiddleware(RequestDelegate nextDelegate) => _nextDelegate = nextDelegate;

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Path.ToString().ToLower() == "/middleware")
            {
                await httpContext.Response.WriteAsync("This is from the content middleware", Encoding.UTF8);
            }
            else
            {
                await _nextDelegate.Invoke(httpContext);
            }
        }
    }
}
