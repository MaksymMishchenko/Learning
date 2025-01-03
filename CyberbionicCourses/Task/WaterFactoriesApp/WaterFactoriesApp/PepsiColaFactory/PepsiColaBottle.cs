using System;
using System.Threading;
using WaterFactoriesApp.AbstractEntities;

namespace WaterFactoriesApp
{
    class PepsiColaBottle : AbstractBottle
    {
        public override void Pour(AbstractWater abstractWater)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Processing: Pouring water into a bottle PepsiCola");
        }

        public override void Spin(AbstractBottleCap cap)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Processing: Screw on the cap");
        }

        public override void SticksSticker(AbstractBottleSticker sticker)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Processing: Stick a sticker");
        }
    }
}
