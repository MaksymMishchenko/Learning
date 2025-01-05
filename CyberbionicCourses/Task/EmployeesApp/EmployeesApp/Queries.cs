using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesApp
{
    class Queries
    {
        public void GetEmployeesByCities(List<Employee> employees, List<Cities> cities)
        {
            var result = from employee in employees
                         join city in cities on employee.CityId equals city.Id into employeesByCities
                         from employeeByCity in employeesByCities.DefaultIfEmpty()
                         select new
                         {
                             employeesFirstName = employee.FirstName,
                             employeesLastName = employee.LastName,
                             employeeCities = employeeByCity?.City
                         };

            foreach (var current in result)
            {
                Console.WriteLine($"\tFirstName: {current.employeesFirstName} | LastName: {current.employeesLastName} | City: {current.employeeCities}");
            }
        }

        /// <summary>
        /// Requests a collection of employees and select employees with salary more than 30000
        /// </summary>
        /// <param name="employees"></param>
        /// <returns>Employees collection with salary more than 30000</returns>
        public List<Employee> SelectEmployeesBySalary(List<Employee> employees, decimal salary)
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
                Console.WriteLine($"\tLastName: {item.LastName} | FirstName: {item.FirstName}");
            }
        }
    }
}
