using System;
using System.Linq;
using EmployeeApp.Model;

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
                db.Company.AddRange(apple, microsoft);
                db.Employee.AddRange(oleh, artur, volodumur);
                db.SaveChanges();

                foreach (var employee in db.Employee.ToList())
                {
                    Console.WriteLine($"{employee.FirstName} works on company: {employee.Company?.Name}");
                }
            }
        }
    }
}
