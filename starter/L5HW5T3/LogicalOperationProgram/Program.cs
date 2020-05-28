using System;

namespace LogicalOperationProgram
{
    class Program
    {
        static void Main()
        {
            int x = 5, y = 10, z = 15;

            {
                //15 >> 75 = 
                var result = x += y >> x++ * z;
                Console.WriteLine("Result of the x mathematical expression: {0}", result);
            }
            {
                //6 & 50 = 
                var result = z = ++x & y * 5;
                
                Console.WriteLine("Result of the z mathematical expression: {0}", result);
            }
            {
                //7 | 15 = 
                var result = y /= x + 5 | z;

                Console.WriteLine("Result of the y mathematical expression: {0}", result);
            }
            {
                //10 << 64 = 
                var result = x = y << x++ ^ z;

                Console.WriteLine("Result of the x mathematical expression {0}", result);
            }
            Console.ReadKey();
        }
    }
}
