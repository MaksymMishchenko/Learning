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
            throw new System.NotImplementedException();
        }

        public override AbstractBottleSticker CreateBottleSticker()
        {
            throw new System.NotImplementedException();
        }
    }
}
