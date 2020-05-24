using System;

namespace TranslateProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите фрукт на русском языке:");

            string word = Console.ReadLine();
            string result = null;

            switch (word)
            {
                case "яблоко":
                {
                    result = "apple";
                    break;
                }
                case "вишня":
                {
                    result = "cherry";
                    break;
                }
                case "апельсин":
                {
                    result = "orange";
                    break;
                }
                case "банан":
                {
                    result = "bananas";
                    break;
                }
                case "черешня":
                {
                    result = "cherries";
                    break;
                }
                case "арбуз":
                {
                    result = "watermalon";
                    break;
                }
                case "груша":
                {
                    result = "pear";
                    break;
                }
                case "слива":
                {
                    result = "plum";
                    break;
                }
                case "клубника":
                {
                    result = "strawberry";
                    break;
                }
                case "грейпфрут":
                {
                    result = "grapefruit";
                    break;
                }
                default:
                {
                    Console.WriteLine("В переводчике нету слова для перевода. Попробуйте ввести другое слово!" );
                    break;
                }
            }
            Console.WriteLine("Translate: " + result);
            Console.ReadKey();
        }
    }
}
