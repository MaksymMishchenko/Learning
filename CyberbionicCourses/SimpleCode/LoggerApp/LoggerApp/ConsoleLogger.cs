using System;

namespace LoggerApp
{
    class ConsoleLogger : IConsoleLogger
    {
        public void Log(LogLevel logLevel, string message)
        {
            switch (logLevel)
            {
                case LogLevel.Debug:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case LogLevel.Info:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case LogLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case LogLevel.Fatal:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.WriteLine("Unknown LogLevel");
                    break;
            }

            Console.WriteLine($"{DateTime.Now}, message: {message}");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
