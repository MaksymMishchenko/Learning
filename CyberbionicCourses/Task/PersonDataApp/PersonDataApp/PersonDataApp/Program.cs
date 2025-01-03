using System;
using System.Collections.Generic;
using PersonDataApp.Model;

namespace PersonDataApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> addPerson = new List<Person>();

            addPerson.Add(new Person("Петров", "Василий", "Кленовая, 16", "Киев"));
            addPerson.Add(new Person("Иванов", "Сергей", "Осиновая, 13", "Одесса"));
            addPerson.Add(new Person("Сидоров", "Иван", "Осиновая, 13", "Житомир"));

            ShowPerson show = new ShowPerson();

            Console.WriteLine(" \tФамилия\tИмя\tАдресс\t \tГород");
            Console.WriteLine(new string('-', 50));

            foreach (var people in addPerson)
            {
                show.Show($" \t{people.Surname}\t{people.Name}\t{people.Address}\t{people.City}");
            }
        }
    }
}
