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
        name: "MyRoute",
        template: "{controller=Home}/{action=Index}/{id=DefaultId}"
        );
});

app.Run();
