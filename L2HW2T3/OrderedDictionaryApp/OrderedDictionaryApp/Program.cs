using System;
using System.Collections;
using System.Collections.Specialized;

namespace OrderedDictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var maks = new Sportsman { Key = 1, Name = "Maks", Hobbies = "Bicycle" };
            var artur = new Sportsman { Key = 2, Name = "Artur", Hobbies = "Walk" };
            var michael = new Sportsman { Key = 3, Name = "Michael", Hobbies = "Run" };
            var peter = new Sportsman { Key = 3, Name = "Peter", Hobbies = "Swim" };

            var dictionary = new OrderedDictionary(new KeyComparer());
            dictionary.Add(maks, TrainingDay.Sunday);
            dictionary.Add(artur, TrainingDay.Tuesday);
            dictionary.Add(michael, TrainingDay.Wednesday);

            try
            {
                dictionary.Add(peter, TrainingDay.Friday);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Такой ключ уже есть!");
                Console.WriteLine(ex.Message);
            }

            foreach (DictionaryEntry item in dictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"\tTraining day: {item.Value}");
            }
        }
    }
}
