using Microsoft.EntityFrameworkCore;
using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DbContent())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                var boris = new Student { Name = "Boris" };
                var maks = new Student { Name = "Maks" };
                var alex = new Student { Name = "Alex" };
                db.AddRange(boris, maks, alex);

                var cSharp = new Course { Name = "C#" };
                var java = new Course { Name = "Java" };
                var javascript = new Course { Name = "Javascript" };
                db.Courses.AddRange(cSharp, java, javascript);

                // add course to student
                boris.Courses.Add(cSharp);
                boris.Courses.Add(java);
                maks.Courses.Add(java);
                maks.Courses.Add(javascript);
                alex.Courses.Add(javascript);

                // add students to course
                cSharp.Students.AddRange(new List<Student> { boris });
                java.Students.AddRange(new List<Student> { boris });
                javascript.Students.AddRange(new List<Student> { maks });
                java.Students.AddRange(new List<Student> { maks });
                javascript.Students.AddRange(new List<Student> { alex });

                db.SaveChanges();

                //print course and all students
                foreach (var course in db.Courses.ToList())
                {
                    Console.WriteLine($"Course: {course.Name}");

                    foreach (var student in db.Students.ToList())
                    {
                        Console.WriteLine($"\tName: {student.Name}");
                    }
                }

                Console.WriteLine(new string('-', 50));

                // print course by student
                foreach (var c in db.Students.Include(s => s.Courses))
                {
                    Console.WriteLine($"Name: {c.Name}");

                    foreach (var student in c.Courses)
                    {
                        Console.WriteLine($"\tCourse: {student.Name}");
                    }
                }

                var studentAlex = db.Students.FirstOrDefault(s => s.Name == "alex");
                var courseJavaScript = db.Courses.FirstOrDefault(j => j.Name == "javascript");
                var courseCSharp = db.Courses.FirstOrDefault(c => c.Name == "C#");

                if (studentAlex != null && courseJavaScript != null && courseCSharp != null)
                {
                    studentAlex.Courses.Remove(courseJavaScript);
                    studentAlex.Courses.Add(courseCSharp);
                    db.SaveChanges();
                }

                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Result after change course at Alex");

                foreach (var c in db.Students.Include(s => s.Courses))
                {
                    Console.WriteLine($"Name: {c.Name}");

                    foreach (var student in c.Courses)
                    {
                        Console.WriteLine($"\tCourse: {student.Name}");
                    }
                }

                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Result after delete student Boris");

                var chooseBoris = db.Students.FirstOrDefault(b => b.Name == "Boris");

                if (chooseBoris != null)
                {
                    db.Students.Remove(chooseBoris);
                    db.SaveChanges();
                }

                foreach (var c in db.Students.Include(s => s.Courses))
                {
                    Console.WriteLine($"Name: {c.Name}");

                    foreach (var student in c.Courses)
                    {
                        Console.WriteLine($"\tCourse: {student.Name}");
                    }
                }
            }
        }
    }
}
