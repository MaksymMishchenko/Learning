namespace OperatorImplicitApp
{
    struct Digit
    {
        private byte _value;

        public Digit(byte value)
        {
            _value = value;
        }

        // оператор неявного преобразования типа byte-to-Digit
        public static implicit operator Digit(byte argument)
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
