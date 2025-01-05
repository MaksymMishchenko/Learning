using System;

namespace HobbiesApp
{
    internal class Hobbies
    {
        [Obsolete("This method may be deleted in future version", true)]
        public string PlayFootballOld()
        {
            return "You started play football";
        }

        public string PlayFootballNew()
        {
            return "You started play powerful football";
        }

        [Obsolete("This method may be deleted in future version", false)]
        public string PlayBasketballOld()
        {
            return "You started play football";
        }

        public string PlayBasketballNew()
        {
            return "You started play powerful football";
        }
    }
}
