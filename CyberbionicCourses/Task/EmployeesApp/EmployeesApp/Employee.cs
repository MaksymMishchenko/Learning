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
        public int CityId { get; set; }
        public decimal Salary { get; private set; }
        public DateTime StartWork { get; private set; }

        /// <summary>
        /// Adds employees to collection
        /// </summary>
        /// <returns>Employees Collection</returns>
        public List<Employee> GetEmployee()
        {
            var employees = new List<Employee>
            {
                new Employee
                {   
                    Id = new Guid(),
                    FirstName = "Maks",
                    LastName = "Mischenko",
                    CityId = 1,
                    Salary = 100000,
                    StartWork = DateTime.Parse("01/01/2005")
                },
                new Employee
                {
                    Id = new Guid(),
                    FirstName = "Petr",
                    LastName = "Demchenko",
                    CityId = 3,
                    Salary = 50000,
                    StartWork = DateTime.Parse("01/01/2008")
                },
                new Employee
                {
                    Id = new Guid(),
                    FirstName = "Bill",
                    LastName = "Tischenko",
                    CityId = 0,
                    Salary = 30000,
                    StartWork = DateTime.Parse("01/01/2020")
                },

                new Employee
                {
                    Id = new Guid(),
                    FirstName = "Alex",
                    LastName = "Litvinkov",
                    CityId = 1,
                    Salary = 120000,
                    StartWork = DateTime.Parse("01/01/2011")
                },
                new Employee
                {
                    Id = new Guid(),
                    FirstName = "Nick",
                    LastName = "Mihalchuk",
                    CityId = 2,
                    Salary = 30000,
                    StartWork = DateTime.Parse("01/01/2020")
                }
            };

            return employees;
        }
    }
}