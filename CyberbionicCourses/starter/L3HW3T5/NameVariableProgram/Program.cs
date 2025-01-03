using System;

namespace NameVariableProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //нельзя использовать названия переменных 1myVariable, и символов в начале и в конце - ?, &.
            byte uberflu? = 1;
            byte _Identifier = 10;
            byte \u006fIdentifier = 10;
            byte &myVar = 13;
            byte myVariab1le = 12;
            //эти названия переменных можно использовать
            Console.WriteLine(_Identifier);
            Console.WriteLine(\u006fIdentifier);
            Console.WriteLine(myVariab1le);
            
            Console.ReadKey();
        }
    }
}
