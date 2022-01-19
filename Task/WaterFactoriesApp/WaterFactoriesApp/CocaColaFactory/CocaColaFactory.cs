using System;
using WaterFactoriesApp.AbstractEntities;

namespace WaterFactoriesApp
{
    class CocaColaFactory : AbstractFactory
    {
        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }

        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }

        public override AbstractBottleCap CreateBottleCup()
        {
            return new CocaColaBottleCup();
        }


        public override AbstractBottleSticker CreateBottleSticker()
        {
            return new CocaColaBottleSticker();
        }
    }
}
