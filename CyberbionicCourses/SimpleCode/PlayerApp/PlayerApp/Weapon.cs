using System;
namespace PlayerApp
{
    abstract class Weapon : IHasInfo, IWeapon
    {
        public abstract int Damage { get; }
        public abstract void Fire();
        public void ShowInfo()
        {
            System.Console.WriteLine($"{GetType().Name}, Damage: {Damage}");
        }
    }
}