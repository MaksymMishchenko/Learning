using System.Collections.Generic;

namespace CarApp
{
    class CarClassification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Car> Car { get; set; } = new List<Car>();
    }
}
