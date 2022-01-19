using System;
using WaterFactoriesApp.AbstractEntities;

namespace WaterFactoriesApp
{
    class CocaColaBottle : AbstractBottle
    {
        public override void Pour(AbstractWater abstractWater)
        {
            Console.WriteLine("Pouring water into a bottle");
        }

        public override void Spin(AbstractBottleCap cap)
        {
            Console.WriteLine("Screw on the cap");
        }

        public override void SticksSticker(AbstractBottleSticker sticker)
        {
            Console.WriteLine("Stick a sticker");
        }
    }
}
