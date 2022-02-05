using System;

namespace UserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DbContent db = new DbContent())
            {
                User maks = new User { Name = "Maks", Age = 32 };
            
                User artur = new User { Name = "Artur", Age = 21 };
            
                User sveta = new User { Name = "Sveta", Age = 25 };
            
                db.Users.AddRange(maks, artur, sveta);
                db.SaveChanges();
                Console.WriteLine("Data added successfully!");
            }
        }
    }
}
