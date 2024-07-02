using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;

namespace PillsTelegramBot
{
    internal class Program
    {
        private static ITelegramBotClient _clientBot;
        private static ApiService _apiService;

        static void Main(string[] args)
        {
            _clientBot = new TelegramBotClient("6812241271:AAHphGzA3VB3BmJ0ZILiF1E9-4G147WG7-0");

            using var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { } // receive all update types
            };

            _clientBot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );

            Console.WriteLine("Bot is up and running.");
            Console.ReadLine(); // Keep the program running until user presses Enter

            // Send cancellation request to stop bot
            cts.Cancel();
        }

        private static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            var message = update.Message;

            if (message?.Text == null)
                return;

            if (message.Text.StartsWith("/pill/"))
            {
                // Extract the ID from the message text
                string[] parts = message.Text.Split('/');
                if (parts.Length == 3 && int.TryParse(parts[2], out int pillId))
                {
                    // Create the API service
                    _apiService = new ApiService();
                    var pill = await _apiService.GetPillAsync($"https://localhost:7036/api/pill/{pillId}");

                    if (pill != null)
                    {
                        var chatId = message.Chat?.Id;
                        if (chatId != null)
                        {
                            string responseText = "Pill:\n";
                            responseText += $"Name: {pill.Name},\n Category: {pill.Category},\n Instructions: {pill.Instruction},\n Manufacturer: {pill.Manufacturer},\n Country: {pill.Country},\n Total: {pill.Total}\n";
                            Console.WriteLine(new string('-', 50));

                            await _clientBot.SendTextMessageAsync(chatId.Value, responseText, cancellationToken: cancellationToken);
                        }
                        else
                        {
                            // Handle case where chat ID is null
                            Console.WriteLine("Chat ID is null.");
                        }
                    }
                    else
                    {
                        // Handle case where pill is null
                        Console.WriteLine("Pill not found.");
                    }
                }
                else
                {
                    // Handle invalid ID format
                    var chatId = message.Chat?.Id;
                    if (chatId != null)
                    {
                        string errorMessage = "Invalid pill ID format. Please use /pill/{id} format.";
                        await _clientBot.SendTextMessageAsync(chatId.Value, errorMessage, cancellationToken: cancellationToken);
                    }
                    else
                    {
                        // Handle case where chat ID is null
                        Console.WriteLine("Chat ID is null.");
                    }
                }
            }
            else if (message.Text == "/pills")
            {
                _apiService = new ApiService();
                var pills = await _apiService.GetPillsAsync("https://localhost:7036/api/pill");

                if (pills != null && pills.Count > 0)
                {
                    var id = message.Chat.Id;
                    string responseText = "Available pills:\n";

                    foreach (var pill in pills)
                    {
                        responseText += $"Name: {pill.Name},\n Category: {pill.Category},\n Instructions: {pill.Instruction},\n Manufacturer: {pill.Manufacturer},\n Country: {pill.Country},\n Total: {pill.Total}\n";
                    }

                    await _clientBot.SendTextMessageAsync(id, responseText, cancellationToken: cancellationToken);
                }
                else
                {
                    // Handle case where pills list is empty or null
                    var id = message.Chat.Id;
                    string responseText = "No pills available.";
                    await _clientBot.SendTextMessageAsync(id, responseText, cancellationToken: cancellationToken);
                }
            }
        }

        private static Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            var errorMessage = exception switch
            {
                ApiRequestException apiRequestException => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };

            Console.WriteLine(errorMessage);
            return Task.CompletedTask;
        }
    }
}
