using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MoviesTelegramBotApp.Database
{
    internal class DatabaseProvider
    {
        public DatabaseProvider()
        {
            SetUpProvider();
        }

        private void SetUpProvider()
        {
            var serviceProvider = new ServiceCollection().AddDbContext<ApplicationDbContext>(options =>
            options.UseMySQL(GetConnectionString())).BuildServiceProvider();
        }

        private string GetConnectionString()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return configuration.GetConnectionString("DefaultString");
        }
    }
}
