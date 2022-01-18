using System;

namespace WaterFactoriesApp
{
    class CocaColaBottle : AbstractBottle
    {
        public override void Pour(AbstractWater abstractWater)
        {
            Console.WriteLine("Pouring water into a bottle");
        }
    }
}
