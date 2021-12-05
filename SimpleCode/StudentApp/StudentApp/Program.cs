using System;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student person = new Student();
            var student = person.GetStudent();
            person.PrintStudent(student);
        }
    }
}
