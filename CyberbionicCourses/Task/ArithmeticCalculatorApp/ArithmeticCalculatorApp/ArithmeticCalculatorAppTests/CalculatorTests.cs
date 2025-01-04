using ArithmeticCalculatorApp;
using Xunit;

namespace ArithmeticCalculatorAppTests
{
    public class CalculatorTests
    {
        private readonly Calculator _target;

        public CalculatorTests()
        {
            _target = new Calculator();
        }
        [Fact]
        public void Adds_5_3_expected_8()
        {
            // arrange
            double operandA = 5;
            double operandB = 3;
            double expected = 8;

            // actual
            var actual =_target.Adds(operandA, operandB);

            // assert
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Subtruction_10_6_expected_4()
        {
            // arrange
            double operandA = 10;
            double operandB = 6;
            double expected = 4;

            // actual
            var actual = _target.Subtraction(operandA, operandB);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multipliplies_2_7_expected_14()
        {
            // arrange
            double operandA = 2;
            double operandB = 7;
            double expected = 14;

            // actual
            var actual = _target.Multipliplies(operandA, operandB);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divides_21_2_expected_10_5()
        {
            // arrange
            double operandA = 21;
            double operandB = 2;
            double expected = 10.5;

            // actual
            var actual = _target.Divides(operandA, operandB);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DividesRemainder_11_2_expected_1()
        {
            // arrange
            double operandA = 11;
            double operandB = 2;
            double expected = 1;

            // actual
            var actual = _target.DividesRemainder(operandA, operandB);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
