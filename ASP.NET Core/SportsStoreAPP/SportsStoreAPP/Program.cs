using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SportsStoreAPP.Interfaces;
using SportsStoreAPP.Models;
using Microsoft.Extensions.Azure;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

//var connectionStringIdentity = builder.Configuration["SportsStoreIdentity:ConnectionString"] ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");;
//builder.Services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(connectionStringIdentity));
//builder.Services.AddIdentity<IdentityUser, IdentityRole>()
//    .AddEntityFrameworkStores<AppIdentityDbContext>()
//    .AddDefaultTokenProviders();

builder.Services.AddTransient<IProductRepository, EFProductRepository>();
builder.Services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<IOrderRepository, EFOrderRepository>();

builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
builder.Services.AddControllersWithViews();
// Для зберігання сесій користувачів, як от послідовність запитів та збереження
// стану інфи в корзині треба підлючити сервіси AddMemoryCache(); та AddSession();
builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddAzureClients(clientBuilder =>
{
    clientBuilder.AddBlobServiceClient(builder.Configuration["MyConnectionStorage:blob"]!, preferMsi: true);
    clientBuilder.AddQueueServiceClient(builder.Configuration["MyConnectionStorage:queue"]!, preferMsi: true);
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseStatusCodePages();
}
else
{
    app.UseExceptionHandler("/Error");
}

//Якщо проект компілюється, але є помилки типу null, то вони будуть відображатися в браузері
app.UseDeveloperExceptionPage();
// якщо підключені контроллери та View, тут, але не створені в проекті, то браузер буде видавати помилку
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseSession();
//app.UseAuthentication();
app.UseMvc(routes =>
{
    routes.MapRoute(name: "Error", template: "Error",
        defaults: new { controller = "Error", action = "Error" });

    routes.MapRoute(
        name: null,
        template: "{category}/Page{productPage:int}",
        defaults: new { controller = "Product", action = "List" }
    );

    routes.MapRoute(
        name: null,
        template: "Page{productPage:int}",
        defaults: new { controller = "Product", action = "List", productPage = 1 }
    );

    routes.MapRoute(
        name: null,
        template: "{category}",
        defaults: new { controller = "Product", action = "List", productPage = 1 }
    );

    routes.MapRoute(
        name: null,
        template: "",
        defaults: new { controller = "Product", action = "List", productPage = 1 });

    routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");
});

//IdentitySeedData.EnsurePopulated(app);
//SeedData.EnsurePopulated(app).Wait();

app.Run();
