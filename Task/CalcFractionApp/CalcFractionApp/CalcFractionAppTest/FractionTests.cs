using System;
using CalcFractionApp;
using CalcFractionApp.Model;
using Xunit;
using Xunit.Sdk;

namespace CalcFractionAppTest
{
    public class FractionTests
    {
        private readonly Calculator _target;
        private readonly SplitStrings _string;
       
        public FractionTests()
        {
            _target = new Calculator();
            _string = new SplitStrings();
        }
        [Fact]

        public void ReturnDenominatorTest()
        {

            //arrange
            Fraction fr1 = _string.SplitToChar("1/2");
            Fraction fr2 = _string.SplitToChar("2/5");
            var expected = 10;

            //actual
            var actual = _target.ReturnDenominator(fr1, fr2);

            //assert
            Assert.Equal(expected, actual);
        }


        public void Sum_Return_9_10()
        {
            //arrange
            var fr1 = new Fraction(1, 2); 
            var fr2 = new Fraction(2, 5);
            var expected = new Fraction(9, 10);
            

            //actual
            var actual = _target.Sum(fr1, fr2);
            
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
