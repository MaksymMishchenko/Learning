using System;
using AddsFeetApp;
using Xunit;

namespace AddsFeetAppTests
{
    public class DistanceTests
    {
        private readonly Distance _target;

        public DistanceTests()
        {
            _target = new Distance(10, 6.75F);
        }
        [Fact]
        public void Sum_10Feet6_75Inches_And_11Feet6_25InchesReturned22_1()
        {
            // Arange
            int feet2 = 11;
            float inches2 = 6.25F;

            int expectedFeet = 22;
            float expectedInches = 1.0F;

            // Action
            int tempFeet = 0;
            float tempInches = 0;
            _target.SumFeetsAndInches(feet2, inches2, ref tempFeet, ref tempInches);

            // Assert
            Assert.Equal(expectedFeet, tempFeet);
            Assert.Equal(expectedInches, tempInches);
        }
    }
}
