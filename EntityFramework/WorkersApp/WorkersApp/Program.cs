using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WorkersApp.Models;

namespace WorkersApp
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new DbContent())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                // create workers
                var worker1 = new Worker { Login = "login1", Password = "1234" };
                var worker2 = new Worker { Login = "login2", Password = "5678" };
                var worker3 = new Worker { Login = "login3", Password = "8765" };
                db.Workers.AddRange(worker1, worker2, worker3);

                //create workers profile
                var maks = new WorkerProfile { Name = "Maks", Age = 32, Worker = worker1 };
                var artur = new WorkerProfile { Name = "Artur", Age = 22, Worker = worker2 };
                var dima = new WorkerProfile { Name = "Dima", Age = 25, Worker = worker3 };
                db.WorkersProfiles.AddRange(maks, artur, dima);

                db.SaveChanges();

                Console.WriteLine("All workers in database: ");

                // get all workers and print to console
                foreach (var worker in db.WorkersProfiles.Include(p => p.Worker).ToList())
                {
                    Console.WriteLine($"Name: \t{worker.Name} \nAge: \t{worker.Age}");
                    Console.WriteLine($"Login: \t{worker.Worker?.Login} \nPass: \t{worker.Worker?.Password}\n");
                }

                Console.WriteLine(new string('-', 20));

                // Change password at the first worker
                var workr = db.Workers.FirstOrDefault();

                if (workr != null)
                {
                    workr.Password = "4321";
                }

                db.SaveChanges();

                // change name at the first worker

                var workerProfile = db.WorkersProfiles.FirstOrDefault(w => w.Worker.Login == "login1");

                if (workerProfile != null)
                {
                    workerProfile.Name = "Nikolay";
                }

                Console.WriteLine("Workers after change password and name at the firts worker");

                foreach (var worker in db.WorkersProfiles.Include(p => p.Worker).ToList())
                {
                    Console.WriteLine($"Name: \t{worker.Name} \nAge: \t{worker.Age}");
                    Console.WriteLine($"Login: \t{worker.Worker?.Login} \nPass: \t{worker.Worker?.Password}\n");
                }


                Console.WriteLine(new string('-', 20));

                // delete first workers from database
                var firstWorker = db.Workers.FirstOrDefault();
                if (firstWorker != null)
                {
                    db.Workers.Remove(firstWorker);
                }

                db.SaveChanges();

                // get workers from database after delete first worker
                Console.WriteLine("Workers after delete first workers: ");
                foreach (var worker in db.Workers.Include(p => p.WorkerProfile))
                {
                    Console.WriteLine($"Name: \t{worker.WorkerProfile?.Name}");
                }
            }
        }
    }
}
