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
    }
}
