using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new Employee();

            var employeesList = employees.AddEmployee<Employee>();
            var queryEmployess = employees.SelectEmployees<Employee>(employeesList);
            employees.PrintEmployees(queryEmployess);
        }
    }
}
