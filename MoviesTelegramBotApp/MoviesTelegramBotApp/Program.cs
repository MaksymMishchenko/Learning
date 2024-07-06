using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MoviesTelegramBotApp.Database;
using MoviesTelegramBotApp.Interfaces;
using MoviesTelegramBotApp.Services;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;

namespace MoviesTelegramBotApp
{
    internal class Program
    {
        private static IServiceProvider _serviceProvider;
        private static CancellationTokenSource _cts;

        public static async Task Main()
        {
            _cts = new CancellationTokenSource();

            var services = new ServiceCollection();
            ConfigureServices(services);

            _serviceProvider = services.BuildServiceProvider();

            var botService = _serviceProvider.GetRequiredService<IBotService>();
            var updateHandler = _serviceProvider.GetRequiredService<UpdateHandler>();

            var recieverOptions = new ReceiverOptions
            {
                AllowedUpdates = Array.Empty<UpdateType>()
            };

            var botClient = _serviceProvider.GetRequiredService<TelegramBotClient>();
            botClient.StartReceiving(updateHandler.HandleUpdateAsync, HandleErrorAsync, recieverOptions, _cts.Token);

            var logger = _serviceProvider.GetRequiredService<ILogger<Program>>();
            logger.LogInformation("Bot is up and running");

            Console.ReadLine();
            _cts.Cancel();

            await Task.Delay(1000);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var configuration = GetConfiguration();

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseMySQL(GetConnectionString(configuration)));

            var apiKey = configuration["TelegramBot:ApiKey"];
            services.AddSingleton(new TelegramBotClient(apiKey));

            services.AddTransient<IBotService, BotService>();
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<UpdateHandler>();
            services.AddLogging(configure => configure.AddConsole());
        }

        private static IConfiguration GetConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }

        private static string GetConnectionString(IConfiguration configuration)
        {
            return configuration.GetConnectionString("DefaultConnection");
        }

        private static Task HandleErrorAsync(ITelegramBotClient bot, Exception ex, CancellationToken cts)
        {
            var logger = _serviceProvider.GetRequiredService<ILogger<Program>>();

            var errorMessage = ex switch
            {
                ApiRequestException apiRequestException =>
                $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}"
            };

            logger.LogError(errorMessage);
            return Task.CompletedTask;
        }
    }
}