using System;

namespace PlayerApp
{
    class Knife : Weapon, IThrowingWeapon
    {
        public override int Damage => 3;

        public override void Fire()
        {
            System.Console.WriteLine("Бьем ножом");
        }

        public void Throw()
        {
            System.Console.WriteLine("Метаем нож");
        }
    }
}