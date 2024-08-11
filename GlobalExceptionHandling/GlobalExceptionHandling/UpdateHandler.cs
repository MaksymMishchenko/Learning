using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;

namespace GlobalExceptionHandling
{
    internal class UpdateHandler : IUpdateHandler
    {
        public async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            var chatId = update.Message.Chat.Id;
            var text = update.Message.Text;

            if (text != null)
            {
                if (update.Message.Text == "/throw")
                {
                    throw new Exception("Test exception: This is a simulated exception");
                }

                await botClient.SendTextMessageAsync(chatId, "Test exception", cancellationToken: cancellationToken);
            }
        }

        public Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
