using GenericInterfaceApp.Interfaces;

namespace GenericInterfaceApp.Entities
{
    internal class ByTwos<T> : ISeries<T>
    {
        T _start;
        T _val;

        public delegate T IncByTwo(T v);
        IncByTwo _incr;

        public ByTwos(IncByTwo incr)
        {
            _start = default;
            _val = default;
            _incr = incr;
        }
        public T GetNext()
        {
            _val = _incr(_val);
            return _val;
        }

        public void Reset()
        {
            _val = _start;
        }

        public void SetStart(T v)
        {
            _start = v;
            _val = _start;
        }
    }
}
