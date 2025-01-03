using System;

namespace PoundConverter
{
    class ShowResult: IShowResult
    {
        public void Show(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}