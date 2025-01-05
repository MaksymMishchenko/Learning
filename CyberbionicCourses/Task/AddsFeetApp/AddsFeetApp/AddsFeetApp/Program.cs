using System;

namespace AddsFeetApp
{
    class Program
    {
        static void Main()
        {
            Distance dist = new Distance(3, 5.60F);

            int tempFeet = 0;
            float tempInches = 0;
            dist.SumFeetsAndInches(5, 7.40F, ref tempFeet, ref tempInches);

            Console.WriteLine($"{tempFeet}, {tempInches}");
        }
    }
}
