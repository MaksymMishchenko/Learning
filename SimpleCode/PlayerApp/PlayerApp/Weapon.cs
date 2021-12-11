using System;

namespace PlayerApp
{
    abstract class Weapon
    {
        public abstract int Damage { get; }
        public abstract void Fire();
        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name}, Damage: {Damage}");
        }
    }
}