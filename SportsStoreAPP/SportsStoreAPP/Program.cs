using Microsoft.EntityFrameworkCore;
using SportsStoreAPP.Interfaces;
using SportsStoreAPP.Models;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddTransient<IProductRepository, EFProductRepository>();
//builder.Services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
//builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
builder.Services.AddControllersWithViews();
// Для зберігання сесій користувачів, як от послідовність запитів та збереження
// стану інфи в корзині треба підлючити сервіси AddMemoryCache(); та AddSession();
builder.Services.AddMemoryCache();
builder.Services.AddSession();
var app = builder.Build();

//Якщо проект компілюється, але є помилки типу null, то вони будуть відображатися в браузері
app.UseDeveloperExceptionPage();
// якщо підключені контроллери та View, тут, але не створені в проекті, то браузер буде видавати помилку
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseSession();

//// /Page2 - виводить вказану сторінку (2 в даному випадку)
//app.MapControllerRoute(
//    name: null!,
//    pattern: "Page{productPage:int}",
//    defaults: new { Controller = "Product", action = "List", productPage = 1 });
//
//// /Soccer - виводить першу сторінку товарів вказаної категорії (Soccer)
//app.MapControllerRoute(
//    name: null!,
//    pattern: "{category}",
//    defaults: new { Controller = "Product", action = "List", productPage = 1 });
//
//// /Soccer/Page2 - виводить вказану сторінку (сторінку 2) товарів заданої категорії (Soccer)
//app.MapControllerRoute(
//    name: null!,
//    pattern: "",
//    defaults: new { Controller = "Product", action = "List", productPage = 1 });
//
//app.MapControllerRoute(
//    name: "pagination",
//    pattern: "Products/Page{productPage}",
//    defaults: new { Controller = "Product", action = "List" });
//
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Product}/{action=List}/{id?}");

app.MapControllerRoute(
             name: null!,
             pattern: "",
             new
             {
                 controller = "Product",
                 action = "List",
                 category = (string?)null,
                 page = 1
             });

// / - Виводить першу сторінку списку товарів всіх категорій
app.MapControllerRoute(
    name: null!,
    pattern: "{category}/Page{productPage:int}",
    defaults: new { Controller = "Product", action = "List" });

app.MapControllerRoute(
   name: null!,
   pattern: "Page{productPage}",
   new
   {
       controller = "Product",
       action = "List",
       category = (string?)null,
   },
   new { page = @"\d+" });

app.MapControllerRoute(
    name: null!,
    pattern: "{category}",
    new { controller = "Product", action = "List", productPage = 1 });

app.MapControllerRoute(
    name: null!,
    pattern: "{category}/Page{productPage}",
    new
    {
        controller = "Product",
        action = "List"
    },
    new { page = @"\d+" });

app.MapControllerRoute(null!, "{controller}/{action}");

app.Run();
