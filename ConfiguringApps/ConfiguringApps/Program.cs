var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseKestrel().UseContentRoot(Directory.GetCurrentDirectory())
.UseIISIntegration();

builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

var app = builder.Build();

app.UseMvcWithDefaultRoute();
app.Run();