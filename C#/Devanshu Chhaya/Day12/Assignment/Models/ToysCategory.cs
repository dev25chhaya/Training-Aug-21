using System;
using System.Collections.Generic;
using System.Text;

namespace ToysManufacturingCompany.Models
{
    class ToysCategory
    {
        public int ToysCategoryId { get; set; }
        public string Name { get; set; }

        public int PlantsId { get; set; }
        public Plant Plants { get; set; }

        
        public ICollection<Toys> Toys { get; set; }
    }
}
