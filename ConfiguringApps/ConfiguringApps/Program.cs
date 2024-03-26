using ConfiguringApps.Infrastructures;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseKestrel().UseContentRoot(Directory.GetCurrentDirectory())
.UseIISIntegration();
builder.Services.AddSingleton<UptimeService>();
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

var app = builder.Build();
app.UseMiddleware<ContentMiddleware>();
app.UseMvcWithDefaultRoute();
app.Run();