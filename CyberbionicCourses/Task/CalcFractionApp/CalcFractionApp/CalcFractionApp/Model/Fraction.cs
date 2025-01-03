namespace CalcFractionApp.Model
{
    public class Fraction
    {
        public decimal Numerator { get; }
        public decimal Denominator { get; }

        public Fraction(decimal numerator, decimal denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
    }
}