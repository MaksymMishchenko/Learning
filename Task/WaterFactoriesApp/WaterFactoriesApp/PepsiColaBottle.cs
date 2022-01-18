using System;

namespace WaterFactoriesApp
{
    class PepsiColaBottle : AbstractBottle
    {
        public override void Pour(AbstractWater abstractWater)
        {
            Console.WriteLine("Pouring water into a bottle");
        }
    }
}
