namespace CurrencyConverterApp
{
    public class CurrencyConvertor : ICurrencyConverter
    {
        private readonly float _dollar;
         
        //15 минут
        public float ConvertDollarToPound(float dollar)
        {
            
            return dollar / ExchangeRate.pound;
        }

        //15 минут
        public float ConvertDollarToFranc(float dollar)
        {
            return dollar / ExchangeRate.franc;
        }

        //15 минут
        public float ConvertDollarToMark(float dollar)
        {
            return dollar / ExchangeRate.mark;
        }

        //15 минут
        public float ConvertDollarToYen(float dollar)
        {
            return dollar / ExchangeRate.yen;
        }
    }
}