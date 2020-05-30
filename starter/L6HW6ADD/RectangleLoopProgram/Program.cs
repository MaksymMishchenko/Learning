using System;

namespace RectangleLoopProgram
{
    class Program
    {
        static void Main()
        {// create loop for
            for (int vertical = 0; vertical < 9; vertical++)
            {//create nested loop for on body first loop for 
                for (int horizont = 0; horizont < 25; horizont++)
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
