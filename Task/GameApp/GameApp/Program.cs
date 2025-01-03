using System;
using GameApp.Weapons;

namespace GameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var hero = new Hero("Squidvard");
            hero.SetWeapon(new Broom());
            hero.Attack();

            hero.SetWeapon(new WaterGun());
            hero.Attack();
        }
    }
}
