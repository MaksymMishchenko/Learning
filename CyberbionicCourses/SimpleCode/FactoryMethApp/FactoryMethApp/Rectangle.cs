using System;

namespace FactoryMethApp
{
    class Rectangle
    {
        private int _x, _y;

        public Rectangle Factory(int x, int y)
        {
            var rect = new Rectangle();
            rect._x = x;
            rect._y = y;

            return rect;
        }

        public void Show()
        {
            Console.WriteLine($"{_x} {_y}");
        }
    }
}