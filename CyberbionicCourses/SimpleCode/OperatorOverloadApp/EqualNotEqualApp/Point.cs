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

        //бинарный оператор ==
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }

        //бинарный оператор !=
        public static bool operator !=(Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", _x, _y);
        }

        // переопределяем метод Equals() который по умолчанию работает только с ссылочными типами.

        public override bool Equals(object o)
        {
            if (o is Point)
            {
                if (((Point)o)._x == _x && ((Point)o)._y == _y)
                    return true;
            }
            return false;
        }

        // переопределение GetHashCode() - обязательна при переопределении Equals().

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
