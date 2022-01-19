using System;
using WaterFactoriesApp.AbstractEntities;

namespace WaterFactoriesApp
{
    class CocaColaBottle : AbstractBottle
    {
        public override void Pour(AbstractWater abstractWater)
        {
            Console.WriteLine("\tPouring water into a bottle CocaCola");
        }

        public override void Spin(AbstractBottleCap cap)
        {
            Console.WriteLine("\tScrew on the cap");
        }

        public override void SticksSticker(AbstractBottleSticker sticker)
        {
            Console.WriteLine("\tStick a sticker");
        }
    }
}
