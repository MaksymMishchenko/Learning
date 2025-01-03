using System;

namespace EducationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Education[] educations = { new School(), new University() };
            foreach (var education in educations)
                education.Learn();

            Console.ReadKey();
        }
    }
}
