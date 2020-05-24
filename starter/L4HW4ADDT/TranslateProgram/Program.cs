using System;
namespace TranslateProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фрукт на русском языке:");

            string word = Console.ReadLine();

            switch (word)
            {
                case "яблоко":
                {
                        Console.WriteLine("Ответ перевода: Apple");
                    break;
                }
                case "вишня":
                {
                        Console.WriteLine("Ответ: Cherry");
                        break;
                }
                case "апельсин":
                {
                    Console.WriteLine("Ответ: Orange");
                    break;
                }
                case "банан":
                {
                    Console.WriteLine("Ответ: Bananas");
                    break;
                }
                case "черешня":
                {
                    Console.WriteLine("Ответ: Cherries");
                    break;
                }
                case "арбуз":
                {
                    Console.WriteLine("Ответ: Watermelon");
                    break;
                }
                case "груша":
                {
                    Console.WriteLine("Ответ: Pear");
                    break;
                }
                case "слива":
                {
                    Console.WriteLine("Ответ: Plum");
                    break;
                }
                case "клубника":
                {
                    Console.WriteLine("Ответ: Strawberry");
                    break;
                }
                case "грейпфрут":
                {
                    Console.WriteLine("Ответ: Grapefruit");
                    break;
                }
                default:
                {
                    Console.WriteLine("В переводчике нету слова для перевода. Попробуйте ввести другое слово!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
