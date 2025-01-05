using System;

namespace PupilApp.Models
{
    class Success
    {
        public int PupilsId { get; set; }
        public Pupil Pupil { get; set; }
        public int ClassRoomsId { get; set; }
        public ClassRoom ClassRoom { get; set; }
        public int Mark { get; set; }
        public DateTime Date { get; set; }
    }
}
