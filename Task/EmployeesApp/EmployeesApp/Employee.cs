using System;
using System.Collections.Generic;

namespace EmployeesApp
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public DateTime StartWork { get; set; }

        public List<Employee> AddEmployee<T>()
        {
            var employees = new List<Employee>()
            {
                new Employee
                {
                    FirstName = "Maks", LastName = "Mischenko", Salary = 100000,
                    StartWork = DateTime.Parse("01/01/2005")
                },
                new Employee
                {
                    FirstName = "Petr", LastName = "Demchenko", Salary = 50000, StartWork = DateTime.Parse("01/01/2008")
                },
                new Employee
                {
                    FirstName = "Artur", LastName = "Petrov", Salary = 30000, StartWork = DateTime.Parse("01/01/2020")
                }
            };

            return employees;
        }
    }
}