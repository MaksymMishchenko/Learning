using System;

namespace StudentApp
{
    class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }

        public void PrintStudent()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Имя: {FirstName}");
            Console.WriteLine($"Отчество: {MiddleName}");
            Console.WriteLine($"Фамилия: {LastName}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Группа: {Group}");
        }

        public string GetFullName()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }
    }
}