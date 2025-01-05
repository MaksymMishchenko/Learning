namespace PoundConverter.Model
{
    public class OldCurrencyPound
    {
        public OldCurrencyPound(decimal pound, decimal shilling, decimal pennies)
        {
            Pound = pound;
            Shilling = shilling;
            Pennies = pennies;
        }

        public decimal Pound { get; }
        public decimal Shilling { get; }
        public decimal Pennies { get;  }
    }
}