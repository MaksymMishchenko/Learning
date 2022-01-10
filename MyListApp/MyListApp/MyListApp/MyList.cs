using System;

namespace MyListApp
{
    class MyList<T>
    {
        /// <summary>
        /// Generic field
        /// </summary>
        private T[] _newList = new T[0];

        /// <summary>
        /// Indexer of the array
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index] => _newList[index];

        /// <summary>
        /// Returns lenght of the list
        /// </summary>
        public int NewList
        {
            get { return _newList.Length; }
        }

        /// <summary>
        /// Adds items to list
        /// </summary>
        /// <param name="number"></param>
        public void Add(T number)
        {
            T[] newArray = new T[_newList.Length + 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < _newList.Length)
                {
                    newArray[i] = _newList[i];
                }
                else
                {
                    newArray[i] = number;
                }
            }
            _newList = newArray;
        }

        /// <summary>
        /// Inserts elements to List by index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="number"></param>
        public void Insert(int index, T number)
        {
            T[] newArray = new T[_newList.Length + 1];

            for (int i = 0, j = 0; i < newArray.Length; i++)
            {
                if (i == index)
                {
                    newArray[i] = number;
                }
                else if (i != index)
                {
                    newArray[i] = _newList[j];
                    j++;
                }
                else
                {
                    newArray[i] = _newList[i];
                }
            }

            _newList = newArray;
        }

        /// <summary>
        /// Shows  items from the collection
        /// </summary>
        public void Show()
        {
            foreach (var el in _newList)
            {
                Console.WriteLine($"Item: {el}");
            }
        }
    }
}
