using System;

namespace ShapeTriangleDotNet
{
    class Program
    {
        static void Main()
        {
            //start printing characters in a string
            int g = 24;

            //Characters
            int z = 2;
            //8 lines
            for (int i = 0; i < 8; i++)
            {
                //print in line
                for (int j = 0; j < 52; j++)
                {
                    Console.Write(" ");
                    if (j == g)
                    {
                        for (int s = 0; s < z; s++)
                            Console.Write("*");
                    }
                }
                g -= 1;
                z += 2;
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
