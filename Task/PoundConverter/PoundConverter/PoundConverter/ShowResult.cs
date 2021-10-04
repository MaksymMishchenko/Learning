using System;

namespace PoundConverter
{
    class ShowResult
    {
        private PoundConverter _result;

        public ShowResult(PoundConverter result)
        {
            _result = result;
        }

        public void Show(object obj)
        {
            Console.WriteLine(_result.ToString());
        }
    }
}
