using System;
using System.Collections.Generic;
using System.Text;

namespace ToysManufacturingCompany.Models
{
    class Toys
    {
        public int ToysID { get; set; }
        public string Name { get; set; }
        public int ToysCategoryId { get; set; }
        public ToysCategory ToysCategory { get; set; }

        public int UnitPrice { get; set; }
        public ICollection<Purchase> Purchase { get; set; }
    }
}
