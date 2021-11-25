using System;

namespace Triangle4App
{
    class Program
    {
        static void Main(string[] args)
        {

            int height = 5;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = height; k > i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
