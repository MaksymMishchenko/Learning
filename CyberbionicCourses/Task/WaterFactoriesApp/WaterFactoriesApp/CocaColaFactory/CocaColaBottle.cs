using System;
using System.Threading;
using WaterFactoriesApp.AbstractEntities;

namespace WaterFactoriesApp
{
    class CocaColaBottle : AbstractBottle
    {
        public override void Pour(AbstractWater abstractWater)
        {
            Thread.Sleep(500);
            Console.WriteLine("Processing: Pouring water into a bottle CocaCola");
        }

        public override void Spin(AbstractBottleCap cap)
        {
            Thread.Sleep(500);
            Console.WriteLine("Processing: Screw on the cap");
        }

        public override void SticksSticker(AbstractBottleSticker sticker)
        {
            Thread.Sleep(500);
            Console.Write("Processing: Stick a sticker");
        }
    }
}
