using System;

namespace AreaVolumeProgram
{
    class Program
    {
        static void Main() //Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле: V = πR 2 h 
        {
            double R = 5, h = 4, pi = 3.141;
            var V = pi * Math.Pow(R, 2) * h;
            
            Console.WriteLine("Объем цилиндра равен: {0}", V);
            Console.ReadKey();
            

        }
    }
}
