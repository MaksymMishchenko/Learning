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
                    await botClient.SendTextMessageAsync(chatId, "Test exception", cancellationToken: cancellationToken);
                }                
            }

            if (text != null)
            {
                if (update.Message.Text == "start")
                {
                    await botClient.SendTextMessageAsync(chatId, "Hello Maks", cancellationToken: cancellationToken);
                }                
            }
        }

        public Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
