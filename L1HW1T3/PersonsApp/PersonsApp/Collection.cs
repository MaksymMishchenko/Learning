using System.Reflection.Metadata;

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
    }
}
