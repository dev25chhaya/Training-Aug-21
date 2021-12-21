using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToysCompany.Models
{
    public class Customer
    {
        [Key]
        public Guid CustomerID { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage ="Name can only be 20 charactores long")]
        public string Name { get; set; }

    }
}
