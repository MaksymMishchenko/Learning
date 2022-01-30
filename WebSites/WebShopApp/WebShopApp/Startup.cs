using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebShopApp.Data;
using WebShopApp.Data.Interfaces;
using WebShopApp.Data.Mocks;
using Microsoft.EntityFrameworkCore;
using WebShopApp.Data.Repository;

namespace WebShopApp
{
    public class Startup
    {
        private IConfigurationRoot _confString;
        
        public Startup(IHostingEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath)
                .AddJsonFile("dbsettings.json").Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContent>(options => 
                options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<ICars, CarRepository>();
            services.AddTransient<ICategory, CategoryRepository>();
            // Add MVC services
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            // show static files in our project
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            using (var scope = app.ApplicationServices.CreateScope())
            {
               AppDbContent content = scope.ServiceProvider.GetRequiredService<AppDbContent>();
               DbObjects.Initial(content);
            }
        }
    }
}
