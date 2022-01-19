using System;
using WaterFactoriesApp.AbstractEntities;

namespace WaterFactoriesApp
{
    class CocaColaBottleSticker: AbstractBottleSticker
    {
        public override void SticksSticker()
        {
            Console.WriteLine("Processing: \tStick a sticker");
        }
    }
}
