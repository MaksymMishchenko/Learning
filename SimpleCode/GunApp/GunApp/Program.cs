using System;

namespace GunApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var gun = new Gun(true);
            gun.Shoot();
        }
    }
}
