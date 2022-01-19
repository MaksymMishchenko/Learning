using System;

namespace EmployeesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new Employee();
            var getEmployees = employees.GetEmployee();

            var city = new Cities();
            var getCities = city.GetCities();

            var query = new Queries();
            Console.WriteLine("Employees by cities: ");
            query.GetEmployeesByCities(getEmployees, getCities);

            var employeesBySalary = query.SelectEmployeesBySalary(getEmployees, 30000);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Employees by salary: ");
            query.PrintEmployees(employeesBySalary);
        }
    }
}
