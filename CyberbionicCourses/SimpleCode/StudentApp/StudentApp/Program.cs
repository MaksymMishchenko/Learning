using System;

namespace StudentApp
{
    class Program
    {
        public static Student GetStudent()
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
        static void Main(string[] args)
        {
            var person = GetStudent();
            person.PrintStudent();
            var fullName = person.GetFullName();
            Console.WriteLine();
            Console.WriteLine($"Полное имя студента: {fullName}");
        }
    }
}
