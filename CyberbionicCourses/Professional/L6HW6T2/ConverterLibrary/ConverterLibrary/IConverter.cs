namespace ConverterLibrary
{
    internal interface IConverter
    {
        double ConvertToFahrenheit(double temperature);
        double ConvertToKelvin(double temperature);
    }
}
