using WaterFactoriesApp.AbstractEntities;

namespace WaterFactoriesApp
{
    class PepsiColaFactory : AbstractFactory
    {
        public override AbstractWater CreateWater()
        {
            return new PepsiColaWater();
        }

        public override AbstractBottle CreateBottle()
        {
            return new PepsiColaBottle();
        }

        public override AbstractBottleCap CreateBottleCup()
        {
            return new PepsiColaBottleCup();
        }

        public override AbstractBottleSticker CreateBottleSticker()
        {
            return new PepsiColaBottleSticker();
        }
    }
}
