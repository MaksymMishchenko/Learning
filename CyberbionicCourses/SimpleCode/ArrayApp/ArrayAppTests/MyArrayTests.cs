using ArrayApp;
using System;
using Xunit;

namespace ArrayAppTests
{
    public class MyArrayTests
    {
        private readonly MyArray _target;

        public MyArrayTests()
        {
            _target = new MyArray();
        }

        [Fact]
        public void CreateArray_7elem_expected_NewArray_7_elem()
        {
            // arrange
            int numOfElements = 7;
            var expected = new int[7];

            // actual
            var newArray = _target.CreateUserArray(numOfElements);

            // assert
            Assert.Equal(expected, newArray);
        }
    }
}
