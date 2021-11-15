using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Models
{
    class Categorization
    {
        public int Id { get; set; }
        public int productId { get; set; }
        public Product Product { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
