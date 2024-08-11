using GlobalExceptionHandling.Services;
using Microsoft.Extensions.Logging;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;

namespace GlobalExceptionHandling.Middlewares
{
    internal class GlobalExceptionMiddleware : IUpdateHandler
    {
        private readonly IUpdateHandler _next;
        private readonly ILogger<GlobalExceptionMiddleware> _logger;
        private readonly ITelegramBotClient _botClient;
        private readonly long _adminChatId;

        public GlobalExceptionMiddleware(
            IUpdateHandler next,
            ILogger<GlobalExceptionMiddleware> logger,
            IBotService botService
            )
        {
            _next = next;
            _logger = logger;
            _botClient = botService.Client;
            _adminChatId = long.Parse(configuration["TelegramBotNotify:AdminChatId"]);
        }
        public Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            _logger.LogError(exception, "An unhandled exception occurred in the bot.");
            return Task.CompletedTask;
        }

        public async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            try
            {
                _next.HandleUpdateAsync(botClient, update, cancellationToken);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "An unhandled exception occurred while processing an update.");
                await NotifyAdminAsync(ex);
            }
        }

        private async Task NotifyAdminAsync(Exception ex)
        {
            string errorMessage = $"Exception occurred: {ex.Message}\n\n{ex.StackTrace}";
            await _botClient.SendTextMessageAsync(_adminChatId, errorMessage);
        }
    }
}
