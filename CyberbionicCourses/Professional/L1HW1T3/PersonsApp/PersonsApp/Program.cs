using System;

namespace PersonsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // create citizens
            Citizen maks = new Student { Name = "Maks", PassportId = 12345, Age = 32, Type = "Student" };
            Citizen peter = new Student { Name = "Peter", PassportId = 54321, Age = 25, Type = "Student" };
            Citizen august = new Retired { Name = "August", PassportId = 32145, Age = 55, Type = "Retired" };
            Citizen michael = new Retired { Name = "Michael", PassportId = 45321, Age = 58, Type = "Retired" };
            Citizen artur = new Worker { Name = "Artur", PassportId = 15243, Age = 23, Type = "Worker" };

            // create collection
            var coll = new Collection();

            coll.Add(maks);

            // attempt to added the same citizen Maks = throw new Argument exception
            coll.Add(maks);
            coll.Add(peter);
            coll.Add(august);
            coll.Add(michael);

            var contains = coll.Contains(maks);
            Console.WriteLine($"IsContains: {contains}");
            Console.WriteLine(new string('-', 20));

            var citizen = coll.ReturnLast().ToString();
            Console.WriteLine(citizen);
            Console.WriteLine(new string('-', 20));

            coll.Add(artur);
            Console.WriteLine(new string('-', 20));
            var citizen1 = coll.ReturnLast();
            Console.WriteLine(citizen1);

            Console.WriteLine($"All elements by collection:");

            foreach (var person in coll)
            {
                Console.WriteLine($"Person: {person}");
            }

            coll.Clear();
        }
    }
}
