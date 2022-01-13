using System;
using System.Threading;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // service
            WeatherData weatherData = new WeatherData();

            // users
            User maks = new User("Макс");
            User artur = new User("Артур");
            User anton = new User("Антон");

            // data
            Weather berdychiv = new Weather("Бердичев", "-5 C", "Снег", "76%");
            Weather kyiv = new Weather("Киев", "-8 C", "Снег", "90%");
            Weather odessa = new Weather("Одесса", "+ 5 C", "Дождь", "95%");

            // subscribe users
            IDisposable arturSubscribe = weatherData.Subscribe(artur);
            Thread.Sleep(500);
            IDisposable antonSubscribe = weatherData.Subscribe(anton);
            IDisposable maksSubscribe = weatherData.Subscribe(maks);

            // notify users
            weatherData.Notify(berdychiv);
            weatherData.Notify(kyiv);

            // unsubscribe user maks
            maksSubscribe.Dispose();
            weatherData.Notify(odessa);
        }
    }
}
