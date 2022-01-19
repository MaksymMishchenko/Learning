using System;
using WaterFactoriesApp.AbstractEntities;

namespace WaterFactoriesApp
{
    class PepsiColaBottleCup : AbstractBottleCap
    {
        public override void Spin(AbstractBottleSticker sticker)
        {
            Console.WriteLine("Screw on the cap");
        }
    }
}
