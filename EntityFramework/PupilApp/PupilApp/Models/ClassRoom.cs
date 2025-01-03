using System.Collections.Generic;

namespace PupilApp.Models
{
    internal class ClassRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Pupil> Pupils { get; set; } = new List<Pupil>();
        public List<Success> Successes { get; set; } = new List<Success>();
    }
}