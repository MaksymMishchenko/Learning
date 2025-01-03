using System;

namespace EmployeesApp
{
    abstract class Employee
    {
        public void DoWork()
        {
            Work();
            GetSalary();
        }

        public virtual void Work()
        {
            Console.WriteLine("Do some work");
        }

        public abstract void GetSalary();
    }
}
