using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MoviesTelegramBotApp.Interfaces;
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
            var configuration = Startup.GetConfiguration();
            Startup.ConfigureServices(services, configuration);

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