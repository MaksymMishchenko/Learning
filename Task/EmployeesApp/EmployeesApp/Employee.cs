using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesApp
{
    class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int City { get; set; }
        public decimal Salary { get; private set; }
        public DateTime StartWork { get; private set; }

        /// <summary>
        /// Adds employees to collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>Employees Collection</returns>
        public List<Employee> AddEmployee<T>()
        {
            var employees = new List<Employee>
            {
                new Employee
                {   
                    Id = new Guid(),
                    FirstName = "Maks",
                    LastName = "Mischenko",
                    City = 1,
                    Salary = 100000,
                    StartWork = DateTime.Parse("01/01/2005")
                },
                new Employee
                {
                    Id = new Guid(),
                    FirstName = "Petr",
                    LastName = "Demchenko",
                    City = 2,
                    Salary = 50000,
                    StartWork = DateTime.Parse("01/01/2008")
                },
                new Employee
                {
                    Id = new Guid(),
                    FirstName = "Artur",
                    LastName = "Petrov",
                    City = 3,
                    Salary = 30000,
                    StartWork = DateTime.Parse("01/01/2020")
                },

                new Employee
                {
                    Id = new Guid(),
                    FirstName = "Alex",
                    LastName = "Litvinkov",
                    City = 1,
                    Salary = 120000,
                    StartWork = DateTime.Parse("01/01/2011")
                },
                new Employee
                {
                    Id = new Guid(),
                    FirstName = "Nikolay",
                    LastName = "Litvinov",
                    City = 2,
                    Salary = 30000,
                    StartWork = DateTime.Parse("01/01/2020")
                }
            };

            return employees;
        }

        /// <summary>
        /// Requests a collection of employees and select employees with salary more than 30000
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="employees"></param>
        /// <returns>Employees collection with salary more than 30000</returns>
        public List<Employee> SelectEmployees<T>(List<Employee> employees, decimal salary)
        {
            var query = employees
                .Where(x => x.Salary > salary)
                .OrderBy(x => x.LastName)
                .OrderBy(x => x.FirstName);
            return new List<Employee>(query);
        }

        /// <summary>
        /// Print employees from collection
        /// </summary>
        /// <param name="employees"></param>
        public void PrintEmployees(List<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine($"LastName: {item.LastName} | FirstName: {item.FirstName}");
            }
        }
    }
}