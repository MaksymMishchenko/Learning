namespace PersonsApp
{
    class Collection
    {
        private static Citizen[] _collection = new Citizen[0];

        public int Count = _collection.Length;

        public void Add(Citizen citizen)
        {
            if (citizen is Retired retired)
            {
                Citizen[] newCollection = new Citizen[_collection.Length + 1];
                newCollection[0] = retired;
                _collection.CopyTo(newCollection, 1);
                _collection = newCollection;
            }
            else
            {
                Citizen[] newCollection = new Citizen[_collection.Length + 1];
                _collection.CopyTo(newCollection, 0);
                newCollection[newCollection.Length - 1] = citizen;
                _collection = newCollection;
            }
        }

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
        }
    }
}
