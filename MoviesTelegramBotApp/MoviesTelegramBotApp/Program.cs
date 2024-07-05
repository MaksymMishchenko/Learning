using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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

        public static void Main()
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

            Console.WriteLine("Bot is up and running");
            Console.ReadLine();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseMySQL(GetConnectionString()));

            services.AddSingleton<TelegramBotClient>(sp => new TelegramBotClient("7075613694:AAE14JDh8bVT6AaOJkFT9_dc8qiowSlEGmw"));

            services.AddTransient<IBotService, BotService>();
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<UpdateHandler>();
        }

        private static string GetConnectionString()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return configuration.GetConnectionString("DefaultConnection")!;
        }

        private static Task HandleErrorAsync(ITelegramBotClient bot, Exception ex, CancellationToken cts)
        {
            var errorMessage = ex switch
            {
                ApiRequestException apiRequestException =>
                $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}"
            };

            Console.WriteLine(errorMessage);
            return Task.CompletedTask;
        }
    }
}