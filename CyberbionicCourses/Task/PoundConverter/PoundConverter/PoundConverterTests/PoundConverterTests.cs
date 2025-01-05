using System;
using Xunit;
using PoundConverter;
using PoundConverter.Model;

namespace PoundConverterTests
{
    public class PoundConverterTests
    {
        private readonly Converter _target;

        public PoundConverterTests(Converter target, NewCurrencyPound newPound, OldCurrencyPound oldPound)
        {
            _target = new Converter();
        }

        [Fact]
        public void OldPound_Convert_NewPound()
        {
            //arrange
            var fr1 = new OldCurrencyPound(7,17,9) ;
            var expected = new NewCurrencyPound(7, 89);

            //actual
            var actual = _target.NewPound(7,17,9);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
