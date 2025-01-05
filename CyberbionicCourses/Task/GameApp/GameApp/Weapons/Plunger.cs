using System;

namespace GameApp.Weapons
{
    internal class Plunger : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("Attacks with a plunger");
        }
    }
}
