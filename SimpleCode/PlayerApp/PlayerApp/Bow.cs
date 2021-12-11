using System;

namespace PlayerApp
{
    class Bow : Weapon
    {
        public override int Damage => 5;

        public override void Fire()
        {
            System.Console.WriteLine("Стреляем из лука, как Робин Гуд:)");
        }
    }
}