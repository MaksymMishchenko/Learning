using Microsoft.EntityFrameworkCore;
using PupilApp.Models;
using System;
using System.Linq;

namespace PupilApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DbPupils())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                var maks = new Pupil { Name = "Maks" };
                var petr = new Pupil { Name = "Petr" };
                var sergey = new Pupil { Name = "Sergey" };
                db.Pupils.AddRange(maks, petr, sergey);
                db.SaveChanges();

                var first = new ClassRoom { Name = "First" };
                var second = new ClassRoom { Name = "Second" };
                db.ClassRooms.AddRange(first, second);
                db.SaveChanges();

                first.Successes.Add(new Success{ Pupil = maks, Mark = 5, Date = DateTime.Today });
                second.Successes.Add(new Success{ Pupil = petr, Mark = 3, Date = DateTime.Today });
                second.Successes.Add(new Success{ Pupil = sergey, Date = DateTime.Today });
                db.SaveChanges();

                var getAllClassesByPupils = db.ClassRooms.Include(p => p.Pupils).ToList();

                foreach (var classRoom in getAllClassesByPupils)
                {
                    Console.WriteLine($"Class Room: {classRoom.Name}");

                    foreach (var pupil in classRoom.Successes)
                    {
                        Console.WriteLine($"\tName: {pupil.Pupil.Name}, Mark: {pupil.Mark}, Date: {pupil.Date.ToShortDateString()}");
                    }
                }
            }
        }
    }
}
