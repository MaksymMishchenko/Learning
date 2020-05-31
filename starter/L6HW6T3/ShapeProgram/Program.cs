using System;

namespace ShapeProgram
{
    class Program
    {
        static void Main()
        {
            //right triangle
            for (int col = 0; col < 15; col++)
            {
                for (int r = 0; r < col; r++)
                {
                    //display on screen
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
