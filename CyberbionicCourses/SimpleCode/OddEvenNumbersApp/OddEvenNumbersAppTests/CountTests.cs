using System;
using OddEvenNumbersApp;
using Xunit;

namespace OddEvenNumbersAppTests
{
    public class CountTests
    {
        private readonly Count _target;
        public CountTests()
        {
            _target = new Count();
        }

        [Fact]
        public void Count1_10expected5_5Sum25_30()
        {
            // arrange
            int currentValue = 1;
            int limit = 10;

            int oddNumbersCount = 0;
            int evenNumbersCount = 0;

            int oddNumberSum = 0;
            int evenNumberSum = 0;

            int oddNumbersExpected = 5;
            int evenNumbersExpected = 5;

            int oddSumExpected = 25;
            int evenSumExpected = 30;

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
