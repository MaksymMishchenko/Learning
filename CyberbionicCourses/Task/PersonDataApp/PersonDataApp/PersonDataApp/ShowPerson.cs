using System;

namespace PersonDataApp
{
    class ShowPerson : IShowPerson
    {
        public void Show(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}