using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MoviesTelegramBotApp.Database;
using MoviesTelegramBotApp.Interfaces;
using MoviesTelegramBotApp.Services;
using Telegram.Bot;

namespace MoviesTelegramBotApp
{
    public static class Startup
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySQL(configuration.GetConnectionString("DefaultConnection")));

            var apiKey = configuration["TelegramBot:ApiKey"];
            services.AddSingleton(new TelegramBotClient(apiKey));

            services.AddTransient<IBotService, BotService>();
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<UpdateHandler>();
            services.AddLogging(configure => configure.AddConsole());
        }

        public static IConfiguration GetConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}
