﻿using System;

namespace PlayerApp
{
    class Knife : Weapon, IThrowingWeapon
    {
        public override int Damage => 3;

        public override void Fire()
        {
            Console.WriteLine("Бьем ножом");
        }

        public void Throw()
        {
            Console.WriteLine("Метаем нож");
        }
    }
}