using System;

namespace HobbiesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var hobbies = new Hobbies();
            Console.WriteLine(hobbies.PlayBasketballOld());
            Console.WriteLine(hobbies.PlayBasketballNew());
            Console.WriteLine(hobbies.PlayFootballNew());

            // [Obsolete("This method may be deleted in future version", true)] error = true;
            //Console.WriteLine(hobbies.PlayFootballOld());
        }
    }
}
