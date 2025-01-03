using System;

namespace CarApp
{
    class Car
    {
        private int _speed = 0;

        public void PrintSpeed()
        {
            if (_speed == 0)
            {
                Console.WriteLine("Стоим на месте...");
            }

            if (_speed > 0)
            {
                Console.WriteLine($"Едим со скоростью: {_speed}");
            }

            if (_speed < 0)
            {
                Console.WriteLine($"Едим назад со скоростью: {-_speed}");
            }
        }

        public void DriveForward()
        {
            _speed = 60;
        }

        public void Stop()
        {
            _speed = 0;
        }

        public void DriveBackward()
        {
            _speed = -5;
        }
    }
}
