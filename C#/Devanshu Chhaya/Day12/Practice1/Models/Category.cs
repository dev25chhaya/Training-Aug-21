using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Models
{
    class Category
    {
        public int Id { get; set; }
        public ICollection<Categorization> Categorizations { get; set; }
    }
}
