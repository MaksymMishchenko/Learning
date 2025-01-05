namespace MyDictionaryApp
{
    class MyDictionary<T, R>
    {
        private T[] _key = new T[0];
        private R[] _val = new R[0];

        /// <summary>
        /// Returns dictionary length
        /// </summary>
        public int GetLength => _key.Length;

        /// <summary>
        /// Returns item by index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < _key.Length)
                    return _key[index] + " - " + _val[index];
                return "Попытка обращения за пределы массива.";
            }
        }

        /// <summary>
        /// Adds item to dictionary
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void Add(T index, R value)
        {
            T[] newKey = new T[_key.Length + 1];
            R[] newValue = new R[_val.Length + 1];

            for (int i = 0; i < newKey.Length; i++)
            {
                if (i < _key.Length && i < _val.Length)
                {
                    newKey[i] = _key[i];
                    newValue[i] = _val[i];
                }
                else
                {
                    newKey[i] = index;
                    newValue[i] = value;
                }
            }

            _key = newKey;
            _val = newValue;
        }
    }
}