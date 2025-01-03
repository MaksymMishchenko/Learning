using System;
using System.Collections;

namespace MyDigitCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var digit = new Digit();
            IEnumerable collection = digit.GetEnumerator(arr);
            PrintCollection(collection);
        }

        static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
