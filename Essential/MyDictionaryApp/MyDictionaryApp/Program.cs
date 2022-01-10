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

            var myDictionary1 = new MyDictionary<char, string>();
            myDictionary1.Add('A', "Antony");
            myDictionary1.Add('M', "Maks");
            myDictionary1.Add('P', "Petr");
        }
    }
}
