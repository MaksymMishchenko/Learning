using System;

namespace PersonsApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var maks = new Student { Name = "Maks", PassportId = 12345, Age = 32 };
            var peter = new Student { Name = "Peter", PassportId = 54321, Age = 25 };

            var august = new Retired() { Name = "August", PassportId = 32145, Age = 25 };
            var michael = new Retired() { Name = "Michael", PassportId = 45321, Age = 25 };

            var coll = new Collection();

            coll.Add(maks);
            coll.Add(peter);
            coll.Add(august);
            coll.Add(michael);
        }
    }
}
