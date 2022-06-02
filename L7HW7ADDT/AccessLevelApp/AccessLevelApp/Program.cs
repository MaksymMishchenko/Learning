using System;

namespace AccessLevelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            var programmer = new Programmer();
            var director = new Director();

            Console.WriteLine("Employees works:");
            Console.WriteLine(new string('-', 17));

            manager.Work();
            programmer.Work();
            director.Work();

            Type type = typeof(Manager);

            object[] attributes = type.GetCustomAttributes(true);

            Console.WriteLine("Employees name & Position:");
            Console.WriteLine(new string('-', 27));

            foreach (AccessLevelAttribute attribute in attributes)
            {
                Console.WriteLine($"Name: {attribute.Name},\t Position:\t {attribute.Position}");
            }

            type = typeof(Programmer);

            attributes = type.GetCustomAttributes(true);

            foreach (AccessLevelAttribute attribute in attributes)
            {
                Console.WriteLine($"Name: {attribute.Name},\t Position:\t {attribute.Position}");
            }

            type = typeof(Director);

            attributes = type.GetCustomAttributes(true);

            foreach (AccessLevelAttribute attribute in attributes)
            {
                Console.WriteLine($"Name: {attribute.Name},\t Position:\t {attribute.Position}");
            }
        }
    }
}
