using System.Drawing;

namespace OperatorExplicitApp
{
    struct Digit
    {
        private int _x, _y;

        public Digit(int x, int y)
        {
            _x = x;
            _y = y;
        }

        // пример перегрузки оператора явного преобразования типа byte-to-Digit

        public static explicit operator int(Digit o)
        {
            return o._x * o._y;
        }

        public override string ToString()
        {
            return string.Format("{0}", _x + _y);
        }
    }
}
