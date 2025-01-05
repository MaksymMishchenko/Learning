using System;

namespace OperatorLogicalEx2App
{
    struct Point
    {
        private int _x, _y;

        public Point(int xPos, int yPos)
        {
            _x = xPos;
            _y = yPos;
        }
        public static Point operator |(Point op1, Point op2)
        {
            if ((op1._x != 0) || (op1._y != 0) |
                (op2._x != 0) || op2._y != 0)
                return new Point(1, 1);
            else
                return new Point(0, 0);
        }

        // Перегрузить логический оператор & для укороченного вычисления.
        public static Point operator &(Point op1, Point op2)
        {
            if ((op1._x != 0 && op1._y != 0) &
                (op2._x != 0) && op2._y != 0)
                return new Point(1, 1);
            else
                return new Point(0, 0);
        }

        // Перегрузить логический оператор !.
        public static bool operator !(Point op)
        {
            if (op) return false;
            else return true;
        }
        // Перегрузить оператор true.
        public static bool operator true(Point op)
        {
            if ((op._x != 0) || (op._y != 0))
                return true; // хотя бы одна координата не равна нулю
            else
                return false;
        }

        // Перегрузить оператор false.
        public static bool operator false(Point op)
        {
            if ((op._x == 0) && (op._y == 0))
                return true; // все координаты равны нулю
            else
                return false;
        }
        // Ввести координаты X, Y, Z.
        public void Show()
        {
            Console.WriteLine(_x + ", " + _y);
        }

    }
}
