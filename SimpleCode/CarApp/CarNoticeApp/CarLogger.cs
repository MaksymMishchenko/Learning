using System;

namespace CarNoticeApp
{
    class CarLogger
    {
        public void Info(string message)
        {
            Console.WriteLine($"{DateTime.Now} |INFO| {message}");
        }

        public void Error(string message)
        {
            Console.WriteLine($"{DateTime.Now} |ERROR| {message}");
        }

        public void Warning(string message)
        {
            Console.WriteLine($"{DateTime.Now} |ERROR| {message}");
        }
    }
}
