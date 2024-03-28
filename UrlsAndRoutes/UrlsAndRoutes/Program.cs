var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();

app.Run();
