using System;

namespace OperatorLogicalApp
{
    struct Point
    {
        private int _x, _y;

        public Point(int xPos, int yPos)
        {
            _x = xPos;
            _y = yPos;
        }

        public static bool operator |(Point a, Point b)
        {
            if (a._x != 0 || a._y != 0 | b._x != 0 || b._y != 0)
                return true;
            else
            {
                return false;
            }
        }

        public static bool operator &(Point a, Point b)
        {
            if (a._x != 0 && a._y != 0 & b._x != 0 && b._y != 0)
                return true;
            else return false;
            
        }

        public static bool operator !(Point a)
        {
            if (a._x != 0 || a._y != 0)
                return false;
            else
            {
                return true;
            }
        }

        public void Show()
        {
            Console.WriteLine($"X: {_x}, Y: {_y}");
        }
    }
}
