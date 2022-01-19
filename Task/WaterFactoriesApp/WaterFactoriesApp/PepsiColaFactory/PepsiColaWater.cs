using System;
using System.Reflection.Metadata;
using System.Threading;

namespace WaterFactoriesApp
{
    class PepsiColaWater : AbstractWater
    {
        public string Water { get; } = "Purified water";
        public string Sugar { get; } = "BeetRoot sugar";
        public string Caffeine { get; } = "Caffeine";
        public string Dye { get; } = "Dye sugar color";
        public string Type { get; } = "Orthophosphoric acid";

        public override void Mix()
        {
            Thread.Sleep(2000);
            Console.WriteLine($"{Water}, {Sugar}, {Caffeine}, {Dye}, {Type}\n");
        }
    }
}
