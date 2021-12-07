using System;

namespace GunApp
{
    class Gun
    {
        private bool IsLoaded;


        private void Reload()
        {
            Console.WriteLine("Заряжаю");
            IsLoaded = true;
            Console.WriteLine("Заряжено!");
        }

        public void Shoot()
        {
            if (!IsLoaded)
            {
                Console.WriteLine("Оружие не заряжено!");
                Reload();
            }

            Console.WriteLine("Пыщ... Пыщ...");
            IsLoaded = false;
        }
    }
}
