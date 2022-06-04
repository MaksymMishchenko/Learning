using System;

namespace StudentsApp
{
    [Serializable]
    class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }

        public Student(Guid id, string name, int age, string @group)
        {
            Id = id;
            Name = name;
            Age = age;
            Group = @group;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}, Group: {Group}");
        }
    }
}
