using System;

namespace PersonApp
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
