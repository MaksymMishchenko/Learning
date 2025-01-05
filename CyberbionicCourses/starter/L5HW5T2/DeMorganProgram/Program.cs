using System;

namespace DeMorganProgram
{
    class Program
    {
        static void Main()
        {
            bool A = false;
            bool B = true;
            //condition before applying de Morgan's theorem
            if (A | B)
            {
                Console.WriteLine("(A | B) = {0}", (A | B));
            }
            //condition after applying de Morgan's theorem
            if (!(!A & !B))
            {
                Console.WriteLine("!(!A & !B) = {0}", !(!A & !B));
            }

            Console.ReadKey();
        }
    }
}
