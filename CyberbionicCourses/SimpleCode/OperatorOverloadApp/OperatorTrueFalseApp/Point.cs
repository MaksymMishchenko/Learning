using System;
using System.Threading;

namespace OperatorTrueFalseApp
{
    class Point
    {
        private int _x, _y;

        public Point(int xPos, int yPos)
        {
            _x = xPos;
            _y = yPos;
        }

        public static bool operator true(Point a)
        {
            if (a._x != 0 || a._y != 0)
                return true;
            else
            {
                return false;
            }
        }

        public static bool operator false(Point a)
        {
            if (a._x == 0 && a._y == 0)
                return true;
            else
            {
                return false;
            }
        }

        public static Point operator --(Point a)
        {
            return new Point(a._x-1, a._y-1);
        }

        public void Show()
        {
            Console.WriteLine($"X: {_x}, Y: {_y}");
        }
    }
}
