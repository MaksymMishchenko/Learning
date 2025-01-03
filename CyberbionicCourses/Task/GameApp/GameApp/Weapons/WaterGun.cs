using System;

namespace GameApp.Weapons
{
    class WaterGun : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("Attacks with a water gun");
        }
    }
}
