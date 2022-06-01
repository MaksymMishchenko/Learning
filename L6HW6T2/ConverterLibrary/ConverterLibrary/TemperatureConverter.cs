namespace ConverterLibrary
{
    public class TemperatureConverter : IConverter
    {
        public double ConvertToFahrenheit(double temperature)
        {
            return temperature * 1.8 + 32;
        }

        public double ConvertToKelvin(double temperature)
        {
            return temperature + 273.15;
        }
    }
}
