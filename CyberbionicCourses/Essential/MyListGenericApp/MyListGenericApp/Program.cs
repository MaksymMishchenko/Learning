using System;
using System.Collections.Generic;

namespace MyListGenericApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList<string>();
            myList.Add("Maks");
            myList.Add("Dima");
            myList.Add("Vova");
            myList.Insert(3, "Petr");

            var getElementByIndex= myList[1];
            Console.WriteLine($"Element by index: {getElementByIndex}");

            var getLength = myList.GetLength;
            Console.WriteLine($"Collection Length: {getLength}");

            PrintCollection(myList);
        }

        static void PrintCollection<T>(MyList<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine($"Name: {item}");
            }
        }
    }
}
