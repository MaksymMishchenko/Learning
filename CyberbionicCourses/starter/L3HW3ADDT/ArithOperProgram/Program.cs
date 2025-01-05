using System;

namespace ArithOperProgram
{
    class Program
    {
        static void Main(string[] args) // it's very ease task:)
        {
            int a = 10; 
            int b = 2;

            int resultSum = a + b;   //создаем переменную resultSum и присваиваем ей результат сложения переменных.

            Console.Write("Результат сложения переменнных: 10 + 2 = ");
            Console.WriteLine(resultSum);

            int resultSub = a - b;  //создаем переменную resultSub и присваиваем ей результат вычитания переменных.

            Console.Write("Результат вычитания переменнных: 10 - 2 = ");
            Console.WriteLine(resultSub);

            int resultMult = a * b; //создаем переменную resultMult и присваиваем ей результат умножения переменных.

            Console.Write("Результат умножения переменнных: 10 * 2 = ");
            Console.WriteLine(resultMult);

            int resultDivis = a / b; //создаем переменную resultDivis и присваиваем ей результат деления переменных.

            Console.Write("Результат деления переменнных: 10 / 2 = ");
            Console.WriteLine(resultDivis);

             //создаем переменную remainder и присваиваем ей результат получения остатка от числа переменных.
            int resultRemNam = a % b;
            int remainder = resultRemNam;

            Console.Write("Результат получения остатка от числа переменных: 10 % 2 = ");
            Console.WriteLine(remainder);

            Console.ReadKey(); // Delay
        }
        
    }
}
