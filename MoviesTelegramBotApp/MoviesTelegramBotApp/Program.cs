using MoviesTelegramBotApp.Database;
using MoviesTelegramBotApp.Models;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace MoviesTekegramBotApp
{
    internal class Program
    {
        private static TelegramBotClient _botClient;
        private static CancellationTokenSource _cts;
        public static void Main()
        {
            _botClient = new TelegramBotClient("7075613694:AAE14JDh8bVT6AaOJkFT9_dc8qiowSlEGmw");
            _cts = new CancellationTokenSource();

            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = Array.Empty<UpdateType>()
            };

            _botClient.StartReceiving(HandleUpdateAsync, HandleErrorAsync, receiverOptions, cancellationToken: _cts.Token);

            Console.WriteLine("Bot is up and running...");
            Console.ReadLine();
        }

        private static async Task HandleUpdateAsync(ITelegramBotClient bot, Update update, CancellationToken cts)
        {
            if (update.Type == UpdateType.Message && update.Message!.Type == MessageType.Text)
            {
                var chatId = update.Message.Chat.Id;
                var messageText = update.Message;
                var me = await _botClient.GetMeAsync();

                var startKeyBoard = new ReplyKeyboardMarkup(new KeyboardButton("Start")) { ResizeKeyboard = true };

                if (messageText?.Text?.ToLower() == "/start")
                {
                    var response = $"Lights, Camera, Action! Welcome to {me.FirstName}, the hottest Telegram hangout for movie lovers! Whether you're a die-hard cinephile or just enjoy a good popcorn flick, this is your spot to discuss all things film.  Get ready for spoiler alerts, passionate debates, and maybe even some trivia showdowns!";
                    await _botClient.SendTextMessageAsync(chatId, response);
                    await SendMenuAsync(chatId, cts);
                }
                else
                {
                    await HandleMenuResposeAsync(messageText!, cts);
                }
            }
        }

        private static async Task SendMenuAsync(long chatId, CancellationToken cts)
        {
            var replyKeyBoardMarkup = new ReplyKeyboardMarkup(new[] {

            new KeyboardButton[] { "Movies", "Cartoons"}
            })
            {
                ResizeKeyboard = true
            };

            await _botClient.SendTextMessageAsync(
                chatId,
                text: "Choose an option",
                replyMarkup: replyKeyBoardMarkup,
                cancellationToken: cts);
        }

        private static async Task HandleMenuResposeAsync(Message message, CancellationToken cts)
        {
            var responseText = message.Text switch
            {
                "Movies" => DisplayMovies(),
                "Cartoons" => "Your selected option 2",
                _ => "Sorry, command is not reconized! Try anothet one!"
            };

            await _botClient.SendTextMessageAsync(
                message.Chat.Id,
                responseText,
                cancellationToken: cts);

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

        private static string DisplayMovies()
        {
            List<Movie> movies = new DatabaseService().GetApplicationDbContext().Movies.ToList();

            string response = string.Empty;

            if (!movies.Any()) 
                return "No movies found";

            foreach (var movie in movies)
            {
                response += $"Id: {movie.MovieId}\n Name: {movie.Name}\n Genre: {movie.Category}\n {movie.Country}\n Budget {movie.Budget}\n";
            }

            return response;
        }
    }
}