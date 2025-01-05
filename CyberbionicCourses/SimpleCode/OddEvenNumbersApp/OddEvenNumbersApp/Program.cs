using System;

namespace OddEvenNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Программа подсчета количества и суммы четных и нечетных чисел :)");
                    Console.WriteLine("Введите начальное число:");
                    int currentValue = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите последнее число:");
                    int limit = int.Parse(Console.ReadLine());

                    int oddNumbersCount = 0;
                    int evenNumbersCount = 0;

                    int oddNumberSum = 0;
                    int evenNumberSum = 0;

                    Count count = new Count();
                    count.GetOddEvenNumbers(currentValue, limit, ref oddNumbersCount, ref evenNumbersCount,
                        ref oddNumberSum, ref evenNumberSum);

                    Console.WriteLine("Количество нечетных чисел: " + oddNumbersCount);
                    Console.WriteLine("Количество четных чисел: " + evenNumbersCount);

                    Console.WriteLine("Сумма нечетных чисел: " + oddNumberSum);
                    Console.WriteLine("Сумма четных чисел: " + evenNumberSum);
                }
                catch (Exception)
                {
                    Console.WriteLine("Невозможно преобразовать строку в число! ");

                }
                Console.ReadKey();
            }
        }
    }
}
