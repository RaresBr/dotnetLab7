using System;

namespace lab7.Models.Data.Entities
{
    public class City
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
    }
}
