using PhoneListApp.PhoneBook;

namespace PhoneListApp
{
    internal class PhoneList<T> where T : PhoneNumber
    {
        T[] _phList;
        int _end;

        public PhoneList()
        {
            _phList = new T[10];
            _end = 0;
        }

        public bool AddItem(T newEntry)
        {
            if (_end == 10) { return false; }

            _phList[_end] = newEntry;
            _end++;
            return true;
        }

        public T FindByName(string name)
        {
            for (int i = 0; i < _end; i++)
            {
                if (_phList[i].Name == name)
                {
                    return _phList[i];
                }
            }

            throw new KeyNotFoundException();
        }

        public T FindByPhone(string phone)
        {
            for (int i = 0; i < _end; i++)
            {
                if (_phList[i].Number == phone)
                {
                    return _phList[i];
                }
            }

            throw new KeyNotFoundException();
        }
    }
}
