using System;

namespace CheckLetterApp
{
    public class CheckLetter
    { 
        // 20 минут
        public int IsLower(char _letter)
            {
                if (Char.IsUpper(_letter))
                {
                    Console.WriteLine("Вы ввели заглавную букву");
                    return 0;
                }
                else
                {
                    Console.WriteLine("Вы ввели строчную букву");
                    return 1;
                }
            }
        }
    }

