using System;

namespace AccessLevelApp
{
    [AccessLevel(AccessLevel.LowLevel, Name = "Artur", Position = "Manager")]
    class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Manager's work");
        }
    }
}