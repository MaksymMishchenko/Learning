using System.Collections;

namespace MySortedCollectionApp
{
    class InsensitiveComparerDescending : IComparer, IEqualityComparer
    {
        readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
        public int Compare(object x, object y)
        {
            return comparer.Compare(y, x);
        }

        public bool Equals(object x, object y)
        {
            return comparer.Compare(x, y) == 0;
        }

        public int GetHashCode(object obj)
        {
            return obj.ToString().ToLowerInvariant().GetHashCode();
        }
    }
}
