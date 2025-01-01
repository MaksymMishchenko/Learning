using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace GlobalExceptionHandling.Services
{
    public interface IBotService
    {
        TelegramBotClient Client { get; }
    }

    public class BotService : IBotService
    {
        public TelegramBotClient Client { get; }

        public BotService(string apiKey)
        {
            Client = new TelegramBotClient(apiKey);
        }
    }
}
