using Xunit;
using CheckLetterApp;

namespace CheckLetterAppTests
{
    public class CheckLetterTests
    {
        private readonly CheckLetter _target;

        public CheckLetterTests()
        {
            _target = new CheckLetter();
        }
        [Fact]
        public void IsLowerTests()
        {
            // arrange
            bool isLower = true;
            bool isUpper = false;
            var expected = isLower;

            //action
            var actual = _target.IsLower('z');

            // assert
            Assert.Equal(expected, actual);

        }
    }
}
