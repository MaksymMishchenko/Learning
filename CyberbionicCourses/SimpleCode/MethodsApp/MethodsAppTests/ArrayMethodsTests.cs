using System;
using MethodsApp;
using Xunit;

namespace MethodsAppTests
{
    public class ArrayMethodsTests
    {
        private readonly ArrayMethods _target;

        public ArrayMethodsTests()
        {
            _target = new ArrayMethods();
        }

        [Fact]
        public void CreateArray_10elements_ExpectedNewArray()
        {
            // arrange
            int[] expected = new int[10];

            // actual
            var actual = _target.CreateArray();

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindIndex_number10_Expected_4()
        {
            // arrange
            int[] arr = { 1, 8, 5, 9, 10, 45 };
            int number = 10;
            int expected = 4;

            // actual
            var actual = _target.IndexOf(arr, number);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
