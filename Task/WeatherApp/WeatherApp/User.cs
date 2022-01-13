using System;

namespace WeatherApp
{
    class User: IObserver<Weather>
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public void OnCompleted()
        {
            
        }

        public void OnError(Exception error)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(error.Message);
            Console.ResetColor();
        }

        public void OnNext(Weather value)
        {
            Console.WriteLine($"Подписчик: {Name}");
            Console.WriteLine($"Город: {value.Town}");
            Console.WriteLine($"Температура: {value.Temperature}");
            Console.WriteLine($"Осадки: {value.Precipitation}");
            Console.WriteLine($"Влажность: {value.Humidity}");
            Console.WriteLine(new string('-', 15));
            Console.WriteLine();
        }
    }
}
