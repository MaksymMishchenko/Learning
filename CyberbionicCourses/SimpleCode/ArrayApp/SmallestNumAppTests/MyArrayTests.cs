using System;
using SmallestNumApp;
using Xunit;

namespace SmallestNumAppTests
{
    public class MyArrayTests
    {
        private readonly MyArray _target;

        public MyArrayTests()
        {
            _target = new MyArray();
        }
        [Fact]
        public void FindsSmallestNumeric_expected_3()
        {
            // arrange
            int[] arr = { 8, 6, 7, 4, 6, 3, 8, 7, 4 };
            int expected = 3;

            //actual
            int actual = _target.GetSmallestNumeric(arr);

            //assert

            Assert.Equal(expected, actual);
        }
    }
}
