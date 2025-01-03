using System;

namespace MyDictionaryApp
{
    class Program
    {
        static void Main()
        {
            var myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(0, "First");
            myDictionary.Add(1, "Second");
            myDictionary.Add(2, "Third");

            var length = myDictionary.GetLength;
            Console.WriteLine($"Dictionary Lenght: {length}");

            var elementByIndex = myDictionary[1];
            Console.WriteLine($"Element by index: {elementByIndex}");

            var myDictionary1 = new MyDictionary<char, string>();
            myDictionary1.Add('A', "Antony");
            myDictionary1.Add('M', "Maks");
            myDictionary1.Add('P', "Petr");
            myDictionary1.Add('N', "Nikolay");
            myDictionary1.Add('M', "Marina");
            myDictionary1.Add('O', "Olesya");

            var length1 = myDictionary1.GetLength;
            Console.WriteLine($"Dictionary Lenght: {length1}");

            var elementByIndex1 = myDictionary1[3];
            Console.WriteLine($"Element by index: {elementByIndex1}");
        }
    }
}
