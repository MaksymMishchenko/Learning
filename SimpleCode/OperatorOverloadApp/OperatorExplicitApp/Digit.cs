namespace OperatorExplicitApp
{
    struct Digit
    {
        private byte _value;

        public Digit(byte value)
        {
            _value = value;
        }

        // пример перегрузки оператора явного преобразования типа byte-to-Digit

        public static explicit operator Digit(byte argument)
        {
            Digit digit = new Digit(argument);
            return digit;
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
