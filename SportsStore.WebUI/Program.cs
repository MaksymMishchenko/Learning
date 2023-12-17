using Microsoft.EntityFrameworkCore;
using SportsStore.Domain.Concrete;
using SportsStore.Domain.Interfaces;

namespace SportsStore.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddTransient<IProductRepository, ProductRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

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

            app.MapControllerRoute(
               name: null!,
               pattern: "Page{page}",
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
                new { controller = "Product", action = "List", page = 1 });

            app.MapControllerRoute(
                name: null!,
                pattern: "{category}/Page{page}",
                new
                {
                    controller = "Product",
                    action = "List"
                },
                new { page = @"\d+" });

            app.MapControllerRoute(null!, "{controller}/{action}");            

            app.Run();
        }
    }
}
