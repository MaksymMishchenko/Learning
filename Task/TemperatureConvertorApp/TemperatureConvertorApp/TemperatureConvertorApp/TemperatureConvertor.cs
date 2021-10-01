namespace TemperatureConvertorApp
{
    public class TemperatureConvertor : ITemperatureConvertor
    {
        public int CelsiusToFahrenheit(int celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}