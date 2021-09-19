using NSubstitute;
using TableApp;
using Xunit;

namespace TableAppTests
{
    public class TableTests
    {
        private readonly Table _target;
        private readonly IFile _file;

        public TableTests()
        {
            _file = Substitute.For<IFile>();
            _target = new Table(_file);
        }

        [Fact]
        public void PrintOnScreenTests()
        {
            // arrange
            var expected = "1990, 1991, 1992, 1993, 135, 7290, 11300, 16200";

            // action
            var actual = _target.PrintOnScreen();
           
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Path_Save_Success()
        {
            // arrange
            var path = "arrayTest.txt";

            bool isCalled = false;
            //_file.When(x => x
            //    .AppendAllText("arrayTest.txt", "1990, 1991, 1992, 1993, 135, 7290, 11300, 16200"))
            //    .Do(x => isCalled = true);

            // action
            _target.Save(path);
           
            // assert
            _file
                .Received()
                .AppendAllText("arrayTest.txt", "1990, 1991, 1992, 1993, 135, 7290, 11300, 16200");
            //Assert.True(isCalled);
        }
    }
}
