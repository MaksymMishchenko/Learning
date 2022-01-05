using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>()
            {
                new Employee{FirstName = "Maks", LastName = "Mischenko", Salary = 100000, StartWork = DateTime.Parse("01/01/2005")},

                new Employee{FirstName = "Petr", LastName = "Demchenko", Salary = 50000, StartWork = DateTime.Parse("01/01/2008")},

                new Employee{FirstName = "Artur", LastName = "Petrov", Salary = 30000, StartWork = DateTime.Parse("01/01/2020")}
            };

            var query = employees.Where(x => x.Salary > 30000)
                .OrderBy(x => x.LastName)
                .OrderBy(x => x.FirstName);

            foreach (var employee in query)
            {
                Console.WriteLine($"LastName: {employee.LastName} | FirstName: {employee.FirstName}");
            }
        }
    }
}
