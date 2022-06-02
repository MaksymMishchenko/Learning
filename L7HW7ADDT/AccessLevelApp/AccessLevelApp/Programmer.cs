using System;

namespace AccessLevelApp
{
    [AccessLevel(AccessLevel.MediumLevel, Name = "Peter", Position = "Programmer")]
    class Programmer : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Programmer's work");
        }
    }
}