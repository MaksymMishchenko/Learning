using System;
using System.Collections.Generic;

namespace EmployeesApp
{
    class Cities
    {
        public int Id { get; set; }
        public string City { get; set; }

        public List<Cities> GetCities<T>()
        {
            var cities = new List<Cities>
            {
                new Cities{Id = 1, City = "New York"},
                new Cities{Id = 1, City = "Houston"},
                new Cities{Id = 1, City = "Chicago"}
            };

            return cities;
        }
    }
}
