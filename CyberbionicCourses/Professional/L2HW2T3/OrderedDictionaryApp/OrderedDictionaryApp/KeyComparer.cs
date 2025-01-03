using System.Collections;

namespace OrderedDictionaryApp
{
    internal class KeyComparer : IEqualityComparer
    {
        private readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
        public bool Equals(object x, object y)
        {
            Sportsman xs = x as Sportsman;
            Sportsman ys = y as Sportsman;
            return xs.Key == ys.Key;
        }

        public int GetHashCode(object obj)
        {
            return (obj as Sportsman).Key;
        }
    }
}