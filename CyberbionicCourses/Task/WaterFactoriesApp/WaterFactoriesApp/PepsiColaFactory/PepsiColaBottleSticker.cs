using System;
using WaterFactoriesApp.AbstractEntities;

namespace WaterFactoriesApp
{
    class PepsiColaBottleSticker : AbstractBottleSticker
    {
        public override void SticksSticker()
        {
            Console.WriteLine("Stick a sticker");
        }
    }
}
