using System;

namespace ShapeProgram
{
    class Program
    {
        static void Main()
        {
            //create rectangle
            for (int col = 0; col < 10; col++)
            {

                for (int r = 0; r < 30; r++)
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
