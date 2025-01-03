using System;
using CalculatorApp;
using Xunit;

namespace CalculatorAppTests
{
    public class CalculatorTests
    {
        private readonly Calculator _target;

        public CalculatorTests()
        {
            _target = new Calculator();
        }
        [Fact]
        public void Sum_10_5_expected_15()
        {
            // arrange
            double firstValue = 10;
            double secondValue = 5;
            double expected = 15;

            // actual
            var actual = _target.Sum(firstValue, secondValue);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Sub_13_4_expected_9()
        {
            // arrange
            double firstValue = 13;
            double secondValue = 4;
            double expected = 9;

            // actual
            var actual = _target.Subtract(firstValue, secondValue);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Mul_3_7_expected_21()
        {
            // arrange
            double firstValue = 3;
            double secondValue = 7;
            double expected = 21;

            // actual
            var actual = _target.Mul(firstValue, secondValue);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Div_18_9_expected_2()
        {
            // arrange
            double firstValue = 18;
            double secondValue = 9;
            double expected = 2;

            // actual
            var actual = _target.Div(firstValue, secondValue);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
