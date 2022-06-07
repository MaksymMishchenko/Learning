using System;

namespace EmployeesApp
{
    internal class Teacher : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Teach");
        }

        public override void GetSalary()
        {
            Console.WriteLine("Teacher's salary is $2000 per month");
        }
    }
}
