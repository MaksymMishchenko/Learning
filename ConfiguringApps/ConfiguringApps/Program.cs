using ConfiguringApps.Infrastructures;
using Microsoft.AspNetCore.Routing.Template;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseKestrel().UseContentRoot(Directory.GetCurrentDirectory())
.UseIISIntegration();
builder.Services.AddSingleton<UptimeService>();
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

var app = builder.Build();
app.UseMiddleware<ErrorMiddleware>();
app.UseMiddleware<BrowserTypeMiddleware>();
app.UseMiddleware<ShortCircuitMIddleware>();
app.UseMiddleware<ContentMiddleware>();
app.UseMvc(routes =>
{
    routes.MapRoute(
        name: "deafult",
        template: "{controller=Home}/{actin=Index}/{id?}"
        );
});

app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{actin=Index}/{id?}",
    defaults: null
    );
app.Run();