using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Введите первое число");
                    double firstNumber = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    double secondNumber = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите операцию: '+', '-', '*', '/'");

                    ConsoleKey consoleKey = Console.ReadKey().Key;

                    if (consoleKey == ConsoleKey.Add)
                    {
                        double add = calc.Sum(firstNumber, secondNumber);
                        Console.Clear();
                        Console.WriteLine($"Результат операции: {add}");
                    }

                    else if (consoleKey == ConsoleKey.Subtract)
                    {
                        double sub = calc.Subtract(firstNumber, secondNumber);
                        Console.Clear();
                        Console.WriteLine($"Результат операции: {sub}");
                    }

                    else if (consoleKey == ConsoleKey.Multiply)
                    {
                        double mul = calc.Mul(firstNumber, secondNumber);
                        Console.Clear();
                        Console.WriteLine($"Результат операции: {mul}");
                    }

                    else if (consoleKey == ConsoleKey.Divide)
                    {
                        if (secondNumber == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("На 0 делить нельзя!");
                        }
                        else
                        {
                            double dev = calc.Div(firstNumber, secondNumber);
                            Console.Clear();
                            Console.WriteLine($"Результат операции: {dev}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неверную арифметическую операцию.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Невозможно преобразовать строку в число!");
                    Console.ReadKey();
                    continue;
                }
                Console.ReadKey();
            }
        }
    }
}
