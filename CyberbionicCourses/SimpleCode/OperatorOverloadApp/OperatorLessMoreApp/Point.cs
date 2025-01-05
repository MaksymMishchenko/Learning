using System;

namespace OperatorOverloadApp
{
    struct Point : IComparable
    {
        private int _x, _y;

        public Point(int xPos, int yPos)
        {
            _x = xPos;
            _y = yPos;
        }

        //бинарный оператор >
        public static bool operator >(Point a, Point b)
        {
            return (a.CompareTo(b) > 0);
        }

        //бинарный оператор <
        public static bool operator <(Point a, Point b)
        {
            return (a.CompareTo(b) < 0);
        }

        //бинарный оператор >=
        public static bool operator >=(Point a, Point b)
        {
            return (a.CompareTo(b) >= 0);
        }

        //бинарный оператор <=
        public static bool operator <=(Point a, Point b)
        {
            return (a.CompareTo(b) <= 0);
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", _x, _y);
        }

        // реализация интерфейса IComparable
        public int CompareTo(object? obj)
        {
            if (obj is Point)
            {
                Point p = (Point)obj;
                if (_x > p._x && _y > p._y)
                {
                    return 1;
                }

                else if(_x < p._x && _y < p._y)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
