using System;
using System.Collections.Generic;

namespace CompanyAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // first version
            var dictionary = new Dictionary<int, decimal>();
            dictionary.Add(125485464, 125000.23M);
            dictionary.Add(598632158, 253000.80M);
            dictionary.Add(542315488, 530000.56M);

            // second version
            var sortedList = new SortedList<int, decimal>();
            sortedList.Add(125485464, 125000.23M);
            sortedList.Add(598632158, 253000.80M);
            sortedList.Add(542315488, 530000.56M);

            // third version
            var sortedDictionary = new SortedDictionary<int, decimal>();
            sortedDictionary.Add(125485464, 125000.23M);
            sortedDictionary.Add(598632158, 253000.80M);
            sortedDictionary.Add(542315488, 530000.56M);
        }
    }
}
