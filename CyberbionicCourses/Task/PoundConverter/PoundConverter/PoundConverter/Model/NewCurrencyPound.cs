namespace PoundConverter.Model
{
    public class NewCurrencyPound
    {
        public NewCurrencyPound(decimal pound, decimal pennies)
        {
            Pound = pound;
            Pennies = pennies;
        }

        public decimal Pound { get; }
        public decimal Pennies { get; }
    }
}