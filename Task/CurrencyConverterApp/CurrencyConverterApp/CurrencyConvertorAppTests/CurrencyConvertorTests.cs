using Xunit;
using Xunit.Sdk;
using CurrencyConverterApp;

namespace CurrencyConvertorAppTests
{
    public class CurrencyConvertorTests
    {
        private readonly CurrencyConvertor _target;
        public CurrencyConvertorTests()
        {
            _target = new CurrencyConvertor();
        }
        [Fact]
        public void Convert_10DollarsToPoundTest()
        {
            //arrange
            float dollar = 10.0F;
            float pound = 1.487F;
            float expected = 6.72495F;

            //actual
            var actual = _target.ConvertDollarToPound(dollar, pound);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_5DollarsToFrancTest()
        {
            //arrange
            float dollar = 5.0F;
            float franc = 0.172F;
            float expected = 29.069767F;

            //actual
            var actual = _target.ConvertDollarToFranc(dollar, franc);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_15DollarsToMarkTest()
        {
            //arrange
            float dollar = 15.0F;
            float mark = 0.584F;
            float expected = 25.684933F;

            //actual
            var actual = _target.ConvertDollarToMark(dollar, mark);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_11DollarsToYenTest()
        {
            //arrange
            float dollar = 11.0F;
            float yen = 0.00955F;
            float expected = 1151.83246F;

            //actual
            var actual = _target.ConvertDollarToYen(dollar, yen);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
