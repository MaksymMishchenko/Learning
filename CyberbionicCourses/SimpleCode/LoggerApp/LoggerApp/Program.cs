using System;

namespace LoggerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IConsoleLogger logger = new ConsoleLogger();
            logger.Log(LogLevel.Debug, "some Debug level");
            logger.Log(LogLevel.Info, "some Info level");
            logger.Log(LogLevel.Warning, "some Warning level");
            logger.Log(LogLevel.Error, "some Error level");
            logger.Log(LogLevel.Fatal, "some Fatal level");

            // Используем метод, который реализовали прямо в интерфейсе
            logger.ShowEmployee(Employees.Boris);
            logger.ShowEmployee(Employees.Nikolay);
        }
    }
}
