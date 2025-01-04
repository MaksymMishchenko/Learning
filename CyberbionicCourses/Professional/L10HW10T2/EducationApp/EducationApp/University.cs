using System;

namespace EducationApp
{
    internal class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Passed the exams and enter the University");
        }

        public override void Study()
        {
            Console.WriteLine("Studied in University");
        }

        public override void PassedExams()
        {
            Console.WriteLine("Passed the exams at the University");
            Console.WriteLine("Passed the practice");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Received a diploma of higher education");
        }
    }
}
