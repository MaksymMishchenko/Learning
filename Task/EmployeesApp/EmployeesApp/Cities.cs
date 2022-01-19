using System.Collections.Generic;

namespace EmployeesApp
{
    class Cities
    {
        public int Id { get; set; }
        public string City { get; set; }

        public List<Cities> GetCities()
        {
            var cities = new List<Cities>
            {
                new Cities{Id = 1, City = "New York"},
                new Cities{Id = 2, City = "Houston"},
                new Cities{Id = 3, City = "Chicago"}
            };

            return cities;
        }
    }
}
