using MoviesTelegramBotApp.Database;
using MoviesTelegramBotApp.Models;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

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
                    var response = $"<strong>Lights, Camera, Action!</strong>\nWelcome to <em><strong>{me.FirstName}</strong></em>, the hottest Telegram hangout for movie lovers! Whether you're a die-hard cinephile or just enjoy a good popcorn flick, this is your spot to discuss all things film.";
                    await _botClient.SendTextMessageAsync(chatId, response, parseMode: ParseMode.Html);
                    await SendMenuAsync(chatId, cts);
                }
                else
                {
                    await HandleMenuResposeAsync(bot, messageText!, cts);
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

        private static async Task HandleMenuResposeAsync(ITelegramBotClient bot, Message message, CancellationToken cts)
        {
            switch (message.Text)
            {
                case "Movies":

                    await SendMoviesAsync(bot, message.Chat.Id, cts);
                    break;

                case "Cartoons":
                    //todo: functionality in progress
                    break;

                default:
                    await _botClient.SendTextMessageAsync(message.Chat.Id, "The command is not recognized");
                    break;
            }
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

        private static List<Movie> GetMovies()
        {
            return new DatabaseService().GetApplicationDbContext().Movies.ToList();
        }

        private static string BuildMoviesResponse()
        {
            List<Movie> movies = GetMovies();
            var response = new StringBuilder();

            if (!movies.Any())
                return "No movies found";

            foreach (var movie in movies)
            {
                response.AppendLine($"Name: {movie.Name}");
                response.AppendLine($"Genre: {movie.Category} ");
                response.AppendLine($"Description: {movie.Description}");
                response.AppendLine($"Country: {movie.Country} ");
                response.AppendLine($"Budget: {movie.Budget}");
                response.AppendLine($"ImageUrl: {movie.ImageUrl}");
                response.AppendLine($"Trailer: {movie.MovieUrl}");
                response.AppendLine(new string('-', 60));
                response.AppendLine();
            }

            return response.ToString();
        }

        private static async Task SendMoviesAsync(ITelegramBotClient bot, long chatId, CancellationToken cts)
        {
            List<Movie> movies = GetMovies();
            string response = BuildMoviesResponse();

            foreach (var movie in movies)
            {
                if (!string.IsNullOrEmpty(movie.ImageUrl))
                {
                    await _botClient.SendPhotoAsync(
                    chatId: chatId,
                        photo: new Telegram.Bot.Types.InputFiles.InputOnlineFile(movie.ImageUrl),
                        parseMode: ParseMode.Html,
                        caption: $"<strong>Name:</strong> {movie.Name}\n<strong>Genre:</strong> {movie.Category}\n<strong>Description:</strong> {movie.Description}\n<strong>Country:</strong> {movie.Country}\n<strong>Budget:</strong> {movie.Budget}\n<strong>Trailer:</strong> {movie.MovieUrl}",
                        cancellationToken: cts
                        );
                }

                else
                {
                    await _botClient.SendTextMessageAsync(
                        chatId,
                        text: response,
                        cancellationToken: cts
                    );
                }
            }
        }
    }
}