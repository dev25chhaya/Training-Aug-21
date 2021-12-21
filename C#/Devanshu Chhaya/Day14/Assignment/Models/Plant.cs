using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToysManufacturingCompany.Models
{
    public class Plant
    {
        [Key]
        public Guid PlantId { get; set; }
        public string Location { get; set; }
        public ICollection<ToysCategory> ToysCategories { get; set; }
    }
}
