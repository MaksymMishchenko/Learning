using System;

namespace AccessLevelApp
{
    [AccessLevel(AccessLevel.HighLevel, Name = "Maks", Position = "Director")]
    internal class Director : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Director's work");
        }
    }
}