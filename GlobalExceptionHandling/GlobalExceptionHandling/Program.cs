using GlobalExceptionHandling;
using GlobalExceptionHandling.Middlewares;
using GlobalExceptionHandling.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Telegram.Bot;
using Telegram.Bot.Polling;

public class Program
{
    public static async Task Main(string[] args)
    {
        var host = CreateHostBuilder().Build();

        var botClient = host.Services.GetRequiredService<IBotService>().Client;
        var updateHandler = host.Services.GetRequiredService<IUpdateHandler>();

        using var cts = new CancellationTokenSource();
        botClient.StartReceiving(
            async (bot, update, token) => await updateHandler.HandleUpdateAsync(botClient, update, token),
            async (bot, exception, token) => await updateHandler.HandlePollingErrorAsync(botClient, exception, token),
            cancellationToken: cts.Token
        );

        Console.WriteLine("Bot is running. Press Enter to exit.");
        Console.ReadLine();

        cts.Cancel();
        await host.RunAsync();
    }

    public static IHostBuilder CreateHostBuilder() =>
        Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddSingleton<IBotService>(sp =>
                    new BotService(context.Configuration["TelegramBot:ApiKey"]));

                // Register the exception handling middleware first
                services.AddTransient<IUpdateHandler, GlobalExceptionMiddleware>();

                // Register the main update handler after the middleware
                services.AddTransient<IUpdateHandler, UpdateHandler>();

                services.AddLogging(configure => configure.AddConsole());
            })
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.SetBasePath(Directory.GetCurrentDirectory());
                config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                config.AddEnvironmentVariables();
            });
}
