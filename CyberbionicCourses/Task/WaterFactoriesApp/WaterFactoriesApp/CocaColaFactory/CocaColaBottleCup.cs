using System;
using WaterFactoriesApp.AbstractEntities;

namespace WaterFactoriesApp
{
    class CocaColaBottleCap : AbstractBottleCap
    {
        public override void Spin()
        {
            Console.WriteLine("Processing: \tSpin the cap");
        }
    }
}
