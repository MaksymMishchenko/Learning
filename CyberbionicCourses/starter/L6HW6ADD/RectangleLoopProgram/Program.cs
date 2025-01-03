using System;

namespace RectangleLoopProgram
{
    class Program
    {
        static void Main()
        {// create loop for
            for (int i = 0; i < 10; i++)
            {//create nested loop for on body first loop for 
                for (int r = 0; r < 20; r++)
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
