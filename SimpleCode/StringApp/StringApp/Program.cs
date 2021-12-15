using System;

namespace StringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            string[] arrString = { "Нуль", "Один", "Два", "Три", "Четыре", "Пять", "Шесть", "Семь", "Восемь", "Девять" };
            int nextDigit;
            int index = 0;

            int userNumber = 5485;

            do
            {
                nextDigit = userNumber % 10;
                numbers[index] = nextDigit;
                index++;
                userNumber = userNumber / 10;
            } while (userNumber > 0);

            index--;

            for (; index >= 0; index--)
            {
                Console.Write(arrString[numbers[index]] + " ");
            }
        }
    }
}
