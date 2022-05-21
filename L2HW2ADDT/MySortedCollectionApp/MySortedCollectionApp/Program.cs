using System;
using System.Collections;

namespace MySortedCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sortedList = new SortedList();
            var sortedList = new SortedList(new InsensitiveComparerDescending());

            sortedList.Add("Maks", 32);
            sortedList.Add("Artur", 22);
            sortedList.Add("Dan", 45);
            sortedList.Add("Nikolas", 25);

            sortedList["NIKOLAS"] = 23;

            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"Name: {item.Key}\t Age: {item.Value}");
            }
        }
    }
}
