namespace ConfiguringApps.Infrastructures
{
    public class BrowserTypeMiddleware
    {
        private RequestDelegate _nextDelegate;

        public BrowserTypeMiddleware(RequestDelegate next) => _nextDelegate = next;
        public async Task Invoke(HttpContext httpContext)
        {
            httpContext.Items["EdgeBrowser"] = httpContext.Request.Headers["User-Agent"].Any(v => v.ToLower().Contains("edg"));
            await _nextDelegate.Invoke(httpContext);
        }
    }
}
