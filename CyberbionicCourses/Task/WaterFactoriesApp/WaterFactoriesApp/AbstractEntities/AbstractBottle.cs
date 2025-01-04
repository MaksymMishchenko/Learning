using WaterFactoriesApp.AbstractEntities;

namespace WaterFactoriesApp
{
    abstract class AbstractBottle
    {
        public abstract void Pour(AbstractWater abstractWater);
        public abstract void Spin(AbstractBottleCap cap);
        public abstract void SticksSticker(AbstractBottleSticker cap);
    }
}
