using System;
using ArrayInversionApp;
using Xunit;

namespace ArrayInversionAppTests
{
    public class MyArrayTests
    {
        private readonly MyArray _target;

        public MyArrayTests()
        {
            _target = new MyArray();
        }

        [Fact]
        public void From10_Till_1InversionExpectedFrom1_Till10()
        {
            // arrange
            int[] arr = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // actual
            var actual =_target.InversionArray(arr);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
