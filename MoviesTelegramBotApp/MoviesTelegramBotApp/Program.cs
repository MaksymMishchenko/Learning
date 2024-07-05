using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MoviesTelegramBotApp.Database;
using MoviesTelegramBotApp.Services;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;

namespace MoviesTelegramBotApp
{
    internal class Program
    {
        private static TelegramBotClient _botClient;
        private static CancellationTokenSource _cts;

        public static void Main()
        {
            _botClient = new TelegramBotClient("7075613694:AAE14JDh8bVT6AaOJkFT9_dc8qiowSlEGmw");
            _cts = new CancellationTokenSource();

            var movieService = new MovieService(new ServiceCollection().AddDbContext<ApplicationDbContext>(options =>
            options.UseMySQL(GetConnectionString())).BuildServiceProvider().GetRequiredService<ApplicationDbContext>());

            var botService = new BotService(_botClient);
            var updateHandler = new UpdateHandler(botService, movieService);

            var recieverOptions = new ReceiverOptions
            {
                AllowedUpdates = Array.Empty<UpdateType>()
            };

            _botClient.StartReceiving(updateHandler.HandleUpdateAsync, HandleErrorAsync, recieverOptions, _cts.Token);

            Console.WriteLine("Bot is up and running");
            Console.ReadLine();
        }

        private static string GetConnectionString()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return configuration.GetConnectionString("DefaultConnection");
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