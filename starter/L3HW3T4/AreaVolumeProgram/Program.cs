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

            {
                double Pi = 3.141, r = 5, H = 4; //Площадь S поверхности цилиндра вычисляется по формуле: S = 2πR2 + 2πR 2 = 2πR(R+h)
                double a = Pi * Math.Pow(r, 2) * 4;
                double b = r + H;
                var S = a = b;

                Console.WriteLine("Площадь поверхности цилиндра: {0} ", S);
            }
                Console.ReadKey();
        }
    }
}
