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

        //унарный оператор инкремента
        public static Point operator ++(Point a)
        {
            return new Point(a._x + 1, a._y + 1);
        }

        //унарный оператор декремента
        public static Point operator --(Point a)
        {
            return new Point(a._x - 1, a._y - 1);
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", _x, _y);
        }
    }
}
