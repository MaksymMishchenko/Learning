﻿using System.Text;

namespace ConfiguringApps.Infrastructures
{
    public class ErrorMiddleware
    {
        private RequestDelegate _nextDelegate;
        public ErrorMiddleware(RequestDelegate next) => _nextDelegate = next;

        public async Task Invoke(HttpContext httpContext)
        {
            await _nextDelegate.Invoke(httpContext);

            if (httpContext.Response.StatusCode == 403)
            {
                await httpContext.Response.WriteAsync("Edge not supported", Encoding.UTF8);
            }
            else if (httpContext.Response.StatusCode == 404)
            {
                await httpContext.Response.WriteAsync("No content middleware response", Encoding.UTF8);
            }
        }
    }
}
