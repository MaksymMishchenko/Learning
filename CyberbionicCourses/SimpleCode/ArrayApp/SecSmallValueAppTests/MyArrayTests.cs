using System;
using SecSmallValueApp;
using Xunit;

namespace SecSmallValueAppTests
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
            int elementsOfArray = 7;
            int[] expected = new int[7];

            //actual
            var actual = _target.GetNewArray(elementsOfArray);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
