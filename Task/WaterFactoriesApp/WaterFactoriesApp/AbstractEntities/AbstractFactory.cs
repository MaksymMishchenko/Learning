using WaterFactoriesApp.AbstractEntities;

namespace WaterFactoriesApp
{
    abstract class AbstractFactory
    {
        public abstract AbstractWater CreateWater();
        public abstract AbstractBottle CreateBottle();

        public abstract AbstractBottleCap CreateBottleCup();
        public abstract AbstractBottleSticker CreateBottleSticker();
    }
}
