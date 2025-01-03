using System;

namespace ComparisonApp1
{
    class Program
    {
        static void Main()
        {
            {
                int x = 10, y = 12, z = 3;


                int result = x += y - x++ * z; //10+12 - 10*3 = -8 (правда не понятно в этом случае почему в правой половине уравнения множим 10*3, а не 11*3)

                Console.Write("Result of the first expression:");
                Console.WriteLine(result);
                
            }

            {
                int x = 10, y = 12, z = 3;

                int result1 = z = --x - y * 5; // 10=10-1 - 12*5 = -51  

                Console.Write("Result of the two expression:");
                Console.WriteLine(result1);
                
            }

            {
                int x = 10, y = 12, z = 3;

                int result = y /= x + 5 % z; // 12 / 10 + 5 % 3  не могу понять как работает

                Console.Write("Result of the three expression:");
                Console.WriteLine(result);

            }

            {
                int x = 10, y = 12, z = 3;

                int result = z = x++ + y * 5; // 3 = 10+1  + 12*5 = 71, на самом деле 70

                Console.Write("Result of the four expression:");
                Console.WriteLine(result);

            }

            {
                int x = 10, y = 12, z = 3;

                int result = x = y - x++ * z; //12 - 10+ 1*3   не могу понять куда пропадает инкремент.
                Console.Write("Result of the five expression:");
                Console.WriteLine(result);

            }
            Console.ReadKey();
        }


    }

}
