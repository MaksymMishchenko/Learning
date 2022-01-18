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
    }
}
