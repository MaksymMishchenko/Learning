using UrlsAndRoutes.Infrastructure;
var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<RouteOptions>(options =>
{
    options.ConstraintMap.Add("weekday", typeof(WeekDayConstraint));
    options.LowercaseUrls = true;
    options.AppendTrailingSlash = true;
});
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseMvc(routes =>
{
    routes.MapRoute(
        name: "areas",
        template: "{area:exists}/{controller=Home}/{action=Index}"
        );
    routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
    routes.MapRoute(name: "out", template: "outbound/{controller=Home}/{action=Index}");
});

app.Run();
