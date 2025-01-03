using System;

namespace LoggerApp
{
    interface IConsoleLogger
    {
        void Log(LogLevel logLevel, string message);

        void ShowEmployee(Employees employee)
        {
            Console.WriteLine(employee);
            Console.WriteLine();
        }
    }
}
