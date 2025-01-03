namespace OperatorOverloadApp
{
    struct Point
    {
        private int _x, _y;

        public Point(int xPos, int yPos)
        {
            _x = xPos;
            _y = yPos;
        }

        //бинарный оператор сложения
        public static Point operator +(Point a, Point b)
        {
            return new Point(a._x + b._x, a._y + b._y);
        }

        //бинарный оператор вычитания
        public static Point operator -(Point a, Point b)
        {
            return new Point(a._x - b._x, a._y - b._y);
        }

        //бинарный оператор умножения
        public static Point operator *(Point a, Point b)
        {
            return new Point(a._x * b._x, a._y * b._y);
        }

        //бинарный оператор деления
        public static Point operator /(Point a, Point b)
        {
            return new Point(a._x / b._x, a._y / b._y);
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", _x, _y);
        }

        // использование перегрузок и вызов посредством методов
        public static Point Add(Point p1, Point p2)
        {
            return p1 + p2;
        }

        public static Point Subtract(Point p1, Point p2)
        {
            return p1 - p2;
        }
    }
}
