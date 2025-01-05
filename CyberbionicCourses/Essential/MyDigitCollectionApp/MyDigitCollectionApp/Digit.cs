using System.Collections;

namespace MyDigitCollectionApp
{
    class Digit
    {
        public IEnumerable GetEnumerator(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    yield return arr[i];
                }
            }
        }
    }
}
