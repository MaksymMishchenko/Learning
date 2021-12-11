using System;

namespace PlayerApp
{
    class Gun : Weapon
    {
        public override int Damage => 8;

        public override void Fire()
        {
            System.Console.WriteLine("Стреляем из пистолета");
        }
    }
}