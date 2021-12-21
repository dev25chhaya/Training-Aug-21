using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToysManufacturingCompany.Models
{
    public class ToysCategory
    {
        [Key]
        public Guid ToysCategoryId { get; set; }
        public string Name { get; set; }

        public Guid PlantsId { get; set; }
        public Plant Plants { get; set; }

        public ICollection<Toys> Toys { get; set; }
    }
}
