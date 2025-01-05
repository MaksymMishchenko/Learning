using System;
using ArrayApp;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using Xunit;
using Xunit.Sdk;

namespace ArrayAppTests
{
    public class ArrayMethodsTests
    {
        private readonly ArrayMethods _target;
        public ArrayMethodsTests()
        {
            _target = new ArrayMethods();

        }
        [Fact]
        public int[] CreateArrayTest()
        {
            //Arrange
            int elOfArray = 10;
            var expected = new int[elOfArray];

            //Action
            var actual = _target.CreateArray(elOfArray);

            //Assert
            Assert.Equal(expected, actual);
            return new int[elOfArray];
        }

        [Fact]
        public int[] FillArrayTest()
        {
            //Arrange
            var arr = CreateArrayTest();
            int from = 1;
            int till = 100;

            var random = new Random();
            for (int i = 0; i <arr.Length; i++)
            {
                arr[i] = random.Next(from, till);
            }
            var expected = arr;

            //Action
            var actual = _target.FillArray(arr, from, till); ;

            //Assert
            Assert.Equal(expected, actual);

            return actual;
        }

        [Fact]
        public void SortArrayTest()
        {
            //Arrange
            var arr = FillArrayTest();
            var expected = arr;

            //Action
            var actual = _target.SortArray(arr); ;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
