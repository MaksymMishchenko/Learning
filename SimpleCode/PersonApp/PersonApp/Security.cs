using System;

namespace PersonApp
{
    class Security : Employee
    {
        public void Guard()
        {
            Console.WriteLine("Я защищаю!");
        }
    }
}