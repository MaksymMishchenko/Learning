using System;

namespace EducationApp
{
    abstract class Education
    {
        public void Learn()
        {
            Enter();
            Study();
            PassedExams();
            GetDocument();
        }

        public abstract void Enter();

        public abstract void Study();

        public virtual void PassedExams()
        {
            Console.WriteLine("Сдал экзамены в школе");
        }

        public abstract void GetDocument();

    }
}
