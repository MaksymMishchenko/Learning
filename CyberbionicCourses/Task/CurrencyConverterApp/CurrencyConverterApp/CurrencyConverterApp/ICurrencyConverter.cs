namespace CurrencyConverterApp
{
    internal interface ICurrencyConverter
    {
        float ConvertDollarToPound(float dollar);
        float ConvertDollarToFranc(float dollar);
        float ConvertDollarToMark(float dollar);
        float ConvertDollarToYen(float dollar);

    }
}
