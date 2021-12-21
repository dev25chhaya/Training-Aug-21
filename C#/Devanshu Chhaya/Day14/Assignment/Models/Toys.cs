using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToysManufacturingCompany.Models
{
    public class Toys
    {
        [Key]
        public Guid ToysID { get; set; }
        public string Name { get; set; }
        public Guid ToysCategoryId { get; set; }
        public ToysCategory ToysCategory { get; set; }

        public int UnitPrice { get; set; }
        public ICollection<Purchase> Purchase { get; set; }
    }
}
