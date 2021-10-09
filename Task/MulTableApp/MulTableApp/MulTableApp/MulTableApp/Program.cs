using System;

namespace MulTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // for (int i = 0x2500; i <= 0x2570; i += 0x10)
           // {
           //     for (int c = 0; c <= 0xF; ++c)
           //     {
           //         Console.WriteLine($"{(char) (i + c)} - i = {i}, c = {c}");
           //     }
           //
           //     Console.WriteLine();
           // }

           int result = 0;
           for (int i = 2; i <=10; i++)
           {
               for (int j = 2; j <= 10; j++)
               {
                   result = i * j;
                   Console.WriteLine($"{i} * {j} = {result}");
               }

               Console.WriteLine();
           }

        }
    }
}
