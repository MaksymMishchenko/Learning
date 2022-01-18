namespace WaterFactoriesApp
{
    class Client
    {
        private AbstractWater _water;
        private AbstractBottle _bottle;

        public Client(AbstractFactory abstractFactory)
        {
            _water = abstractFactory.CreateWater();
            _bottle = abstractFactory.CreateBottle();
        }

        public void Run()
        {
            _bottle.Pour(_water);
        }
    }
}
