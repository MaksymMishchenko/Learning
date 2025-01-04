namespace TemperatureConvertorApp
{
    public class TemperatureConvertor : ITemperatureConvertor
    {
        //10 минут метод, 30 минут тест и решение задачи
        public int CelsiusToFahrenheit(int celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}