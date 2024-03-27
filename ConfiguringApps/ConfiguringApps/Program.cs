using ConfiguringApps.Infrastructures;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseKestrel().UseContentRoot(Directory.GetCurrentDirectory())
.UseIISIntegration();
builder.Services.AddSingleton<UptimeService>();
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseStatusCodePages();
}
else {
    app.UseExceptionHandler("/Home/Error");
}

//app.UseMiddleware<ErrorMiddleware>();
//app.UseMiddleware<BrowserTypeMiddleware>();
//app.UseMiddleware<ShortCircuitMIddleware>();
//app.UseMiddleware<ContentMiddleware>();

app.UseMvc(routes =>
{
    routes.MapRoute(
        name: "deafult",
        template: "{controller=Home}/{action=Index}/{id?}"
        );
});

app.Run();