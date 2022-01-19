using System;
using System.Net.WebSockets;
using System.Threading;

namespace WaterFactoriesApp
{
    class CocaColaWater : AbstractWater
    {
        public string Water { get; } = "Purified water";
        public string Sugar { get; } = "BeetRoot sugar";
        public string Caffeine { get; } = "Caffeine";
        public string CocaExtract { get; set; } = "Coca extract";

        public override void Mix()
        {
            Thread.Sleep(2000);
            Console.WriteLine($"{Water}, {Sugar}, {Caffeine}, {CocaExtract}");
            Console.WriteLine();
        }
    }
}
