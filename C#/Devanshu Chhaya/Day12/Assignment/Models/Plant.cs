using System;
using System.Collections.Generic;
using System.Text;

namespace ToysManufacturingCompany.Models
{
    class Plant
    {
        public int PlantId { get; set; }
        public string Location { get; set; }
        public ICollection<ToysCategory> ToysCategories { get; set; }
    }
}
