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

        public Student GetStudent()
        {
            var student = new Student();

            student.Id = Guid.NewGuid();
            student.FirstName = "Boris";
            student.MiddleName = "Semenovuch";
            student.LastName = "Prihodko";
            student.Age = 23;
            student.Group = "P-312";

            return student;
        }
        public void PrintStudent(Student person)
        {
            Console.WriteLine($"Id: {person.Id}");
            Console.WriteLine($"Имя: {person.FirstName}");
            Console.WriteLine($"Отчество: {person.MiddleName}");
            Console.WriteLine($"Фамилия: {person.LastName}");
            Console.WriteLine($"Возраст: {person.Age}");
            Console.WriteLine($"Группа: {person.Group}");
        }
    }
}