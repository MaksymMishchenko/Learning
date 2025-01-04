using System;

namespace FactoryMethodApp
{
    class Rectangle
    {
        private int _width, _height;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public int GetArea()
        {
            return _width * _height;
        }

        public void Show()
        {
            Console.WriteLine($"Width: {_width}, height: {_height}");
        }

        //method returns new type Rectangle
        public Rectangle Factor(int factor)
        {
            return new Rectangle(_width * factor, _height * factor);
        }
    }
}
