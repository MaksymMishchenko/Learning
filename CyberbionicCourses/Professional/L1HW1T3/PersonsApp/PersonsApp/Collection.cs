using System;
using System.Collections;

namespace PersonsApp
{
    class Collection : IEnumerable, IEnumerator, IDisposable
    {
        private static Citizen[] _collection = Array.Empty<Citizen>();

        public int Count = _collection.Length;

        private int _position = -1;

        /// <summary>
        /// Adds citizens to collection
        /// </summary>
        /// <param name="citizen"></param>
        public void Add(Citizen citizen)
        {
            try
            {
                for (int i = 0; i < _collection.Length; i++)
                {
                    if (_collection[i].PassportId == citizen.PassportId)
                    {
                        throw new ArgumentException($"Citizen {_collection[i].Name} with Password Id - {_collection[i].PassportId} was added earlier!");
                    }
                }

                if (citizen is Retired retired)
                {
                    int i = 0;
                    Citizen[] newCollection = new Citizen[_collection.Length + 1];
                    newCollection[i] = retired;
                    _collection.CopyTo(newCollection, 1);
                    Console.WriteLine($"Citizen {citizen.Name} was added by index: {i}");
                    _collection = newCollection;
                }
                else
                {
                    Citizen[] newCollection = new Citizen[_collection.Length + 1];
                    _collection.CopyTo(newCollection, 0);
                    newCollection[newCollection.Length - 1] = citizen;
                    Console.WriteLine($"Citizen {citizen.Name} was added by index: {newCollection.Length - 1}");
                    _collection = newCollection;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Removes citizen from collection
        /// </summary>
        /// <param name="citizen"></param>
        public void Remove(Citizen citizen)
        {
            Citizen[] newCollection = new Citizen[_collection.Length - 1];

            for (int i = 0, j = 0; i < _collection.Length; i++, j++)
            {
                if (_collection[i] == citizen)
                {
                    j--;
                    continue;
                }

                newCollection[j] = _collection[i];
            }

            _collection = newCollection;
        }

        /// <summary>
        /// Removes first citizen from collection
        /// </summary>
        public void RemoveFirst()
        {
            Citizen[] newCollection = new Citizen[_collection.Length - 1];

            for (int i = 0, j = 0; i < _collection.Length; i++, j++)
            {
                if (i == 0)
                {
                    j--;
                    continue;
                }

                newCollection[j] = _collection[i];
            }

            _collection = newCollection;
        }

        /// <summary>
        /// Finds citizen in collection
        /// </summary>
        /// <param name="citizen"></param>
        /// <returns></returns>
        public bool Contains(Citizen citizen)
        {
            for (int i = 0; i < _collection.Length; i++)
            {
                if (_collection[i] == citizen)
                {
                    Console.WriteLine($"Citizen {citizen.Name} contains by index - {i}");
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Returns last citizen from collection
        /// </summary>
        /// <returns></returns>
        public Citizen ReturnLast()
        {
            Console.WriteLine($"Index of last element in collection: {_collection.Length - 1}");
            return _collection[^1];
        }

        /// <summary>
        /// Clears collection
        /// </summary>
        public void Clear()
        {
            _collection = Array.Empty<Citizen>();
        }

        /// <summary>
        /// Returns enumerator
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        /// <summary>
        /// Moves by each element of the collection
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            while (true)
            {
                if (_position < _collection.Length - 1)
                {
                    _position++;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Returns field position by -1 
        /// </summary>
        public void Reset()
        {
            _position = -1;
        }

        /// <summary>
        /// Returns current object in collection
        /// </summary>
        public object Current => _collection[_position];

        /// <summary>
        /// Finalize object and returns current fields position by -1
        /// </summary>
        public void Dispose()
        {
            Reset();
        }
    }
}
