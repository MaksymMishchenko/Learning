namespace WeatherApp
{
    class Weather
    {
        public string Town { get; }
        public string Temperature { get; }
        public string Precipitation { get; }
        public string Humidity { get; }

        public Weather(string town, string temperature, string precipitation, string humidity)
        {
            Town = town;
            Temperature = temperature;
            Precipitation = precipitation;
            Humidity = humidity;
        }
    }
}
