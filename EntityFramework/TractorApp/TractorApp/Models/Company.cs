using System.Collections.Generic;

namespace TractorApp.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Tractor> Tractors { get; set; }
    }
}