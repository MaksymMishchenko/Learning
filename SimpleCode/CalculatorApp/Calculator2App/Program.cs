using System;

namespace Calculator2App
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();

                MyCalculator calc = new MyCalculator();

                try
                {
                    Console.WriteLine("Введите первое число:");
                    double firstNumber = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    double secondNumber = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите операцию: +, -, *, /");

                    char operation = char.Parse(Console.ReadLine());

                    switch (operation)
                    {
                        case '+':
                        {
                            double add = calc.Sum(firstNumber, secondNumber);
                            Console.WriteLine(add);
                            break;
                        }

                        case '-':
                        {
                            double sub = calc.Subtract(firstNumber, secondNumber);
                            Console.WriteLine(sub);
                            break;
                        }

                        case '*':
                        {
                            double mul = calc.Mul(firstNumber, secondNumber);
                            Console.Clear();
                            Console.WriteLine(mul);
                            break;
                        }

                        case '/':
                        {
                            if (firstNumber == 0)
                            {
                                Console.WriteLine("На 0 делить нельзя!");
                            }
                            else
                            {
                                double dev = calc.Div(firstNumber, secondNumber);
                                Console.WriteLine(dev);
                            }

                            break;
                        }
                        default:
                        {
                            Console.WriteLine("Вы ввели неверную информацию!");
                            break;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Не получается преобразовать строку в число!");
                }

                Console.ReadKey();
            }
        }
    }
}
