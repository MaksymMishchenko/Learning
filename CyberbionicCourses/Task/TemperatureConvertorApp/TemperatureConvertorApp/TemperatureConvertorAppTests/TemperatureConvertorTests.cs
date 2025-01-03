using Xunit;
using TemperatureConvertorApp;

namespace TemperatureConvertorAppTests
{
    public class TemperatureConvertorTests
    {
        private readonly TemperatureConvertor _target;

        public TemperatureConvertorTests()
        {
            _target = new TemperatureConvertor();
        }
        [Fact]
        public void Celsius_CelsiusToFahrenheit_Return77F()
        {
            //arrange
            int celsius = 25;
            int expected = 77;

            //action
            int actual = _target.CelsiusToFahrenheit(celsius);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
