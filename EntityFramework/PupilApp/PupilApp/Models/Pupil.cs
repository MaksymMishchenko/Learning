using System.Collections.Generic;

namespace PupilApp.Models
{
    internal class Pupil
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ClassRoom> ClassRooms { get; set; } = new List<ClassRoom>();
        public List<Success> Successes { get; set; } = new List<Success>();
    }
}
