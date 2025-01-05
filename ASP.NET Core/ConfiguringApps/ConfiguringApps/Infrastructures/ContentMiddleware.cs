using System.Text;

namespace ConfiguringApps.Infrastructures
{
    public class ContentMiddleware
    {
        private RequestDelegate _nextDelegate;
        private UptimeService _uptime;
        public ContentMiddleware(RequestDelegate nextDelegate, UptimeService uptime)
        {
            _nextDelegate = nextDelegate;
            _uptime = uptime;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Path.ToString().ToLower() == "/middleware")
            {
                await httpContext.Response.WriteAsync("This is from the content middleware" +
                    $"(uptime: {_uptime.Uptime}))", Encoding.UTF8);
            }
            else
            {
                await _nextDelegate.Invoke(httpContext);
            }
        }
    }
}
