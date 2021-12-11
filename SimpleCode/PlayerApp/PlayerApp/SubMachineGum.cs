using System;

namespace PlayerApp
{
    class SubMachineGum : Weapon
    {
        public override int Damage => 10;

        public override void Fire()
        {
            Console.WriteLine("Стреляем из автомата");
        }
    }
}