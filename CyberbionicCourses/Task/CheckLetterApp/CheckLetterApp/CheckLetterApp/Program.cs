using System;

namespace CheckLetterApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите маленькую или большую букву: ");
            char letter = Char.Parse(Console.ReadLine());

            if (Char.IsLetter(letter))
            {
                CheckLetter value = new CheckLetter();
                var result = value.IsLower(letter);
                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Можно ввести только большую или маленькую букву. Попробуйте еще");
            }

            Console.ReadKey();
        }
    }
}
