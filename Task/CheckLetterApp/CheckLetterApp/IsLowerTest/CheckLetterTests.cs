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
            int isLower = 1;
            int isUpper = 0;
            var expected = isLower;

            //action
            var actual = _target.IsLower('z');

            // assert
            Assert.Equal(expected, actual);

        }
    }
}
