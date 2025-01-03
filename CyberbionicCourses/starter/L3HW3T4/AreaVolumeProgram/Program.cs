using System;
namespace AreaVolumeProgram
{
    class Program
    {
        static void Main() //Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле: V = πR 2 h 
        {
            double R = 15, h = 14, pi = 3.141;
            var V = pi * Math.Pow(R, 2) * h;
            
            Console.WriteLine("Объем цилиндра равен: {0}", V);

            {
                double Pi = 3.141, r = 15, H = 14; //Площадь S поверхности цилиндра вычисляется по формуле: S = 2πR2 + 2πR 2 = 2πR(R+h)
                var S  = (2 * Pi * r *(r+H));
                
                Console.WriteLine("Площадь поверхности цилиндра: {0} ", S);
            }
                Console.ReadKey();
        }
    }
}
