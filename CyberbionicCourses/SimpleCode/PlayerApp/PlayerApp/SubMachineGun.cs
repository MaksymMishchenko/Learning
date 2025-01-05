using System;

namespace PlayerApp
{
    class SubMachineGun : Weapon
    {
        public override int Damage => 10;

        public override void Fire()
        {
            System.Console.WriteLine("Стреляем из автомата");
        }
    }
}