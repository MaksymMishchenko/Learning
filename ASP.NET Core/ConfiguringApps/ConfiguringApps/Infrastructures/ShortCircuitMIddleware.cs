namespace ConfiguringApps.Infrastructures
{
    public class ShortCircuitMIddleware
    {
        private RequestDelegate _nextDelegate;
        public ShortCircuitMIddleware(RequestDelegate nextDelegate)
        {
            _nextDelegate = nextDelegate;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Items["EdgeBrowser"] as bool? == true)
            {
                httpContext.Response.StatusCode = 403;
            }
            else
            {
                await _nextDelegate.Invoke(httpContext);
            }
        }
    }
}
