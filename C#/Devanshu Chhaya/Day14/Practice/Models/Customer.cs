using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHTTPMethods.Models
{
    public class Customer
    {
        [key]
        public Guid CustomerId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name can only be 50 charactor long")]
        public string CustName { get; set; }

    }
}
