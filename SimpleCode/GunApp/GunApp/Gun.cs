using System;

namespace GunApp
{
    class Gun
    {
        private bool _isLoaded;

        public Gun(bool isLoaded)
        {
            _isLoaded = isLoaded;    
        }

        private void Reload()
        {
            Console.WriteLine("Заряжаю");
            _isLoaded = true;
            Console.WriteLine("Заряжено!");
        }

        public void Shoot()
        {
            if (!_isLoaded)
            {
                Console.WriteLine("Оружие не заряжено!");
                Reload();
            }

            Console.WriteLine("Пыщ... Пыщ...");
            _isLoaded = false;
        }
    }
}
