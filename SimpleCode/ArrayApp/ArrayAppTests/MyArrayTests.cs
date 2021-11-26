using System;
using ArrayApp;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace ArrayAppTests
{
    public class MyArrayTests
    {
        private readonly MyArray _target;
        private readonly MyArray _console;
        

        public MyArrayTests()
        {
            _target = new MyArray();
            _console = new MyArray();
        }

        [Fact]
        public void FillsUserDataTests()
        {
            // arrange
            
            // actual

            // assert
        }
    }
}
