using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MoviesTelegramBotApp.Database
{
    internal class DatabaseService
    {
        public ApplicationDbContext GetApplicationDbContext()
        {
            var serviceProvider = new ServiceCollection()
                    .AddDbContext<ApplicationDbContext>(options => options.UseMySQL(GetConnectionString()))
                    .BuildServiceProvider();

            return serviceProvider.GetRequiredService<ApplicationDbContext>();
        }

        private static string GetConnectionString()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return configuration.GetConnectionString("DefaultConnection");
        }
    }
}
