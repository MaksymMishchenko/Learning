using System;
using WaterFactoriesApp.AbstractEntities;

namespace WaterFactoriesApp
{
    class PepsiColaBottle : AbstractBottle
    {
        public override void Pour(AbstractWater abstractWater)
        {
            Console.WriteLine("Pouring water into a bottle");
        }

        public override void Spin(AbstractBottleCap cap)
        {
            throw new NotImplementedException();
        }

        public override void SticksSticker(AbstractBottleSticker cap)
        {
            throw new NotImplementedException();
        }
    }
}
