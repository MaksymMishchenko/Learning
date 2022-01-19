using System;
using WaterFactoriesApp.AbstractEntities;

namespace WaterFactoriesApp
{
    class CocaColaBottleCup : AbstractBottleCap
    {
        public override void Spin(AbstractBottleSticker sticker)
        {
            Console.WriteLine("Spin the cap");
        }
    }
}
