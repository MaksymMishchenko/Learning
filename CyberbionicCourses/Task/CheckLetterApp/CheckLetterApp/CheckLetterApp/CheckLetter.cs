using System;

namespace CheckLetterApp
{
    public class CheckLetter
    { 
        // 20 минут
        public bool IsLower(char _letter)
            {
                if (Char.IsUpper(_letter))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }

