using System;
using System.Linq.Expressions;

namespace MethodsArithmeticsProgram
{
    class Program
    {   // method Add
        static int Add(int operand1, int operand2)
        {
            return operand1 + operand2;
        }
        // method Sub
        static int Sub(int operand1, int operand2)
        {
            return operand1 - operand2;
        }
        // method Mul
        static int Mul(int operand1, int operand2)
        {
            return operand1 * operand2;
        }
        // method Dev
        static int Dev(int operand1, int operand2)
        {
            return operand1 / operand2;
        }
        // method Sub
        static void Main()

        {   //input value1,convert to type Int32
            Console.Write("Введите значение операнда 1: ");
            string value1 = Console.ReadLine();
            int number1 = Convert.ToInt32(value1);

            //input arithmetic operations
            Console.Write("Допустимые арифметические операции: '+', '-', '*', '/'\nВведите символ арифметической операции: ");
            string symbol = Console.ReadLine();

            //input value2,convert to type Int32
            Console.Write("Введите значение операнда 2: ");
            string value2 = Console.ReadLine();
            int number2 = Convert.ToInt32(value2);

            //used construction SwitchCase
            switch (symbol)
            {
                //if user input symbol "+"
                case "+":
                    {
                        int result = Add(number1, number2);
                        Console.Write("Результат: {0} + {1} = {2}", number1, number2, result);
                        break;
                    }

                //if user input symbol "-"
                case "-":
                    {
                        int result = Sub(number1, number2);
                        Console.Write("Результат: {0} - {1} = {2}", number1, number2, result);
                        break;
                    }
                //if user input symbol "*"
                case "*":
                    {
                        int result = Mul(number1, number2);
                        Console.Write("Результат: {0} * {1} = {2}", number1, number2, result);
                        break;
                    }
                //if user input symbol "/"
                case "/":
                    {
                        //check division by zero
                        if (number2 == 0)
                        {
                            Console.Write("Warning! Division by zero. Please, input other value!");
                            break;
                        }
                        else
                        {
                            int result = Dev(number1, number2);
                            Console.Write("Результат: {0} / {1} = {2}", number1, number2, result);
                            break;
                        }
                    }
            }
            //Delay
            Console.ReadKey();

        }
    }
}
