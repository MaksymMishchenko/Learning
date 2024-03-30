var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseMvc(routes =>
{
    routes.MapRoute(
        name: "ShopSchema2",
        template: "Shop/OldAction",
        defaults: new { controller = "Home", action = "Index" }
        );

    routes.MapRoute(
        name: "ShopSchema",
        template: "Shop/{Action}",
        defaults: new { controller = "Home" }
        );

    routes.MapRoute(
        name: "",
        template: "X{controller}/{action}"
        );

    routes.MapRoute(
        name: "",
        template: "{controller}/{action=Index}"
        );

    routes.MapRoute(
        name: "",
        template: "Public/{controller=Home}/{action=Index}"
        );
});

app.Run();
