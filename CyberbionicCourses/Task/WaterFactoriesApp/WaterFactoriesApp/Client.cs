using WaterFactoriesApp.AbstractEntities;

namespace WaterFactoriesApp
{
    class Client
    {
        private AbstractWater _water;
        private AbstractBottle _bottle;
        private AbstractBottleCap _bottleCap;
        private AbstractBottleSticker _bottleSticker;

        public Client(AbstractFactory abstractFactory)
        {
            _water = abstractFactory.CreateWater();
            _bottle = abstractFactory.CreateBottle();
            _bottleCap = abstractFactory.CreateBottleCup();
            _bottleSticker = abstractFactory.CreateBottleSticker();

        }

        public void Run()
        {
            _water.Mix();
            _bottle.Pour(_water);
            _bottle.Spin(_bottleCap);
            _bottle.SticksSticker(_bottleSticker);
        }
    }
}
