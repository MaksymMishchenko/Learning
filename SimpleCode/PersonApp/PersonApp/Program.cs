using System;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student { FirstName = "Maksim", LastName = "Sverdil"};
            Teacher teacher = new Teacher { FirstName = "Svitlana", LastName = "Grigorovich" };

            Person[] people = { student, teacher };
            PrintPeople(people);
        }

        static void PrintPeople(Person[] people)
        {
            foreach (var person in people)
            {
                person.PrintFullName();
            }
        }
    }
}
