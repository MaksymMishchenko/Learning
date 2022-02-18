using EmployeeApp.Model;
using System;
using System.Linq;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DbContent())
            {
                var microsoft = new Company { Name = "Microsoft" };
                var apple = new Company { Name = "Apple" };
                db.Company.AddRange(apple, microsoft);

                var oleh = new Employee
                {
                    FirstName = "Oleh",
                    Age = 21,
                    Company = microsoft
                };

                var artur = new Employee
                {
                    FirstName = "Artur",
                    Age = 23,
                    Company = apple
                };

                var volodumur = new Employee
                {
                    FirstName = "Volodumur",
                    Age = 28,
                    Company = microsoft
                };

                db.Employee.AddRange(oleh, artur, volodumur);
                db.SaveChanges();

                foreach (var employee in db.Employee.ToList())
                {
                    Console.WriteLine($"{employee.FirstName} works on company: {employee.Company?.Name}");
                }

                Console.WriteLine(new string('-', 50));

                var maks = new Person { Name = "Maks" };
                var peter = new Person { Name = "Peter" };
                db.Persons.AddRange(maks, peter);

                var sam = new Manager { Name = "Sam", Department = "IT" };
                db.Managers.Add(sam);

                var alina = new Teacher { Name = "Alina", Salary = 500 };
                db.Teachers.Add(alina);
                db.SaveChanges();

                Console.WriteLine("All person: ");
                foreach (var person in db.Persons.ToList())
                {
                    Console.WriteLine($"\tName: {person.Name}");
                }

                Console.WriteLine("Managers: ");
                foreach (var person in db.Managers.ToList())
                {
                    Console.WriteLine($"\tName: {person.Name}, Department: {person.Department}");
                }

                Console.WriteLine("Teachers: ");
                foreach (var person in db.Teachers.ToList())
                {
                    Console.WriteLine($"\tName: {person.Name}, Salary: {person.Salary}");
                }
            }
        }
    }
}
