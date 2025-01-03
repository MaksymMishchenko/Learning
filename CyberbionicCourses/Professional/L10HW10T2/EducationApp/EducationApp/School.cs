using System;

namespace EducationApp
{
    internal class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Went to the first class");
        }

        public override void Study()
        {
            Console.WriteLine("Studied in school");
        }

        public override void PassedExams()
        {
            Console.WriteLine("Passed the exams at the school");
        }

        public override void GetDocument()
        {
            Console.WriteLine("received a diploma of secondary education");
        }
    }
}
