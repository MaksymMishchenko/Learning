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
// ��� ��������� ���� ������������, �� �� ����������� ������ �� ����������
// ����� ���� � ������ ����� �������� ������ AddMemoryCache(); �� AddSession();
builder.Services.AddMemoryCache();
builder.Services.AddSession();
var app = builder.Build();

//���� ������ �����������, ��� � ������� ���� null, �� ���� ������ ������������ � �������
app.UseDeveloperExceptionPage();
// ���� �������� ����������� �� View, ���, ��� �� ������� � ������, �� ������� ���� �������� �������
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseSession();

//// /Page2 - �������� ������� ������� (2 � ������ �������)
//app.MapControllerRoute(
//    name: null!,
//    pattern: "Page{productPage:int}",
//    defaults: new { Controller = "Product", action = "List", productPage = 1 });
//
//// /Soccer - �������� ����� ������� ������ ������� ������� (Soccer)
//app.MapControllerRoute(
//    name: null!,
//    pattern: "{category}",
//    defaults: new { Controller = "Product", action = "List", productPage = 1 });
//
//// /Soccer/Page2 - �������� ������� ������� (������� 2) ������ ������ ������� (Soccer)
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

// / - �������� ����� ������� ������ ������ ��� ��������
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
