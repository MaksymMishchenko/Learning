using System;
using WaterFactoriesApp.AbstractEntities;

namespace WaterFactoriesApp
{
    class PepsiColaBottle : AbstractBottle
    {
        public override void Pour(AbstractWater abstractWater)
        {
            Console.WriteLine("\tPouring water into a bottle PepsiCola");
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
