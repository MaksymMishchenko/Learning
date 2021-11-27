using System;
using SumEvenNumbersArrayApp;
using Xunit;
using Xunit.Sdk;

namespace SumEvenNumbersArrayAppTests
{
    public class MyArrayTests
    {
        private readonly MyArray _target;
        public MyArrayTests()
        {
            _target = new MyArray();
        }
        [Fact]
        public void CreateArray_13elem_expected_NewArray_13_elem()
        {
            // arrange
            int elemOfNumbers = 13;
            var expected = new int[13];

            // actual
            var actual = _target.CreateArray(elemOfNumbers);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
