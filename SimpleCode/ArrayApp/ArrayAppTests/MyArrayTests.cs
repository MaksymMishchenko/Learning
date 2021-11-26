using System;
using ArrayApp;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;
using NSubstitute;
namespace ArrayAppTests
{
    public class MyArrayTests
    {
        private readonly MyArray _target;
        private readonly IConsole _console;

        public MyArrayTests()
        {
            _console = Substitute.For<IConsole>();
            _target = new MyArray(_console);
        }

        [Fact]
        public void CreateArray_17elem_expected_NewArray_17_elem()
        {
            // arrange
            int numOfElements = 17;
            var expected = new int[17];

            // actual
            var newArray = _target.CreateUserArray(numOfElements);

            // assert
            Assert.Equal(expected, newArray);
        }

        [Fact]
        public void From1_till10_expected_FillArray()
        {
            // arrange
            int[] arr = {1,2,3,4,5,6,7,8,9,10};
            int current = 1;

            var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // actual
            int[] actual = _target.FillsUserData(arr, current);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrintTests()
        {
            // arrange
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            bool IsCalled = false;

            _console
                .When(x => x.Print(arr))
                .Do(x => IsCalled = true);

            // actual
            _target.Show(arr);

            // assert
            Assert.True(IsCalled);
        }
    }
}
