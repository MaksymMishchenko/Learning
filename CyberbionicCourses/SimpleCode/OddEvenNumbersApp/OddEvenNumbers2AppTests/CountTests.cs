using OddEvenNumbers2App;
using System;
using Xunit;

namespace OddEvenNumbers2AppTests
{
    public class CountTests
    {
        private readonly Count _target;

        public CountTests()
        {
            _target = new Count();
        }
        [Fact]
        public void Count1_15expected5_5Sum25_30()
        {
            // arrange
            int currentValue = 1;
            int limit = 15;

            int oddNumbersCount = 0;
            int evenNumbersCount = 0;

            int oddNumberSum = 0;
            int evenNumberSum = 0;

            int oddNumbersExpected = 8;
            int evenNumbersExpected = 7;

            int oddSumExpected = 64;
            int evenSumExpected = 56;

            // actual
            _target.GetOddEvenNumbers(currentValue, limit, ref oddNumbersCount, ref evenNumbersCount, ref oddNumberSum, ref evenNumberSum);

            // assert
            Assert.Equal(oddNumbersExpected, oddNumbersCount);
            Assert.Equal(evenNumbersExpected, evenNumbersCount);
            Assert.Equal(oddSumExpected, oddNumberSum);
            Assert.Equal(evenSumExpected, evenNumberSum);
        }
    }
}
